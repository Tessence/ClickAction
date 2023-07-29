using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClickAction
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        List<ActionItemView> actionViews = new List<ActionItemView>();

         
        List<ActionItemData> allActionItemData = new List<ActionItemData>();
        string selectedActionName = null;
        public ActionItemData GetActionItemData(string name)
        {
            ActionItemData actionItemData = null;
             foreach(ActionItemData item in allActionItemData)
            {
                if(item.name == name)
                {
                    actionItemData = item;
                    break;
                }
            }
            return actionItemData;
        }
        public List<ActionItemData> AllActionItemData
        {
            get
            {
                return allActionItemData;
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            String workPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            System.Environment.CurrentDirectory = workPath;
            this.Text = this.Text + " " + workPath;
            FinalActionFile = Path.GetDirectoryName( System.Windows.Forms.Application.ExecutablePath) +"\\"+ ClickActionFile;
            LoadFromFile();
        }

        private const string ClickActionFile = "click-action.json";
        private string FinalActionFile = null;


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ActionItemView item in actionViews)
            {
                item.Terminate();
            }
        }
     

        private void reloadActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void saveActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void newActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = new ActionItemData("action" + actionViews.Count, "./", "");
             
            ActionItemView view = new ActionItemView(item,this);
            
            actionViews.Add(view);
            this.Invalidate();
            SaveToFile();
            LoadFromFile();
            tabCtrlActions.SelectedIndex = tabCtrlActions.TabCount - 1;
        }

        private void onActionRunClicked()
        {
            SaveToFile();
        }

        private void SaveToFile()
        {
            List<ActionItemData> items = new List<ActionItemData>();
            foreach (ActionItemView item in actionViews)
            {
                items.Add(item.GetActionItemData());
            }
            string content = ActionItemData.MarshalList(items);
            File.WriteAllText(FinalActionFile, content);
            
        }


        private void LoadFromFile()
        {
            if (File.Exists(FinalActionFile))
            {
                string content = File.ReadAllText(FinalActionFile);
                var actions = ActionItemData.UnMarshalList(content);
                allActionItemData.Clear();
                actionViews.Clear();
                tabCtrlActions.TabPages.Clear();

                foreach (ActionItemData item in actions)
                {                    
                    allActionItemData.Add(item);
                }

                foreach (ActionItemData item in actions)
                {
                    TabPage page = new TabPage(item.name);
                    tabCtrlActions.TabPages.Add(page);
                    ActionItemView view = new ActionItemView(item,this);
                    view.onActionRun = onActionRunClicked;
                    view.onOrderAscView = OnOrderViewAsc;
                    view.tabPage = page;
                    view.Dock = DockStyle.Fill;
                    page.Controls.Add(view);
                    actionViews.Add(view);
                    if (item.name.Equals(this.selectedActionName))
                    {
                        tabCtrlActions.SelectedTab = page;
                    }
                }
            }
        }

        private void OnOrderViewAsc(ActionItemView view)
        {
            int index = actionViews.IndexOf(view);
            if(index <= 0)
            {
                return;
            }
            ActionItemView temp = view;
            actionViews[index] = actionViews[index - 1];
            actionViews[index - 1] = view;
            SaveToFile();
            LoadFromFile();
        }

        private void deleteCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Confirm Delete?","Tips",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            if (result != DialogResult.OK)
            {
                return;
            }

            TabPage page = tabCtrlActions.TabPages[ tabCtrlActions.SelectedIndex];
            ActionItemView itemView = actionViews[tabCtrlActions.SelectedIndex];
            page.Controls.Remove(itemView);
            actionViews.Remove(itemView);
            tabCtrlActions.TabPages.Remove(page);
            SaveToFile();
        }

        private void tabCtrlActions_Selected(object sender, TabControlEventArgs e)
        {
            foreach(ActionItemView item in actionViews)
            {
                if(e.TabPage == item.tabPage)
                {
                    this.selectedActionName = item.GetActionItemData().name;
                    break;
                }
            }
        }
    }
}
