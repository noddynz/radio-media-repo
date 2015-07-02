namespace MediaProcessor
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
            this.btnScanMedia = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.lblSelectedFolder = new System.Windows.Forms.Label();
            this.btnScanFile = new System.Windows.Forms.Button();
            this.lstBoxEpisode = new System.Windows.Forms.ListBox();
            this.btnScanLatestVersion = new System.Windows.Forms.Button();
            this.btnSelectStub = new System.Windows.Forms.Button();
            this.lblStub = new System.Windows.Forms.Label();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.btnMergeStart = new System.Windows.Forms.Button();
            this.btnMergeEnd = new System.Windows.Forms.Button();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.btnClearEpisodeList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScanMedia
            // 
            this.btnScanMedia.Location = new System.Drawing.Point(12, 32);
            this.btnScanMedia.Name = "btnScanMedia";
            this.btnScanMedia.Size = new System.Drawing.Size(108, 23);
            this.btnScanMedia.TabIndex = 0;
            this.btnScanMedia.Text = "Select Folder";
            this.btnScanMedia.UseVisualStyleBackColor = true;
            this.btnScanMedia.Click += new System.EventHandler(this.btnScanMedia_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(126, 32);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(294, 238);
            this.lstBox.TabIndex = 1;
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.AutoSize = true;
            this.lblSelectedFolder.Location = new System.Drawing.Point(13, 13);
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            this.lblSelectedFolder.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedFolder.TabIndex = 2;
            // 
            // btnScanFile
            // 
            this.btnScanFile.Location = new System.Drawing.Point(13, 62);
            this.btnScanFile.Name = "btnScanFile";
            this.btnScanFile.Size = new System.Drawing.Size(107, 23);
            this.btnScanFile.TabIndex = 3;
            this.btnScanFile.Text = "Scan File ID3v1.x";
            this.btnScanFile.UseVisualStyleBackColor = true;
            this.btnScanFile.Click += new System.EventHandler(this.btnScanFile_Click);
            // 
            // lstBoxEpisode
            // 
            this.lstBoxEpisode.FormattingEnabled = true;
            this.lstBoxEpisode.Location = new System.Drawing.Point(426, 32);
            this.lstBoxEpisode.Name = "lstBoxEpisode";
            this.lstBoxEpisode.Size = new System.Drawing.Size(294, 238);
            this.lstBoxEpisode.TabIndex = 4;
            // 
            // btnScanLatestVersion
            // 
            this.btnScanLatestVersion.Location = new System.Drawing.Point(13, 92);
            this.btnScanLatestVersion.Name = "btnScanLatestVersion";
            this.btnScanLatestVersion.Size = new System.Drawing.Size(107, 23);
            this.btnScanLatestVersion.TabIndex = 5;
            this.btnScanLatestVersion.Text = "Scan File ID3v2.3";
            this.btnScanLatestVersion.UseVisualStyleBackColor = true;
            this.btnScanLatestVersion.Click += new System.EventHandler(this.btnScanLatestVersion_Click);
            // 
            // btnSelectStub
            // 
            this.btnSelectStub.Location = new System.Drawing.Point(19, 369);
            this.btnSelectStub.Name = "btnSelectStub";
            this.btnSelectStub.Size = new System.Drawing.Size(104, 23);
            this.btnSelectStub.TabIndex = 6;
            this.btnSelectStub.Text = "Select Snippit";
            this.btnSelectStub.UseVisualStyleBackColor = true;
            this.btnSelectStub.Click += new System.EventHandler(this.btnSelectStub_Click);
            // 
            // lblStub
            // 
            this.lblStub.AutoSize = true;
            this.lblStub.Location = new System.Drawing.Point(16, 345);
            this.lblStub.Name = "lblStub";
            this.lblStub.Size = new System.Drawing.Size(0, 13);
            this.lblStub.TabIndex = 7;
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(19, 319);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(104, 23);
            this.btnOriginal.TabIndex = 8;
            this.btnOriginal.Text = "Select Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(16, 405);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(0, 13);
            this.lblOriginal.TabIndex = 9;
            // 
            // btnMergeStart
            // 
            this.btnMergeStart.Location = new System.Drawing.Point(19, 419);
            this.btnMergeStart.Name = "btnMergeStart";
            this.btnMergeStart.Size = new System.Drawing.Size(104, 23);
            this.btnMergeStart.TabIndex = 10;
            this.btnMergeStart.Text = "Add Cover File";
            this.btnMergeStart.UseVisualStyleBackColor = true;
            this.btnMergeStart.Click += new System.EventHandler(this.btnMergeStart_Click);
            // 
            // btnMergeEnd
            // 
            this.btnMergeEnd.Location = new System.Drawing.Point(19, 472);
            this.btnMergeEnd.Name = "btnMergeEnd";
            this.btnMergeEnd.Size = new System.Drawing.Size(104, 23);
            this.btnMergeEnd.TabIndex = 11;
            this.btnMergeEnd.Text = "Add Tail File";
            this.btnMergeEnd.UseVisualStyleBackColor = true;
            this.btnMergeEnd.Click += new System.EventHandler(this.btnMergeEnd_Click);
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Location = new System.Drawing.Point(345, 276);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(75, 23);
            this.btnClearListBox.TabIndex = 12;
            this.btnClearListBox.Text = "Clear";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.btnClearListBox_Click);
            // 
            // btnClearEpisodeList
            // 
            this.btnClearEpisodeList.Location = new System.Drawing.Point(645, 276);
            this.btnClearEpisodeList.Name = "btnClearEpisodeList";
            this.btnClearEpisodeList.Size = new System.Drawing.Size(75, 23);
            this.btnClearEpisodeList.TabIndex = 13;
            this.btnClearEpisodeList.Text = "Clear";
            this.btnClearEpisodeList.UseVisualStyleBackColor = true;
            this.btnClearEpisodeList.Click += new System.EventHandler(this.btnClearEpisodeList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 525);
            this.Controls.Add(this.btnClearEpisodeList);
            this.Controls.Add(this.btnClearListBox);
            this.Controls.Add(this.btnMergeEnd);
            this.Controls.Add(this.btnMergeStart);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.lblStub);
            this.Controls.Add(this.btnSelectStub);
            this.Controls.Add(this.btnScanLatestVersion);
            this.Controls.Add(this.lstBoxEpisode);
            this.Controls.Add(this.btnScanFile);
            this.Controls.Add(this.lblSelectedFolder);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnScanMedia);
            this.Name = "Form1";
            this.Text = "Media Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScanMedia;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label lblSelectedFolder;
        private System.Windows.Forms.Button btnScanFile;
        private System.Windows.Forms.ListBox lstBoxEpisode;
        private System.Windows.Forms.Button btnScanLatestVersion;
        private System.Windows.Forms.Button btnSelectStub;
        private System.Windows.Forms.Label lblStub;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Button btnMergeStart;
        private System.Windows.Forms.Button btnMergeEnd;
        private System.Windows.Forms.Button btnClearListBox;
        private System.Windows.Forms.Button btnClearEpisodeList;
    }
}

