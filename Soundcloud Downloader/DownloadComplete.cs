using System;
using System.IO;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Soundcloud_Downloader
{
    public partial class DownloadComplete : Form
    {
        string path;
        public DownloadComplete(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void back_Click(object sender, EventArgs e)
        {
            SoundcloudDownloader scd = new SoundcloudDownloader();
            scd.Show();
            this.Hide();
        }

        private void open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path);
        }

        private void openfolder_Click(object sender, EventArgs e)
        {
            string pathwithoutfile = Path.GetDirectoryName(path);
            System.Diagnostics.Process.Start(pathwithoutfile);
        }
    }
}
