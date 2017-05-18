namespace Reminder_WindowEditor
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.processList = new System.Windows.Forms.DataGridView();
            this.processes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainWindowTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripProcessList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRemoveWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWindowPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWindowSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
            this.contextMenuStripProcessList.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.AllowUserToAddRows = false;
            this.processList.AllowUserToDeleteRows = false;
            this.processList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processes,
            this.PID,
            this.mainWindowTitle});
            this.processList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.processList.Location = new System.Drawing.Point(13, 28);
            this.processList.MinimumSize = new System.Drawing.Size(50, 50);
            this.processList.MultiSelect = false;
            this.processList.Name = "processList";
            this.processList.ReadOnly = true;
            this.processList.RowHeadersVisible = false;
            this.processList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.processList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processList.Size = new System.Drawing.Size(619, 434);
            this.processList.TabIndex = 0;
            this.processList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processList_CellClick);
            this.processList.Click += new System.EventHandler(this.processList_Click);
            this.processList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.processList_MouseClick);
            // 
            // processes
            // 
            this.processes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.processes.HeaderText = "Processes";
            this.processes.Name = "processes";
            this.processes.ReadOnly = true;
            this.processes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.processes.Width = 62;
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PID.Width = 31;
            // 
            // mainWindowTitle
            // 
            this.mainWindowTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainWindowTitle.HeaderText = "Main Window Title";
            this.mainWindowTitle.Name = "mainWindowTitle";
            this.mainWindowTitle.ReadOnly = true;
            this.mainWindowTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ticker
            // 
            this.ticker.Enabled = true;
            this.ticker.Interval = 1000;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // contextMenuStripProcessList
            // 
            this.contextMenuStripProcessList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRemoveWindow,
            this.changeWindowPositionToolStripMenuItem,
            this.changeWindowSizeToolStripMenuItem});
            this.contextMenuStripProcessList.Name = "contextMenuStripProcessList";
            this.contextMenuStripProcessList.Size = new System.Drawing.Size(251, 70);
            this.contextMenuStripProcessList.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStripProcessList_Closed);
            // 
            // toolStripMenuItemRemoveWindow
            // 
            this.toolStripMenuItemRemoveWindow.Name = "toolStripMenuItemRemoveWindow";
            this.toolStripMenuItemRemoveWindow.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItemRemoveWindow.Text = "Remove window";
            this.toolStripMenuItemRemoveWindow.Click += new System.EventHandler(this.toolStripMenuItemRemoveWindow_Click);
            // 
            // changeWindowPositionToolStripMenuItem
            // 
            this.changeWindowPositionToolStripMenuItem.Name = "changeWindowPositionToolStripMenuItem";
            this.changeWindowPositionToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.changeWindowPositionToolStripMenuItem.Text = "Change window position";
            this.changeWindowPositionToolStripMenuItem.Click += new System.EventHandler(this.changeWindowPositionToolStripMenuItem_Click);
            // 
            // changeWindowSizeToolStripMenuItem
            // 
            this.changeWindowSizeToolStripMenuItem.Name = "changeWindowSizeToolStripMenuItem";
            this.changeWindowSizeToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.changeWindowSizeToolStripMenuItem.Text = "Change window size";
            this.changeWindowSizeToolStripMenuItem.Click += new System.EventHandler(this.changeWindowSizeToolStripMenuItem_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(644, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 474);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.processList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "MainUI";
            this.Text = "Reminder - Window Editor";
            ((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
            this.contextMenuStripProcessList.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView processList;
        private System.Windows.Forms.DataGridViewTextBoxColumn processes;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainWindowTitle;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProcessList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveWindow;
        private System.Windows.Forms.ToolStripMenuItem changeWindowPositionToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeWindowSizeToolStripMenuItem;
    }
}