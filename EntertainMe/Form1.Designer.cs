namespace EntertainMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonDonate = new System.Windows.Forms.Button();
            this.buttonFullScreen = new System.Windows.Forms.Button();
            this.buttonLicensing = new System.Windows.Forms.Button();
            this.timingGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMaxTimeSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinTimeSec = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxTimeMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinTimeMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFileLength = new System.Windows.Forms.CheckBox();
            this.checkBoxAudioFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxVideoFiles = new System.Windows.Forms.CheckBox();
            this.checkBoxFullScreen = new System.Windows.Forms.CheckBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.timingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTimeSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTimeSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.SandyBrown;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axWindowsMediaPlayer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonDonate);
            this.splitContainer1.Panel2.Controls.Add(this.buttonFullScreen);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLicensing);
            this.splitContainer1.Panel2.Controls.Add(this.timingGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxAudioFiles);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxVideoFiles);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxFullScreen);
            this.splitContainer1.Panel2.Controls.Add(this.labelFileName);
            this.splitContainer1.Panel2.Controls.Add(this.buttonPlay);
            this.splitContainer1.Panel2.Controls.Add(this.buttonBrowse);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(488, 690);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(488, 422);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // buttonDonate
            // 
            this.buttonDonate.Location = new System.Drawing.Point(365, 192);
            this.buttonDonate.Name = "buttonDonate";
            this.buttonDonate.Size = new System.Drawing.Size(75, 23);
            this.buttonDonate.TabIndex = 15;
            this.buttonDonate.Text = "Donate";
            this.buttonDonate.UseVisualStyleBackColor = true;
            this.buttonDonate.Click += new System.EventHandler(this.buttonDonate_Click);
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonFullScreen.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFullScreen.ForeColor = System.Drawing.Color.Maroon;
            this.buttonFullScreen.Location = new System.Drawing.Point(0, 231);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(488, 33);
            this.buttonFullScreen.TabIndex = 14;
            this.buttonFullScreen.Text = "Full Screen";
            this.buttonFullScreen.UseVisualStyleBackColor = true;
            this.buttonFullScreen.Visible = false;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            // 
            // buttonLicensing
            // 
            this.buttonLicensing.Location = new System.Drawing.Point(365, 166);
            this.buttonLicensing.Name = "buttonLicensing";
            this.buttonLicensing.Size = new System.Drawing.Size(75, 23);
            this.buttonLicensing.TabIndex = 13;
            this.buttonLicensing.Text = "Licensing";
            this.buttonLicensing.UseVisualStyleBackColor = true;
            this.buttonLicensing.Click += new System.EventHandler(this.buttonLicensing_Click);
            // 
            // timingGroupBox
            // 
            this.timingGroupBox.Controls.Add(this.label8);
            this.timingGroupBox.Controls.Add(this.label7);
            this.timingGroupBox.Controls.Add(this.label6);
            this.timingGroupBox.Controls.Add(this.label5);
            this.timingGroupBox.Controls.Add(this.numericUpDownMaxTimeSec);
            this.timingGroupBox.Controls.Add(this.numericUpDownMinTimeSec);
            this.timingGroupBox.Controls.Add(this.label4);
            this.timingGroupBox.Controls.Add(this.label3);
            this.timingGroupBox.Controls.Add(this.numericUpDownMaxTimeMin);
            this.timingGroupBox.Controls.Add(this.numericUpDownMinTimeMin);
            this.timingGroupBox.Controls.Add(this.checkBoxFileLength);
            this.timingGroupBox.Location = new System.Drawing.Point(206, 10);
            this.timingGroupBox.Name = "timingGroupBox";
            this.timingGroupBox.Size = new System.Drawing.Size(270, 140);
            this.timingGroupBox.TabIndex = 12;
            this.timingGroupBox.TabStop = false;
            this.timingGroupBox.Text = "Time Specifications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Min";
            // 
            // numericUpDownMaxTimeSec
            // 
            this.numericUpDownMaxTimeSec.Location = new System.Drawing.Point(134, 108);
            this.numericUpDownMaxTimeSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMaxTimeSec.Name = "numericUpDownMaxTimeSec";
            this.numericUpDownMaxTimeSec.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMaxTimeSec.TabIndex = 7;
            // 
            // numericUpDownMinTimeSec
            // 
            this.numericUpDownMinTimeSec.Location = new System.Drawing.Point(134, 59);
            this.numericUpDownMinTimeSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinTimeSec.Name = "numericUpDownMinTimeSec";
            this.numericUpDownMinTimeSec.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMinTimeSec.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minimum Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum Time";
            // 
            // numericUpDownMaxTimeMin
            // 
            this.numericUpDownMaxTimeMin.Location = new System.Drawing.Point(18, 108);
            this.numericUpDownMaxTimeMin.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownMaxTimeMin.Name = "numericUpDownMaxTimeMin";
            this.numericUpDownMaxTimeMin.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMaxTimeMin.TabIndex = 2;
            // 
            // numericUpDownMinTimeMin
            // 
            this.numericUpDownMinTimeMin.Location = new System.Drawing.Point(18, 59);
            this.numericUpDownMinTimeMin.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownMinTimeMin.Name = "numericUpDownMinTimeMin";
            this.numericUpDownMinTimeMin.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownMinTimeMin.TabIndex = 1;
            // 
            // checkBoxFileLength
            // 
            this.checkBoxFileLength.AutoSize = true;
            this.checkBoxFileLength.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFileLength.Name = "checkBoxFileLength";
            this.checkBoxFileLength.Size = new System.Drawing.Size(118, 17);
            this.checkBoxFileLength.TabIndex = 0;
            this.checkBoxFileLength.Text = "Filter By File Length";
            this.checkBoxFileLength.UseVisualStyleBackColor = true;
            // 
            // checkBoxAudioFiles
            // 
            this.checkBoxAudioFiles.AutoSize = true;
            this.checkBoxAudioFiles.Checked = true;
            this.checkBoxAudioFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAudioFiles.Location = new System.Drawing.Point(13, 86);
            this.checkBoxAudioFiles.Name = "checkBoxAudioFiles";
            this.checkBoxAudioFiles.Size = new System.Drawing.Size(115, 17);
            this.checkBoxAudioFiles.TabIndex = 11;
            this.checkBoxAudioFiles.Text = "Include Audio Files";
            this.checkBoxAudioFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxVideoFiles
            // 
            this.checkBoxVideoFiles.AutoSize = true;
            this.checkBoxVideoFiles.Checked = true;
            this.checkBoxVideoFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVideoFiles.Location = new System.Drawing.Point(15, 62);
            this.checkBoxVideoFiles.Name = "checkBoxVideoFiles";
            this.checkBoxVideoFiles.Size = new System.Drawing.Size(112, 17);
            this.checkBoxVideoFiles.TabIndex = 10;
            this.checkBoxVideoFiles.Text = "Include Video files";
            this.checkBoxVideoFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullScreen
            // 
            this.checkBoxFullScreen.AutoSize = true;
            this.checkBoxFullScreen.Checked = true;
            this.checkBoxFullScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFullScreen.Location = new System.Drawing.Point(15, 38);
            this.checkBoxFullScreen.Name = "checkBoxFullScreen";
            this.checkBoxFullScreen.Size = new System.Drawing.Size(102, 17);
            this.checkBoxFullScreen.TabIndex = 9;
            this.checkBoxFullScreen.Text = "Play Full Screen";
            this.checkBoxFullScreen.UseVisualStyleBackColor = true;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.BackColor = System.Drawing.Color.SeaShell;
            this.labelFileName.Location = new System.Drawing.Point(93, 118);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(107, 13);
            this.labelFileName.TabIndex = 8;
            this.labelFileName.Text = "No directory selected";
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPlay.Location = new System.Drawing.Point(185, 192);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(81, 30);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 113);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse . . .";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of selections";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 166);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 690);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Media Vamp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.timingGroupBox.ResumeLayout(false);
            this.timingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTimeSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTimeSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBoxAudioFiles;
        private System.Windows.Forms.CheckBox checkBoxVideoFiles;
        private System.Windows.Forms.CheckBox checkBoxFullScreen;
        private System.Windows.Forms.GroupBox timingGroupBox;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxTimeMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMinTimeMin;
        private System.Windows.Forms.CheckBox checkBoxFileLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxTimeSec;
        private System.Windows.Forms.NumericUpDown numericUpDownMinTimeSec;
        private System.Windows.Forms.Button buttonLicensing;
        private System.Windows.Forms.Button buttonFullScreen;
        private System.Windows.Forms.Button buttonDonate;
    }
}

