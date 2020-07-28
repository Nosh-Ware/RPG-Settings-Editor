namespace RPG.ini_Editor
{
    partial class Form1
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
            this.FolderDia = new System.Windows.Forms.FolderBrowserDialog();
            this.groupProjectLocation = new System.Windows.Forms.GroupBox();
            this.butOpenDia = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.txtFolderLocation = new System.Windows.Forms.TextBox();
            this.tabEditorSettings = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastEditorVer = new System.Windows.Forms.TextBox();
            this.txtKnownVersion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabGameSettings = new System.Windows.Forms.TabPage();
            this.dropEncoding = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFullPackageFlag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.tabSet = new System.Windows.Forms.TabControl();
            this.groupProjectLocation.SuspendLayout();
            this.tabEditorSettings.SuspendLayout();
            this.tabGameSettings.SuspendLayout();
            this.tabSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderDia
            // 
            this.FolderDia.Description = "Select Project Folder";
            this.FolderDia.ShowNewFolderButton = false;
            // 
            // groupProjectLocation
            // 
            this.groupProjectLocation.Controls.Add(this.butOpenDia);
            this.groupProjectLocation.Controls.Add(this.butSave);
            this.groupProjectLocation.Controls.Add(this.txtFolderLocation);
            this.groupProjectLocation.Location = new System.Drawing.Point(12, 12);
            this.groupProjectLocation.Name = "groupProjectLocation";
            this.groupProjectLocation.Size = new System.Drawing.Size(439, 45);
            this.groupProjectLocation.TabIndex = 3;
            this.groupProjectLocation.TabStop = false;
            this.groupProjectLocation.Text = "Project Location";
            // 
            // butOpenDia
            // 
            this.butOpenDia.Location = new System.Drawing.Point(345, 17);
            this.butOpenDia.Name = "butOpenDia";
            this.butOpenDia.Size = new System.Drawing.Size(25, 23);
            this.butOpenDia.TabIndex = 6;
            this.butOpenDia.Text = "...";
            this.butOpenDia.UseVisualStyleBackColor = true;
            this.butOpenDia.Click += new System.EventHandler(this.OpenDia);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(376, 17);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(57, 23);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.SaveFile);
            // 
            // txtFolderLocation
            // 
            this.txtFolderLocation.Location = new System.Drawing.Point(9, 18);
            this.txtFolderLocation.Name = "txtFolderLocation";
            this.txtFolderLocation.Size = new System.Drawing.Size(330, 20);
            this.txtFolderLocation.TabIndex = 4;
            this.txtFolderLocation.TextChanged += new System.EventHandler(this.OpenFile);
            this.txtFolderLocation.Leave += new System.EventHandler(this.OpenFile);
            // 
            // tabEditorSettings
            // 
            this.tabEditorSettings.Controls.Add(this.label6);
            this.tabEditorSettings.Controls.Add(this.label5);
            this.tabEditorSettings.Controls.Add(this.txtLastEditorVer);
            this.tabEditorSettings.Controls.Add(this.txtKnownVersion);
            this.tabEditorSettings.Controls.Add(this.label4);
            this.tabEditorSettings.Location = new System.Drawing.Point(4, 22);
            this.tabEditorSettings.Name = "tabEditorSettings";
            this.tabEditorSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditorSettings.Size = new System.Drawing.Size(431, 89);
            this.tabEditorSettings.TabIndex = 1;
            this.tabEditorSettings.Text = "Editor Settings";
            this.tabEditorSettings.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(81, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "CAUTION: Don\'t edit unless you know what your doing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Editor Used";
            // 
            // txtLastEditorVer
            // 
            this.txtLastEditorVer.Location = new System.Drawing.Point(128, 63);
            this.txtLastEditorVer.Name = "txtLastEditorVer";
            this.txtLastEditorVer.Size = new System.Drawing.Size(297, 20);
            this.txtLastEditorVer.TabIndex = 4;
            // 
            // txtKnownVersion
            // 
            this.txtKnownVersion.Location = new System.Drawing.Point(128, 33);
            this.txtKnownVersion.Name = "txtKnownVersion";
            this.txtKnownVersion.Size = new System.Drawing.Size(297, 20);
            this.txtKnownVersion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Internal Known Version";
            // 
            // tabGameSettings
            // 
            this.tabGameSettings.Controls.Add(this.dropEncoding);
            this.tabGameSettings.Controls.Add(this.label3);
            this.tabGameSettings.Controls.Add(this.label2);
            this.tabGameSettings.Controls.Add(this.chkFullPackageFlag);
            this.tabGameSettings.Controls.Add(this.label1);
            this.tabGameSettings.Controls.Add(this.txtGameTitle);
            this.tabGameSettings.Location = new System.Drawing.Point(4, 22);
            this.tabGameSettings.Name = "tabGameSettings";
            this.tabGameSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabGameSettings.Size = new System.Drawing.Size(431, 89);
            this.tabGameSettings.TabIndex = 0;
            this.tabGameSettings.Text = "Game Settings";
            this.tabGameSettings.UseVisualStyleBackColor = true;
            // 
            // dropEncoding
            // 
            this.dropEncoding.FormattingEnabled = true;
            this.dropEncoding.Items.AddRange(new object[] {
            "Western European (English/West Euopean Languages)",
            "Windows-1251 (Cyrillic Lanuages)",
            "Windows-1250 (Central Euopean Languages)",
            "Shift-JIS (Japanese: Hiragana, Katakana, Kanji)",
            "Big5 (Traditional Chinese)",
            "None"});
            this.dropEncoding.Location = new System.Drawing.Point(173, 61);
            this.dropEncoding.Name = "dropEncoding";
            this.dropEncoding.Size = new System.Drawing.Size(250, 21);
            this.dropEncoding.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encoding (EasyRPG Only)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Package (Is it RTP dependent?)";
            // 
            // chkFullPackageFlag
            // 
            this.chkFullPackageFlag.Location = new System.Drawing.Point(290, 37);
            this.chkFullPackageFlag.Name = "chkFullPackageFlag";
            this.chkFullPackageFlag.Size = new System.Drawing.Size(16, 13);
            this.chkFullPackageFlag.TabIndex = 2;
            this.chkFullPackageFlag.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Name";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(173, 6);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(250, 20);
            this.txtGameTitle.TabIndex = 0;
            // 
            // tabSet
            // 
            this.tabSet.Controls.Add(this.tabGameSettings);
            this.tabSet.Controls.Add(this.tabEditorSettings);
            this.tabSet.Location = new System.Drawing.Point(12, 63);
            this.tabSet.Name = "tabSet";
            this.tabSet.SelectedIndex = 0;
            this.tabSet.Size = new System.Drawing.Size(439, 115);
            this.tabSet.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 190);
            this.Controls.Add(this.groupProjectLocation);
            this.Controls.Add(this.tabSet);
            this.Name = "Form1";
            this.Text = "ERPG Settings Editor";
            this.groupProjectLocation.ResumeLayout(false);
            this.groupProjectLocation.PerformLayout();
            this.tabEditorSettings.ResumeLayout(false);
            this.tabEditorSettings.PerformLayout();
            this.tabGameSettings.ResumeLayout(false);
            this.tabGameSettings.PerformLayout();
            this.tabSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupProjectLocation;
        private System.Windows.Forms.TextBox txtFolderLocation;
        private System.Windows.Forms.Button butOpenDia;
        private System.Windows.Forms.Button butSave;
        public System.Windows.Forms.FolderBrowserDialog FolderDia;
        private System.Windows.Forms.TabPage tabEditorSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastEditorVer;
        private System.Windows.Forms.TextBox txtKnownVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabGameSettings;
        private System.Windows.Forms.ComboBox dropEncoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFullPackageFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.TabControl tabSet;
    }
}

