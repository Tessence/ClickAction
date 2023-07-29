namespace ClickAction
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabCtrlActions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabCtrlActions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlActions
            // 
            this.tabCtrlActions.Controls.Add(this.tabPage1);
            this.tabCtrlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlActions.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabCtrlActions.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlActions.Name = "tabCtrlActions";
            this.tabCtrlActions.SelectedIndex = 0;
            this.tabCtrlActions.Size = new System.Drawing.Size(1669, 868);
            this.tabCtrlActions.TabIndex = 0;
            this.tabCtrlActions.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlActions_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1661, 831);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1671, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadActionsToolStripMenuItem,
            this.saveActionsToolStripMenuItem,
            this.newActionToolStripMenuItem,
            this.deleteCurrentToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(96, 28);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // reloadActionsToolStripMenuItem
            // 
            this.reloadActionsToolStripMenuItem.Name = "reloadActionsToolStripMenuItem";
            this.reloadActionsToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.reloadActionsToolStripMenuItem.Text = "Reload Actions";
            this.reloadActionsToolStripMenuItem.Click += new System.EventHandler(this.reloadActionsToolStripMenuItem_Click);
            // 
            // saveActionsToolStripMenuItem
            // 
            this.saveActionsToolStripMenuItem.Name = "saveActionsToolStripMenuItem";
            this.saveActionsToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.saveActionsToolStripMenuItem.Text = "Save Actions";
            this.saveActionsToolStripMenuItem.Click += new System.EventHandler(this.saveActionsToolStripMenuItem_Click);
            // 
            // newActionToolStripMenuItem
            // 
            this.newActionToolStripMenuItem.Name = "newActionToolStripMenuItem";
            this.newActionToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.newActionToolStripMenuItem.Text = "New Action";
            this.newActionToolStripMenuItem.Click += new System.EventHandler(this.newActionToolStripMenuItem_Click);
            // 
            // deleteCurrentToolStripMenuItem
            // 
            this.deleteCurrentToolStripMenuItem.Name = "deleteCurrentToolStripMenuItem";
            this.deleteCurrentToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.deleteCurrentToolStripMenuItem.Text = "Delete Current";
            this.deleteCurrentToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabCtrlActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1671, 870);
            this.panel1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 902);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click Action";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabCtrlActions.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtrlActions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newActionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentToolStripMenuItem;
    }
}

