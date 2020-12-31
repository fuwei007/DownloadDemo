using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                wc.DownloadFileAsync(new Uri("https://speed.hetzner.de/100MB.bin"), @"D:\tests\test.bin");
            }    
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
           this.progressBar1.Value = e.ProgressPercentage;
        }
    }
}
