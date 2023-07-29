using System.Diagnostics;
using System.Threading;
using System.IO;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ClickAction
{
    public enum CommandOutputLevel
    {
        Info,
        Error,
    }

    public delegate void OnCommandOutput(CommandOutputLevel level, string msg);

    public class CommandRunner
    {
        Process process;
        Thread thread=null;
        
        OnCommandOutput onCommandOutput;
  
        private const string TEMP_FOLDER = ".action-temp";

        public CommandRunner( OnCommandOutput onCommandOutput)
        {            
            this.onCommandOutput = onCommandOutput;
        }

        public void Run(List< ActionItemData> cmdDatas)
        {
            Stop();
            if (!Directory.Exists(TEMP_FOLDER))
            {
                Directory.CreateDirectory(TEMP_FOLDER);
            }

             
            thread = new Thread(new ParameterizedThreadStart(RunTaskInThread));
            thread.Start(cmdDatas);
            
        }

        public void Stop()
        {
            if(process != null)
            {
                try
                {
                    if (!process.HasExited)
                    {
                        //process.StandardInput.Write("\x3");

                        KillProcessTree(process);
                        process.WaitForExit();
                        process.Dispose();
                    }
                     
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            if (thread != null)
            {
                try
                {
                    thread.Abort();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            
            process = null;
            thread = null;
        }

        public void RunTaskInThread(object args)
        {
            List<ActionItemData> actionItemDatas = args as List<ActionItemData>;
            foreach (ActionItemData cmdData in actionItemDatas)
            {
                if(string.IsNullOrEmpty(cmdData.command))
                {
                    continue;
                }
                string commandFile = null;
                string workdDir = null;
                workdDir = "";
                if (cmdData.cwd != null)
                {
                    workdDir = cmdData.cwd.Replace("/", "\\");
                }
                Random rand = new Random();
                commandFile = string.Format("{0}\\{1}-{2}.bat", TEMP_FOLDER, cmdData.name, 1);

                commandFile = commandFile.Replace(" ", "_");
                commandFile = Path.GetFullPath(commandFile);
                File.WriteAllText(commandFile, cmdData.command);

                process = new Process();
                var info = process.StartInfo;
                info.FileName = commandFile;
                info.WorkingDirectory = workdDir;
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                info.RedirectStandardOutput = true;
                info.RedirectStandardError = true;
                info.RedirectStandardInput = true;
            
                process.OutputDataReceived += OnOutput;
                process.ErrorDataReceived += OnError;
                process.Start();            

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                if (File.Exists(commandFile))
                {
                    File.Delete(commandFile);
                }
            }
        }

        private  void OnOutput(object sender, DataReceivedEventArgs e)
        {
            if (onCommandOutput != null) {
                if (e.Data != null)
                {
                    onCommandOutput(CommandOutputLevel.Info, e.Data);
                }
            }
        }

        private void OnError(object sender, DataReceivedEventArgs e)
        {
            if (onCommandOutput != null)
            {
                if (e.Data != null)
                {
                    onCommandOutput(CommandOutputLevel.Error, e.Data);
                }
            }
        }


        // [StructLayout(LayoutKind.Sequential)]
        private struct ProcessBasicInformation
        {
            public int ExitStatus;
            public int PebBaseAddress;
            public int AffinityMask;
            public int BasePriority;
            public uint UniqueProcessId;
            public uint InheritedFromUniqueProcessId;
        }

        [DllImport("ntdll.dll")]
        static extern int NtQueryInformationProcess(
           IntPtr hProcess,
           int processInformationClass /* 0 */,
           ref ProcessBasicInformation processBasicInformation,
           uint processInformationLength,
           out uint returnLength
        );

        public static void KillProcessTree( Process parent)
        {
            var processes = Process.GetProcesses();
            foreach (var p in processes)
            {
                var pbi = new ProcessBasicInformation();
                try
                {
                    uint bytesWritten;
                    if (NtQueryInformationProcess(p.Handle, 0, ref pbi, (uint)Marshal.SizeOf(pbi), out bytesWritten) == 0) // == 0 is OK
                    {
                        if (pbi.InheritedFromUniqueProcessId == parent.Id)
                        {
                            using (var newParent = Process.GetProcessById((int)pbi.UniqueProcessId))
                            {
                                KillProcessTree(newParent);
                            }
                        }
                    }
                }
                catch(Exception e) {
                    //MessageBox.Show(e.Message);
                }
            }
            parent.Kill();
        }

    }
}
