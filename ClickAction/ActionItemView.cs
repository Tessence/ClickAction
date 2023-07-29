using System;
using System.Collections.Generic; 
using System.Windows.Forms;

namespace ClickAction
{
   
    
    public partial class ActionItemView : UserControl
    {
        ActionItemData itemData;
        CommandRunner commandRunner;
        OnCommandOutput onShowCommandOuput;
        public Action<string> onNameChanged;
        public TabPage tabPage;
        public Action onActionRun;
        public Action<ActionItemView> onOrderAscView;
        private Main mainForm;
        private bool formLoaded = false;
        public ActionItemView(ActionItemData itemData, Main mainForm)
        {
            this.itemData = itemData;
            if (itemData.relys == null)
            {
                itemData.relys = new List<string>();
            }
            this.mainForm = mainForm;
            InitializeComponent();
            onShowCommandOuput = ShowCommandOuput;

            commandRunner = new CommandRunner( OnCommandOutput);
        }

        public ActionItemData GetActionItemData()
        {
            //this.itemData.command = teCommand.Document.TextContent;
            return itemData;
        }

        private void ActionItemView_Load(object sender, EventArgs e)
        {
            tbName.Text = itemData.name;
            tbCwd.Text= itemData.cwd;   

            lvAllAction.Items.Clear();
            
            var allActionData = mainForm.AllActionItemData;
            foreach (var item in allActionData)
            {
                ListViewItem listViewItem = new ListViewItem();
                if (item.name == itemData.name)
                {
                    continue;
                }
                listViewItem.Text = item.name;
                if (itemData.relys.Contains(item.name))
                {
                    listViewItem.Checked = true;
                }
                lvAllAction.Items.Add(listViewItem);
            }
            formLoaded = true;

            teCommand.Text = itemData.command;        
            teCommand.TextChanged += Document_TextContentChanged;
        }

        private void Document_TextContentChanged(object sender, EventArgs e)
        {
            this.itemData.command = teCommand.Text;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            List<ActionItemData> actionItemDatas = new List<ActionItemData>();
            foreach(string rely in itemData.relys)
            {
                var relayData = mainForm.GetActionItemData(rely);
                if (relayData != null)
                {
                    actionItemDatas.Add(relayData); 
                }
            }
            actionItemDatas.Add(this.itemData);

            commandRunner.Run( actionItemDatas);
            if (onActionRun != null)
            {
                onActionRun();
            }
        }


        private void OnCommandOutput(CommandOutputLevel level, string msg)
        {
            this.Invoke(this.onShowCommandOuput, level, msg);
        }

        private void ShowCommandOuput(CommandOutputLevel level, string msg)
        {
            if(lbLog.Items.Count > 1000)
            {
                lbLog.Items.RemoveAt(0);
            }
            var now  = DateTime.Now;

            lbLog.Items.Add(String.Format("[{2}][{0}]:{1}", level, msg, now.ToLongTimeString()));
            int max = lbLog.Height / lbLog.ItemHeight;
            lbLog.TopIndex = lbLog.Items.Count > max ? lbLog.Items.Count - max : 0;
        }

        public void Terminate()
        {
            commandRunner.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            commandRunner.Stop();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            this.itemData.name = tbName.Text.Trim();
            if (onNameChanged != null)
            {
                onNameChanged(tbName.Text);
            }
            tabPage.Text = tbName.Text;
        }

        private void tbCwd_TextChanged(object sender, EventArgs e)
        {
            this.itemData.cwd = tbCwd.Text;
        }


        private void teCommand_Changed(object sender, EventArgs e)
        {
           this.itemData.command = teCommand.Text;
        }

        private void lvAllAction_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(formLoaded)
            {
                this.itemData.relys.Clear();
                foreach(var item in lvAllAction.CheckedItems)
                {
                    ListViewItem listViewItem = item as ListViewItem;
                    this.itemData.relys.Add(listViewItem.Text);
                }
            }
        }

        private void btnOrderAsc_Click(object sender, EventArgs e)
        {
            if (onOrderAscView != null)
            {
                onOrderAscView(this);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
