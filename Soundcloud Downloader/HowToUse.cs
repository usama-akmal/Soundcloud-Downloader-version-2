using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundcloud_Downloader
{
    public partial class HowToUse : Form
    {
        public HowToUse()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            SoundcloudDownloader f = new SoundcloudDownloader();
            f.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
