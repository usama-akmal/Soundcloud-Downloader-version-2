namespace Soundcloud_Downloader
{
    partial class SoundcloudDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundcloudDownloader));
            this.url = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.urlll = new System.Windows.Forms.Label();
            this.urlCheck = new System.Windows.Forms.RadioButton();
            this.longCheck = new System.Windows.Forms.RadioButton();
            this.splitC = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.songname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.howtouse = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dbytes = new System.Windows.Forms.TextBox();
            this.tbytes = new System.Windows.Forms.TextBox();
            this.filePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitC)).BeginInit();
            this.splitC.Panel1.SuspendLayout();
            this.splitC.Panel2.SuspendLayout();
            this.splitC.SuspendLayout();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.Location = new System.Drawing.Point(4, 63);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(324, 38);
            this.url.TabIndex = 0;
            // 
            // download
            // 
            this.download.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.Location = new System.Drawing.Point(765, 343);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(160, 49);
            this.download.TabIndex = 1;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 288);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(906, 49);
            this.progressBar1.TabIndex = 2;
            // 
            // urlll
            // 
            this.urlll.AutoSize = true;
            this.urlll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlll.ForeColor = System.Drawing.Color.Black;
            this.urlll.Location = new System.Drawing.Point(3, 31);
            this.urlll.Name = "urlll";
            this.urlll.Size = new System.Drawing.Size(303, 20);
            this.urlll.TabIndex = 3;
            this.urlll.Text = "Enter Your Song, Soundcloud URL below";
            // 
            // urlCheck
            // 
            this.urlCheck.AutoSize = true;
            this.urlCheck.BackColor = System.Drawing.Color.Transparent;
            this.urlCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlCheck.ForeColor = System.Drawing.Color.Black;
            this.urlCheck.Location = new System.Drawing.Point(18, 212);
            this.urlCheck.Name = "urlCheck";
            this.urlCheck.Size = new System.Drawing.Size(47, 24);
            this.urlCheck.TabIndex = 4;
            this.urlCheck.TabStop = true;
            this.urlCheck.Text = "Url";
            this.urlCheck.UseVisualStyleBackColor = false;
            this.urlCheck.CheckedChanged += new System.EventHandler(this.urlCheck_CheckedChanged);
            // 
            // longCheck
            // 
            this.longCheck.AutoSize = true;
            this.longCheck.BackColor = System.Drawing.Color.Transparent;
            this.longCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longCheck.ForeColor = System.Drawing.Color.Black;
            this.longCheck.Location = new System.Drawing.Point(18, 251);
            this.longCheck.Name = "longCheck";
            this.longCheck.Size = new System.Drawing.Size(204, 24);
            this.longCheck.TabIndex = 5;
            this.longCheck.TabStop = true;
            this.longCheck.Text = "Username && Song Name";
            this.longCheck.UseVisualStyleBackColor = false;
            this.longCheck.CheckedChanged += new System.EventHandler(this.longCheck_CheckedChanged);
            // 
            // splitC
            // 
            this.splitC.BackColor = System.Drawing.Color.Transparent;
            this.splitC.Location = new System.Drawing.Point(292, 24);
            this.splitC.Name = "splitC";
            // 
            // splitC.Panel1
            // 
            this.splitC.Panel1.Controls.Add(this.url);
            this.splitC.Panel1.Controls.Add(this.urlll);
            // 
            // splitC.Panel2
            // 
            this.splitC.Panel2.Controls.Add(this.label2);
            this.splitC.Panel2.Controls.Add(this.label1);
            this.splitC.Panel2.Controls.Add(this.songname);
            this.splitC.Panel2.Controls.Add(this.username);
            this.splitC.Size = new System.Drawing.Size(647, 169);
            this.splitC.SplitterDistance = 359;
            this.splitC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Song Name From Url";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Uploader Username";
            // 
            // songname
            // 
            this.songname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songname.Location = new System.Drawing.Point(6, 103);
            this.songname.Name = "songname";
            this.songname.Size = new System.Drawing.Size(263, 38);
            this.songname.TabIndex = 1;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(6, 31);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 38);
            this.username.TabIndex = 0;
            // 
            // howtouse
            // 
            this.howtouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtouse.Location = new System.Drawing.Point(17, 343);
            this.howtouse.Name = "howtouse";
            this.howtouse.Size = new System.Drawing.Size(212, 44);
            this.howtouse.TabIndex = 7;
            this.howtouse.Text = "How To Use";
            this.howtouse.UseVisualStyleBackColor = true;
            this.howtouse.Click += new System.EventHandler(this.howtouse_Click);
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(233, 343);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(191, 44);
            this.about.TabIndex = 8;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Click Below";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Downloaded Kilo Bytes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(758, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Kilo Bytes";
            // 
            // dbytes
            // 
            this.dbytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbytes.Location = new System.Drawing.Point(506, 242);
            this.dbytes.Name = "dbytes";
            this.dbytes.ReadOnly = true;
            this.dbytes.Size = new System.Drawing.Size(163, 38);
            this.dbytes.TabIndex = 13;
            this.dbytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbytes
            // 
            this.tbytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbytes.Location = new System.Drawing.Point(760, 242);
            this.tbytes.Name = "tbytes";
            this.tbytes.ReadOnly = true;
            this.tbytes.Size = new System.Drawing.Size(163, 38);
            this.tbytes.TabIndex = 14;
            this.tbytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.Location = new System.Drawing.Point(17, 78);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(256, 58);
            this.filePath.TabIndex = 15;
            this.filePath.Text = "Give File Path  and Name";
            this.filePath.UseVisualStyleBackColor = true;
            this.filePath.Click += new System.EventHandler(this.filePath_Click);
            // 
            // SoundcloudDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 412);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.tbytes);
            this.Controls.Add(this.dbytes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.about);
            this.Controls.Add(this.howtouse);
            this.Controls.Add(this.splitC);
            this.Controls.Add(this.longCheck);
            this.Controls.Add(this.urlCheck);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.download);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SoundcloudDownloader";
            this.Text = "Soundcloud Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitC.Panel1.ResumeLayout(false);
            this.splitC.Panel1.PerformLayout();
            this.splitC.Panel2.ResumeLayout(false);
            this.splitC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitC)).EndInit();
            this.splitC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label urlll;
        private System.Windows.Forms.RadioButton urlCheck;
        private System.Windows.Forms.RadioButton longCheck;
        private System.Windows.Forms.SplitContainer splitC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox songname;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button howtouse;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dbytes;
        private System.Windows.Forms.TextBox tbytes;
        private System.Windows.Forms.Button filePath;
    }
}

