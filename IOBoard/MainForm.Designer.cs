namespace IOBoard
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
            this.BUT_ReadOSD = new System.Windows.Forms.Button();
            this.CMB_ComPort = new System.Windows.Forms.ComboBox();
            this.BUT_WriteOSD = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIOBoardFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadIOBoardFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.updateFirmwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBoardSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattern8 = new IOBoard.Pattern();
            this.pattern7 = new IOBoard.Pattern();
            this.pattern6 = new IOBoard.Pattern();
            this.pattern5 = new IOBoard.Pattern();
            this.pattern4 = new IOBoard.Pattern();
            this.pattern3 = new IOBoard.Pattern();
            this.pattern2 = new IOBoard.Pattern();
            this.pattern1 = new IOBoard.Pattern();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUT_ReadOSD
            // 
            this.BUT_ReadOSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_ReadOSD.Location = new System.Drawing.Point(573, 460);
            this.BUT_ReadOSD.Name = "BUT_ReadOSD";
            this.BUT_ReadOSD.Size = new System.Drawing.Size(116, 23);
            this.BUT_ReadOSD.TabIndex = 9;
            this.BUT_ReadOSD.Text = "Read From IOBoard";
            this.BUT_ReadOSD.UseVisualStyleBackColor = true;
            this.BUT_ReadOSD.Click += new System.EventHandler(this.BUT_ReadOSD_Click);
            // 
            // CMB_ComPort
            // 
            this.CMB_ComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_ComPort.FormattingEnabled = true;
            this.CMB_ComPort.Location = new System.Drawing.Point(469, 462);
            this.CMB_ComPort.Name = "CMB_ComPort";
            this.CMB_ComPort.Size = new System.Drawing.Size(98, 21);
            this.CMB_ComPort.TabIndex = 8;
            this.CMB_ComPort.Click += new System.EventHandler(this.CMB_ComPort_Click);
            // 
            // BUT_WriteOSD
            // 
            this.BUT_WriteOSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_WriteOSD.Location = new System.Drawing.Point(695, 460);
            this.BUT_WriteOSD.Name = "BUT_WriteOSD";
            this.BUT_WriteOSD.Size = new System.Drawing.Size(116, 23);
            this.BUT_WriteOSD.TabIndex = 7;
            this.BUT_WriteOSD.Text = "Save to IOBoard";
            this.BUT_WriteOSD.UseVisualStyleBackColor = true;
            this.BUT_WriteOSD.Click += new System.EventHandler(this.BUT_WriteOSD_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(823, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveIOBoardFileToolStripMenuItem,
            this.loadIOBoardFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.updateFirmwareToolStripMenuItem,
            this.resetBoardSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveIOBoardFileToolStripMenuItem
            // 
            this.saveIOBoardFileToolStripMenuItem.Name = "saveIOBoardFileToolStripMenuItem";
            this.saveIOBoardFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveIOBoardFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.saveIOBoardFileToolStripMenuItem.Text = "Save IOBoard File";
            this.saveIOBoardFileToolStripMenuItem.Click += new System.EventHandler(this.saveIOBoardFileToolStripMenuItem_Click);
            // 
            // loadIOBoardFileToolStripMenuItem
            // 
            this.loadIOBoardFileToolStripMenuItem.Name = "loadIOBoardFileToolStripMenuItem";
            this.loadIOBoardFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadIOBoardFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.loadIOBoardFileToolStripMenuItem.Text = "Load IOBoard File";
            this.loadIOBoardFileToolStripMenuItem.Click += new System.EventHandler(this.loadIOBoardFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // updateFirmwareToolStripMenuItem
            // 
            this.updateFirmwareToolStripMenuItem.Name = "updateFirmwareToolStripMenuItem";
            this.updateFirmwareToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.updateFirmwareToolStripMenuItem.Text = "Update Firmware";
            this.updateFirmwareToolStripMenuItem.Click += new System.EventHandler(this.updateFirmwareToolStripMenuItem_Click);
            // 
            // resetBoardSettingsToolStripMenuItem
            // 
            this.resetBoardSettingsToolStripMenuItem.Name = "resetBoardSettingsToolStripMenuItem";
            this.resetBoardSettingsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.resetBoardSettingsToolStripMenuItem.Text = "Reset Board Settings";
            this.resetBoardSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetBoardSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pattern8
            // 
            this.pattern8.FlightMode = ((ushort)(0));
            this.pattern8.Location = new System.Drawing.Point(0, 406);
            this.pattern8.Name = "pattern8";
            this.pattern8.Size = new System.Drawing.Size(815, 54);
            this.pattern8.TabIndex = 18;
            this.pattern8.Value = ((ushort)(0));
            // 
            // pattern7
            // 
            this.pattern7.FlightMode = ((ushort)(0));
            this.pattern7.Location = new System.Drawing.Point(0, 352);
            this.pattern7.Name = "pattern7";
            this.pattern7.Size = new System.Drawing.Size(815, 54);
            this.pattern7.TabIndex = 17;
            this.pattern7.Value = ((ushort)(0));
            // 
            // pattern6
            // 
            this.pattern6.FlightMode = ((ushort)(0));
            this.pattern6.Location = new System.Drawing.Point(0, 298);
            this.pattern6.Name = "pattern6";
            this.pattern6.Size = new System.Drawing.Size(815, 54);
            this.pattern6.TabIndex = 16;
            this.pattern6.Value = ((ushort)(0));
            // 
            // pattern5
            // 
            this.pattern5.FlightMode = ((ushort)(0));
            this.pattern5.Location = new System.Drawing.Point(0, 244);
            this.pattern5.Name = "pattern5";
            this.pattern5.Size = new System.Drawing.Size(815, 54);
            this.pattern5.TabIndex = 15;
            this.pattern5.Value = ((ushort)(0));
            // 
            // pattern4
            // 
            this.pattern4.FlightMode = ((ushort)(0));
            this.pattern4.Location = new System.Drawing.Point(0, 190);
            this.pattern4.Name = "pattern4";
            this.pattern4.Size = new System.Drawing.Size(815, 54);
            this.pattern4.TabIndex = 14;
            this.pattern4.Value = ((ushort)(0));
            // 
            // pattern3
            // 
            this.pattern3.FlightMode = ((ushort)(0));
            this.pattern3.Location = new System.Drawing.Point(0, 136);
            this.pattern3.Name = "pattern3";
            this.pattern3.Size = new System.Drawing.Size(815, 54);
            this.pattern3.TabIndex = 13;
            this.pattern3.Value = ((ushort)(0));
            // 
            // pattern2
            // 
            this.pattern2.FlightMode = ((ushort)(0));
            this.pattern2.Location = new System.Drawing.Point(0, 82);
            this.pattern2.Name = "pattern2";
            this.pattern2.Size = new System.Drawing.Size(815, 54);
            this.pattern2.TabIndex = 12;
            this.pattern2.Value = ((ushort)(0));
            // 
            // pattern1
            // 
            this.pattern1.FlightMode = ((ushort)(0));
            this.pattern1.Location = new System.Drawing.Point(0, 28);
            this.pattern1.Name = "pattern1";
            this.pattern1.Size = new System.Drawing.Size(815, 54);
            this.pattern1.TabIndex = 11;
            this.pattern1.Value = ((ushort)(0));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 508);
            this.Controls.Add(this.pattern8);
            this.Controls.Add(this.pattern7);
            this.Controls.Add(this.pattern6);
            this.Controls.Add(this.pattern5);
            this.Controls.Add(this.pattern4);
            this.Controls.Add(this.pattern3);
            this.Controls.Add(this.pattern2);
            this.Controls.Add(this.pattern1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BUT_ReadOSD);
            this.Controls.Add(this.CMB_ComPort);
            this.Controls.Add(this.BUT_WriteOSD);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(839, 521);
            this.Name = "MainForm";
            this.Text = "IOBoard";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUT_ReadOSD;
        private System.Windows.Forms.ComboBox CMB_ComPort;
        private System.Windows.Forms.Button BUT_WriteOSD;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Pattern pattern1;
        private Pattern pattern2;
        private Pattern pattern3;
        private Pattern pattern4;
        private Pattern pattern5;
        private Pattern pattern6;
        private Pattern pattern7;
        private Pattern pattern8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveIOBoardFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadIOBoardFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem updateFirmwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetBoardSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

