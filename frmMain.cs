using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using GoogleResults.Properties;

namespace GoogleResults
{
    public partial class frmMain : Form
    {
        List<string> positions = new List<string>();
        List<string> thisSearchPositions = new List<string>();

        int myLoop = 1;
        int resultsCount = Convert.ToInt32(Settings.Default["resultsCount"]);

        string resultsFile = Settings.Default["resultsFile"].ToString();
        string keyword = Settings.Default["lastKeyword"].ToString();
        string domain = Settings.Default["lastMyDomain"].ToString();
        List<string> rivals = Settings.Default["lastRivalDomains"].ToString()
                            .Split(new string[] { "##" }, StringSplitOptions.RemoveEmptyEntries).ToList();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtKeyword.Text = keyword;
            txtMyDomain.Text = domain;

            foreach (var item in rivals)
            {
                txtRivalDomains.Text += string.Format("{0}{1}", item, Environment.NewLine);
            }

            if (!File.Exists(resultsFile))
            {
                File.WriteAllText(resultsFile, "");
            }

            positions = File.ReadAllLines(resultsFile).ToList();

            myLoop = resultsCount / 10;

            lblStatus.Text = string.Format("{0} / {1}", 0, myLoop);
        }

        private static string GetHTMLSource(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.UserAgent = "Google Result Watcher Crawler";

            StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
            return reader.ReadToEnd();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.OptionFixNestedTags = true;

            keyword = txtKeyword.Text.Trim();
            domain = txtMyDomain.Text.Trim();
            rivals = txtRivalDomains.Lines.ToList();

            rivals.Add(domain);

            for (int l = 0; l < myLoop; l++)
            {
                backgroundWorker1.ReportProgress(l);

                htmlDoc.LoadHtml(GetHTMLSource(string.Format("{0}/search?q={1}&start={2}", Settings.Default["googleUrl"], keyword, l * 10)));

                if (htmlDoc.DocumentNode != null)
                {
                    HtmlAgilityPack.HtmlNodeCollection hrefList = htmlDoc.DocumentNode.SelectNodes("//div//ol//li[@class='g']//h3//a");

                    int listLenght = hrefList.Count;

                    for (int i = 0; i < listLenght; i++)
                    {
                        string myHref = hrefList[i].GetAttributeValue("href", string.Empty);

                        foreach (var item in rivals)
                        {
                            if (myHref.Contains(string.Format(".{0}/", item)) && !string.IsNullOrEmpty(item))
                            {
                                if (myHref.IndexOf(item) > 0)
                                {
                                    string a = "";
                                }

                                int ln = (i + 1) * (l + 1);
                                thisSearchPositions.Add(string.Format("{0} - {1}{2}", ln, myHref, Environment.NewLine));
                                positions.Add(string.Format("{0}##{1}##{2}##{3}##{4}", keyword, DateTime.Now, ln, myHref, item));
                            }
                        }
                    }
                    File.WriteAllLines(resultsFile, positions);
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var item in thisSearchPositions)
            {
                txtResults.Text += item;
            }

            lblStatus.Text = "Completed";
            txtResults.BackColor = System.Drawing.Color.MistyRose;
            btnSearch.Enabled = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage != 0)
            {
                lblStatus.Text = string.Format("{0} / {1}", e.ProgressPercentage, myLoop);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Starting";
            txtResults.Text = string.Empty;
            thisSearchPositions = new List<string>();
            btnSearch.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions frm = new frmOptions();
            frm.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
