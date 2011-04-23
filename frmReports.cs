using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using GoogleResults.Properties;

namespace GoogleResults
{
    public partial class frmReports : Form
    {
        Dictionary<string, Dictionary<string, Dictionary<string, int>>> results = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();

        public frmReports()
        {
            InitializeComponent();

            string[] fileContent = File.ReadAllLines(Settings.Default["resultsFile"].ToString());
            List<string> keywordsList = new List<string>();

            foreach (var item in fileContent)
            {
                if (!string.IsNullOrEmpty(item.Trim()))
                {
                    string[] cols = item.Split(new string[] { "##" }, StringSplitOptions.RemoveEmptyEntries);

                    string keyword = cols[0];
                    if (!keywordsList.Contains(keyword))
                    {
                        keywordsList.Add(keyword);
                    }

                    string domain = cols[4];
                    string date = Convert.ToDateTime(cols[1]).ToString("dd/MM/yyyy");
                    int position = Convert.ToInt32(cols[2]);

                    if (!results.ContainsKey(keyword))
                    {
                        Dictionary<string, Dictionary<string, int>> domainDates = new Dictionary<string, Dictionary<string, int>>();
                        Dictionary<string, int> datePositions = new Dictionary<string, int>();

                        datePositions.Add(date, position);
                        domainDates.Add(domain, datePositions);

                        results.Add(keyword, domainDates);
                    }
                    else
                    {
                        Dictionary<string, Dictionary<string, int>> myDomainDates = results[keyword];
                        if (!myDomainDates.ContainsKey(domain))
                        {
                            Dictionary<string, int> datePositions2 = new Dictionary<string, int>();
                            datePositions2.Add(date, position);

                            myDomainDates.Add(domain, datePositions2);
                        }
                        else
                        {
                            Dictionary<string, int> domainDates = myDomainDates[domain];
                            if (!domainDates.ContainsKey(date))
                            {
                                domainDates.Add(date, position);
                            }
                            else
                            {
                                if (domainDates[date] > position)
                                {
                                    domainDates[date] = position;
                                }
                            }
                        }
                    }

                    //string url = cols[3];
                }
            }

            cbKeywords.Items.Clear();
            foreach (var keyw in keywordsList)
            {
                cbKeywords.Items.Add(keyw);
            }

            cbKeywords.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(cbKeywords.SelectedItem.ToString()))
            {
                PrepareChart(results[cbKeywords.SelectedItem.ToString()]);
            }
        }

        private void PrepareChart(Dictionary<string, Dictionary<string, int>> domainsDatesAndValues)
        {
            chart1.Series.Clear();
            foreach (var item in domainsDatesAndValues)
            {
                Series sr = new Series(item.Key);
                sr.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                foreach (var item2 in item.Value)
                {
                    sr.Points.AddXY(item2.Key, item2.Value * -1);
                }

                chart1.Series.Add(sr);
            }
        }

        private void PrepareChart(Dictionary<string, List<int>> domainsAndValues)
        {
            chart1.Series.Clear();
            foreach (var item in domainsAndValues)
            {
                Series sr = new Series(item.Key);
                sr.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                foreach (var item2 in item.Value)
                {
                    sr.Points.AddY(item2);
                }

                chart1.Series.Add(sr);
            }
        }

        private void cbKeywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKeywords.Items.Count > 0 && !string.IsNullOrEmpty(cbKeywords.SelectedItem.ToString()))
            {
                if (results.Keys.Count > 0)
                {
                    PrepareChart(results[cbKeywords.SelectedItem.ToString()]);
                }
            }
        }
    }
}
