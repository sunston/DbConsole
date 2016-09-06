namespace DbConsole
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ConnectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SQLStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BeginButton = new System.Windows.Forms.ToolStripButton();
            this.CommitButton = new System.Windows.Forms.ToolStripButton();
            this.RollbackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExecuteButton = new System.Windows.Forms.ToolStripButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.ListViewProviders = new System.Windows.Forms.ListView();
            this.columnHeaderProvider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitterV = new System.Windows.Forms.Splitter();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelDataSet = new System.Windows.Forms.Panel();
            this.ListViewDataSet = new DbConsole.DoubleBufferedListView();
            this.splitterH = new System.Windows.Forms.Splitter();
            this.panelSQL = new System.Windows.Forms.Panel();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelDataSet.SuspendLayout();
            this.panelSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionStatusLabel,
            this.SQLStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 446);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(843, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // SQLStatusLabel
            // 
            this.SQLStatusLabel.Name = "SQLStatusLabel";
            this.SQLStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BeginButton,
            this.CommitButton,
            this.RollbackButton,
            this.toolStripSeparator1,
            this.ExecuteButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(843, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BeginButton
            // 
            this.BeginButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BeginButton.Enabled = false;
            this.BeginButton.Image = ((System.Drawing.Image)(resources.GetObject("BeginButton.Image")));
            this.BeginButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(23, 22);
            this.BeginButton.Text = "Begin transaction";
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // CommitButton
            // 
            this.CommitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CommitButton.Enabled = false;
            this.CommitButton.Image = ((System.Drawing.Image)(resources.GetObject("CommitButton.Image")));
            this.CommitButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(23, 22);
            this.CommitButton.Text = "Commit transaction";
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // RollbackButton
            // 
            this.RollbackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RollbackButton.Enabled = false;
            this.RollbackButton.Image = ((System.Drawing.Image)(resources.GetObject("RollbackButton.Image")));
            this.RollbackButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.RollbackButton.Name = "RollbackButton";
            this.RollbackButton.Size = new System.Drawing.Size(23, 22);
            this.RollbackButton.Text = "Rollback transaction";
            this.RollbackButton.Click += new System.EventHandler(this.RollbackButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExecuteButton.Enabled = false;
            this.ExecuteButton.Image = ((System.Drawing.Image)(resources.GetObject("ExecuteButton.Image")));
            this.ExecuteButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(23, 22);
            this.ExecuteButton.Text = "Execute SQL query";
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.ListViewProviders);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(622, 25);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(221, 421);
            this.panelRight.TabIndex = 2;
            // 
            // ListViewProviders
            // 
            this.ListViewProviders.CheckBoxes = true;
            this.ListViewProviders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderProvider});
            this.ListViewProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewProviders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewProviders.Location = new System.Drawing.Point(0, 0);
            this.ListViewProviders.Name = "ListViewProviders";
            this.ListViewProviders.Size = new System.Drawing.Size(221, 421);
            this.ListViewProviders.TabIndex = 0;
            this.ListViewProviders.UseCompatibleStateImageBehavior = false;
            this.ListViewProviders.View = System.Windows.Forms.View.Details;
            this.ListViewProviders.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewProviders_ItemChecked);
            this.ListViewProviders.SelectedIndexChanged += new System.EventHandler(this.ListViewProviders_SelectedIndexChanged);
            // 
            // columnHeaderProvider
            // 
            this.columnHeaderProvider.Text = "Avalible providers";
            this.columnHeaderProvider.Width = 200;
            // 
            // splitterV
            // 
            this.splitterV.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterV.Location = new System.Drawing.Point(617, 25);
            this.splitterV.Name = "splitterV";
            this.splitterV.Size = new System.Drawing.Size(5, 421);
            this.splitterV.TabIndex = 3;
            this.splitterV.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelDataSet);
            this.panelLeft.Controls.Add(this.splitterH);
            this.panelLeft.Controls.Add(this.panelSQL);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 25);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(617, 421);
            this.panelLeft.TabIndex = 4;
            // 
            // panelDataSet
            // 
            this.panelDataSet.Controls.Add(this.ListViewDataSet);
            this.panelDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataSet.Location = new System.Drawing.Point(0, 136);
            this.panelDataSet.Name = "panelDataSet";
            this.panelDataSet.Size = new System.Drawing.Size(617, 285);
            this.panelDataSet.TabIndex = 2;
            // 
            // ListViewDataSet
            // 
            this.ListViewDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewDataSet.FullRowSelect = true;
            this.ListViewDataSet.GridLines = true;
            this.ListViewDataSet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListViewDataSet.HideSelection = false;
            this.ListViewDataSet.Location = new System.Drawing.Point(0, 0);
            this.ListViewDataSet.Name = "ListViewDataSet";
            this.ListViewDataSet.Size = new System.Drawing.Size(617, 285);
            this.ListViewDataSet.TabIndex = 0;
            this.ListViewDataSet.UseCompatibleStateImageBehavior = false;
            this.ListViewDataSet.View = System.Windows.Forms.View.Details;
            // 
            // splitterH
            // 
            this.splitterH.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterH.Location = new System.Drawing.Point(0, 131);
            this.splitterH.Name = "splitterH";
            this.splitterH.Size = new System.Drawing.Size(617, 5);
            this.splitterH.TabIndex = 1;
            this.splitterH.TabStop = false;
            // 
            // panelSQL
            // 
            this.panelSQL.Controls.Add(this.textBoxSQL);
            this.panelSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSQL.Location = new System.Drawing.Point(0, 0);
            this.panelSQL.Name = "panelSQL";
            this.panelSQL.Size = new System.Drawing.Size(617, 131);
            this.panelSQL.TabIndex = 0;
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSQL.Location = new System.Drawing.Point(0, 0);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSQL.Size = new System.Drawing.Size(617, 131);
            this.textBoxSQL.TabIndex = 0;
            this.textBoxSQL.TextChanged += new System.EventHandler(this.textBoxSQL_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 468);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.splitterV);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Universal console for working with database DbConsole";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelDataSet.ResumeLayout(false);
            this.panelSQL.ResumeLayout(false);
            this.panelSQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BeginButton;
        private System.Windows.Forms.ToolStripButton CommitButton;
        private System.Windows.Forms.ToolStripButton RollbackButton;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Splitter splitterV;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelDataSet;
        private System.Windows.Forms.Splitter splitterH;
        private System.Windows.Forms.Panel panelSQL;
        private System.Windows.Forms.TextBox textBoxSQL;
        private DoubleBufferedListView ListViewDataSet;
        private System.Windows.Forms.ToolStripStatusLabel SQLStatusLabel;
        private System.Windows.Forms.ListView ListViewProviders;
        private System.Windows.Forms.ColumnHeader columnHeaderProvider;
        private System.Windows.Forms.ToolStripStatusLabel ConnectionStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExecuteButton;
    }
}

