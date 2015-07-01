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
            this.SuspendLayout();
            // 
            // btnScanMedia
            // 
            this.btnScanMedia.Location = new System.Drawing.Point(12, 32);
            this.btnScanMedia.Name = "btnScanMedia";
            this.btnScanMedia.Size = new System.Drawing.Size(108, 23);
            this.btnScanMedia.TabIndex = 0;
            this.btnScanMedia.Text = "Scan Media";
            this.btnScanMedia.UseVisualStyleBackColor = true;
            this.btnScanMedia.Click += new System.EventHandler(this.btnScanMedia_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(126, 12);
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
            this.lstBoxEpisode.Location = new System.Drawing.Point(426, 12);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 269);
            this.Controls.Add(this.btnScanLatestVersion);
            this.Controls.Add(this.lstBoxEpisode);
            this.Controls.Add(this.btnScanFile);
            this.Controls.Add(this.lblSelectedFolder);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnScanMedia);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

