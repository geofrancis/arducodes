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
            this.BUT_ReadIOB = new System.Windows.Forms.Button();
            this.CMB_ComPort = new System.Windows.Forms.ComboBox();
            this.BUT_WriteIOB = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LBL_Version = new System.Windows.Forms.Label();
            this.pattern8 = new IOBoard.Pattern();
            this.pattern7 = new IOBoard.Pattern();
            this.pattern6 = new IOBoard.Pattern();
            this.pattern5 = new IOBoard.Pattern();
            this.pattern4 = new IOBoard.Pattern();
            this.pattern3 = new IOBoard.Pattern();
            this.pattern2 = new IOBoard.Pattern();
            this.pattern1 = new IOBoard.Pattern();
            this.label15 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BUT_ReadIOB
            // 
            this.BUT_ReadIOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_ReadIOB.Location = new System.Drawing.Point(717, 489);
            this.BUT_ReadIOB.Name = "BUT_ReadIOB";
            this.BUT_ReadIOB.Size = new System.Drawing.Size(116, 23);
            this.BUT_ReadIOB.TabIndex = 9;
            this.BUT_ReadIOB.Text = "Read From IOBoard";
            this.BUT_ReadIOB.UseVisualStyleBackColor = true;
            this.BUT_ReadIOB.Click += new System.EventHandler(this.BUT_ReadIOB_Click);
            // 
            // CMB_ComPort
            // 
            this.CMB_ComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_ComPort.FormattingEnabled = true;
            this.CMB_ComPort.Location = new System.Drawing.Point(610, 489);
            this.CMB_ComPort.Name = "CMB_ComPort";
            this.CMB_ComPort.Size = new System.Drawing.Size(98, 21);
            this.CMB_ComPort.TabIndex = 8;
            this.CMB_ComPort.Click += new System.EventHandler(this.CMB_ComPort_Click);
            // 
            // BUT_WriteIOB
            // 
            this.BUT_WriteIOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_WriteIOB.Location = new System.Drawing.Point(839, 489);
            this.BUT_WriteIOB.Name = "BUT_WriteIOB";
            this.BUT_WriteIOB.Size = new System.Drawing.Size(116, 23);
            this.BUT_WriteIOB.TabIndex = 7;
            this.BUT_WriteIOB.Text = "Save to IOBoard";
            this.BUT_WriteIOB.UseVisualStyleBackColor = true;
            this.BUT_WriteIOB.Click += new System.EventHandler(this.BUT_WriteIOB_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(967, 22);
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveIOBoardFileToolStripMenuItem
            // 
            this.saveIOBoardFileToolStripMenuItem.Name = "saveIOBoardFileToolStripMenuItem";
            this.saveIOBoardFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveIOBoardFileToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveIOBoardFileToolStripMenuItem.Text = "Save IOBoard File";
            this.saveIOBoardFileToolStripMenuItem.Click += new System.EventHandler(this.saveIOBoardFileToolStripMenuItem_Click);
            // 
            // loadIOBoardFileToolStripMenuItem
            // 
            this.loadIOBoardFileToolStripMenuItem.Name = "loadIOBoardFileToolStripMenuItem";
            this.loadIOBoardFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadIOBoardFileToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.loadIOBoardFileToolStripMenuItem.Text = "Load IOBoard File";
            this.loadIOBoardFileToolStripMenuItem.Click += new System.EventHandler(this.loadIOBoardFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // updateFirmwareToolStripMenuItem
            // 
            this.updateFirmwareToolStripMenuItem.Name = "updateFirmwareToolStripMenuItem";
            this.updateFirmwareToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateFirmwareToolStripMenuItem.Text = "Update Firmware";
            this.updateFirmwareToolStripMenuItem.Click += new System.EventHandler(this.updateFirmwareToolStripMenuItem_Click);
            // 
            // resetBoardSettingsToolStripMenuItem
            // 
            this.resetBoardSettingsToolStripMenuItem.Name = "resetBoardSettingsToolStripMenuItem";
            this.resetBoardSettingsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.resetBoardSettingsToolStripMenuItem.Text = "Reset Board Settings";
            this.resetBoardSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetBoardSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(578, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "www.jdrones.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pattern positions, check box to make output high";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Flight Mode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(883, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Pattern Demo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pattern 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Pattern 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Pattern 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Pattern 4:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Pattern 5:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Pattern 6:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Pattern 7:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Pattern 8:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(137, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Version:";
            // 
            // LBL_Version
            // 
            this.LBL_Version.AutoSize = true;
            this.LBL_Version.Location = new System.Drawing.Point(181, 500);
            this.LBL_Version.Name = "LBL_Version";
            this.LBL_Version.Size = new System.Drawing.Size(40, 13);
            this.LBL_Version.TabIndex = 34;
            this.LBL_Version.Text = "1.0.0.7";
            // 
            // pattern8
            // 
            this.pattern8.BackColor = System.Drawing.SystemColors.Control;
            this.pattern8.FlightMode = ((ushort)(0));
            this.pattern8.Location = new System.Drawing.Point(54, 421);
            this.pattern8.Name = "pattern8";
            this.pattern8.Size = new System.Drawing.Size(901, 54);
            this.pattern8.TabIndex = 18;
            this.pattern8.Value = ((ushort)(0));
            this.pattern8.Load += new System.EventHandler(this.pattern8_Load);
            // 
            // pattern7
            // 
            this.pattern7.BackColor = System.Drawing.SystemColors.Control;
            this.pattern7.FlightMode = ((ushort)(0));
            this.pattern7.Location = new System.Drawing.Point(54, 367);
            this.pattern7.Name = "pattern7";
            this.pattern7.Size = new System.Drawing.Size(901, 54);
            this.pattern7.TabIndex = 17;
            this.pattern7.Value = ((ushort)(0));
            this.pattern7.Load += new System.EventHandler(this.pattern7_Load);
            // 
            // pattern6
            // 
            this.pattern6.BackColor = System.Drawing.SystemColors.Control;
            this.pattern6.FlightMode = ((ushort)(0));
            this.pattern6.Location = new System.Drawing.Point(54, 313);
            this.pattern6.Name = "pattern6";
            this.pattern6.Size = new System.Drawing.Size(901, 54);
            this.pattern6.TabIndex = 16;
            this.pattern6.Value = ((ushort)(0));
            this.pattern6.Load += new System.EventHandler(this.pattern6_Load);
            // 
            // pattern5
            // 
            this.pattern5.BackColor = System.Drawing.SystemColors.Control;
            this.pattern5.FlightMode = ((ushort)(0));
            this.pattern5.Location = new System.Drawing.Point(54, 259);
            this.pattern5.Name = "pattern5";
            this.pattern5.Size = new System.Drawing.Size(901, 54);
            this.pattern5.TabIndex = 15;
            this.pattern5.Value = ((ushort)(0));
            this.pattern5.Load += new System.EventHandler(this.pattern5_Load);
            // 
            // pattern4
            // 
            this.pattern4.BackColor = System.Drawing.SystemColors.Control;
            this.pattern4.FlightMode = ((ushort)(0));
            this.pattern4.Location = new System.Drawing.Point(54, 205);
            this.pattern4.Name = "pattern4";
            this.pattern4.Size = new System.Drawing.Size(901, 54);
            this.pattern4.TabIndex = 14;
            this.pattern4.Value = ((ushort)(0));
            this.pattern4.Load += new System.EventHandler(this.pattern4_Load);
            // 
            // pattern3
            // 
            this.pattern3.BackColor = System.Drawing.SystemColors.Control;
            this.pattern3.FlightMode = ((ushort)(0));
            this.pattern3.Location = new System.Drawing.Point(54, 151);
            this.pattern3.Name = "pattern3";
            this.pattern3.Size = new System.Drawing.Size(901, 54);
            this.pattern3.TabIndex = 13;
            this.pattern3.Value = ((ushort)(0));
            this.pattern3.Load += new System.EventHandler(this.pattern3_Load);
            // 
            // pattern2
            // 
            this.pattern2.BackColor = System.Drawing.SystemColors.Control;
            this.pattern2.FlightMode = ((ushort)(0));
            this.pattern2.Location = new System.Drawing.Point(54, 97);
            this.pattern2.Name = "pattern2";
            this.pattern2.Size = new System.Drawing.Size(901, 54);
            this.pattern2.TabIndex = 12;
            this.pattern2.Value = ((ushort)(0));
            this.pattern2.Load += new System.EventHandler(this.pattern2_Load);
            // 
            // pattern1
            // 
            this.pattern1.BackColor = System.Drawing.SystemColors.Control;
            this.pattern1.FlightMode = ((ushort)(0));
            this.pattern1.Location = new System.Drawing.Point(54, 43);
            this.pattern1.Name = "pattern1";
            this.pattern1.Size = new System.Drawing.Size(901, 54);
            this.pattern1.TabIndex = 11;
            this.pattern1.Value = ((ushort)(0));
            this.pattern1.Load += new System.EventHandler(this.pattern1_Load);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "(position changes every 50ms)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 542);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LBL_Version);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.BUT_ReadIOB);
            this.Controls.Add(this.CMB_ComPort);
            this.Controls.Add(this.BUT_WriteIOB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(839, 521);
            this.Name = "MainForm";
            this.Text = "jD-IOBoard Configurator (c)2012 by M.Oborne, J.Hirvinen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUT_ReadIOB;
        private System.Windows.Forms.ComboBox CMB_ComPort;
        private System.Windows.Forms.Button BUT_WriteIOB;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LBL_Version;
        private System.Windows.Forms.Label label15;
    }
}

