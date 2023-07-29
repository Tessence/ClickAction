namespace ClickAction
{
    partial class ActionItemView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbCwd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrderAsc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.teCommand = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvAllAction = new System.Windows.Forms.ListView();
            this.colActionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRun.Location = new System.Drawing.Point(15, 7);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(78, 25);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbCwd
            // 
            this.tbCwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCwd.Location = new System.Drawing.Point(76, 7);
            this.tbCwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCwd.Name = "tbCwd";
            this.tbCwd.Size = new System.Drawing.Size(175, 23);
            this.tbCwd.TabIndex = 2;
            this.tbCwd.TextChanged += new System.EventHandler(this.tbCwd_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOrderAsc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.tbCwd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 38);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOrderAsc
            // 
            this.btnOrderAsc.Location = new System.Drawing.Point(11, 5);
            this.btnOrderAsc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrderAsc.Name = "btnOrderAsc";
            this.btnOrderAsc.Size = new System.Drawing.Size(50, 25);
            this.btnOrderAsc.TabIndex = 6;
            this.btnOrderAsc.Text = "<<";
            this.btnOrderAsc.UseVisualStyleBackColor = true;
            this.btnOrderAsc.Click += new System.EventHandler(this.btnOrderAsc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(674, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 38);
            this.panel2.TabIndex = 5;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(97, 7);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 25);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(255, 7);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(159, 23);
            this.tbName.TabIndex = 4;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbLog
            // 
            this.lbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 17;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLog.Size = new System.Drawing.Size(871, 248);
            this.lbLog.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbLog);
            this.splitContainer1.Size = new System.Drawing.Size(873, 614);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.teCommand);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(136, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(735, 359);
            this.panel4.TabIndex = 4;
            // 
            // teCommand
            // 
            this.teCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teCommand.Location = new System.Drawing.Point(0, 0);
            this.teCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teCommand.Multiline = true;
            this.teCommand.Name = "teCommand";
            this.teCommand.Size = new System.Drawing.Size(735, 359);
            this.teCommand.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lvAllAction);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 359);
            this.panel3.TabIndex = 3;
            // 
            // lvAllAction
            // 
            this.lvAllAction.CheckBoxes = true;
            this.lvAllAction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colActionName});
            this.lvAllAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAllAction.HideSelection = false;
            this.lvAllAction.HoverSelection = true;
            this.lvAllAction.Location = new System.Drawing.Point(0, 0);
            this.lvAllAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvAllAction.MultiSelect = false;
            this.lvAllAction.Name = "lvAllAction";
            this.lvAllAction.Size = new System.Drawing.Size(134, 357);
            this.lvAllAction.TabIndex = 2;
            this.lvAllAction.UseCompatibleStateImageBehavior = false;
            this.lvAllAction.View = System.Windows.Forms.View.Details;
            this.lvAllAction.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvAllAction_ItemChecked);
            // 
            // colActionName
            // 
            this.colActionName.Text = "Action";
            this.colActionName.Width = 139;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ActionItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ActionItemView";
            this.Size = new System.Drawing.Size(873, 652);
            this.Load += new System.EventHandler(this.ActionItemView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbCwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvAllAction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader colActionName;
        private System.Windows.Forms.Button btnOrderAsc;        
        private System.Windows.Forms.TextBox teCommand;
    }
}
