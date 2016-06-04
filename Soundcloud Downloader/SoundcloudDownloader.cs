using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundcloud_Downloader
{
    public partial class SoundcloudDownloader : Form
    {
        string path;
        public SoundcloudDownloader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splitC.Panel2.Enabled = false;
            urlCheck.Checked = true;
        }

        private void urlCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (urlCheck.Checked)
            {
                splitC.Panel2.Enabled = false;
                splitC.Panel1.Enabled = true;
            }
        }

        private void longCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (longCheck.Checked)
            {
                splitC.Panel1.Enabled = false;
                splitC.Panel2.Enabled = true;
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            if (urlCheck.Checked)
            {
                if (string.IsNullOrEmpty(url.Text))
                {
                    MessageBox.Show("You cant leave url box empty :P");
                }
                else
                {
                    string[] address = url.Text.Split('/');
                    string username = address[address.Length - 2];
                    string songname = address[address.Length - 1];
                    string final = "http://sc-downloader.com/download/" + username + "/" + songname + ".mp3";
                    WebClient download = new WebClient();
                    download.DownloadFileAsync(new Uri(final), path);

                    #region disabled
                    howtouse.Enabled = false;
                    about.Enabled = false;
                    splitC.Panel1.Enabled = false;
                    splitC.Panel2.Enabled = false;
                    filePath.Enabled = false;
                    longCheck.Enabled = false;
                    urlCheck.Enabled = false;
                    label3.Enabled = false;
                    #endregion
                    
                    download.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    download.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

                }
            }
            else if (longCheck.Checked)
            {
                if (string.IsNullOrEmpty(this.username.Text) || string.IsNullOrEmpty(this.songname.Text))
                {
                    MessageBox.Show("You can not leave username and songname box empty :P 3:)");
                }
                else
                {                    
                    string username = this.username.Text;
                    string songname = this.songname.Text;
                    string final = "http://sc-downloader.com/download/" + username + "/" + songname + ".mp3";
                    WebClient download = new WebClient();
                    download.DownloadFileAsync(new Uri(final), path);
                    
                    #region disabled
                    howtouse.Enabled = false;
                    about.Enabled = false;
                    splitC.Panel1.Enabled = false;
                    splitC.Panel2.Enabled = false;
                    filePath.Enabled = false;
                    longCheck.Enabled = false;
                    label3.Enabled = false;
                    urlCheck.Enabled = false;
                    #endregion
                    
                    download.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                    download.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            float a = e.BytesReceived / 1000;
            float b = e.TotalBytesToReceive / 1000; 
            dbytes.Text = a.ToString() + "KB";
            tbytes.Text = b.ToString() + "KB";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            DownloadComplete dc = new DownloadComplete(path);
            dc.Show();
            this.Hide();
        }
        private void howtouse_Click(object sender, EventArgs e)
        {
            HowToUse f = new HowToUse();
            f.Show();
            this.Hide();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.Show();
            this.Hide();
        }

        private void filePath_Click(object sender, EventArgs e)
        {
            string sdfolder = @"C:\Users\" + Environment.UserName + @"\Downloads\Soundcloud Downloads";
            if (Directory.Exists(sdfolder))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(sdfolder);
            }
            SaveFileDialog sd = new SaveFileDialog();
            sd.FileName = "*.mp3";
            sd.InitialDirectory = sdfolder;
            sd.DefaultExt = "mp3";
            sd.Filter = "Music files (.mp3)|.mp3|All files (*.*)|*.*";
            sd.ShowDialog();
            path = sd.FileName;
        }
    }
}
