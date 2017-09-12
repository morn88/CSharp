using System;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace WebmLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (linkBox.TextLength != 0)
            {
                int count = 0;
                string remoteUrl = linkBox.Text;
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(remoteUrl, "links.txt");
                string text = System.IO.File.ReadAllText(path: "links.txt");
                string pattern = @"\/\w+\/\w+\/\w+\/\d+\.(webm|mp4)";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(text);
                HashSet<string> urls = new HashSet<string>();
                while (match.Success)
                {
                    urls.Add("https://2ch.hk" + match.Value);
                    match = match.NextMatch();
                    count++;
                }

                foreach (string a in urls)
                {
                    using (WebClient wc = new WebClient())
                    {
                        //wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        wc.DownloadFileCompleted += wc_DownloadFileCompleted;
                        wc.DownloadFileAsync(new Uri(a), @"done\" + a.Split('/').Last());
                    }
                }
            }
        }
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // In case you don't have a progressBar Log the value instead 
            // Console.WriteLine(e.ProgressPercentage);
            progressBar1.Value++;
        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value++;
            if (e.Cancelled)
            {
                MessageBox.Show("The download has been cancelled");
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                MessageBox.Show("An error ocurred while trying to download file");
                return;
            }
        }
    }
}
