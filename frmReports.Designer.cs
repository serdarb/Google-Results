namespace GoogleResults
{
    partial class frmReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbKeywords = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeyword.Location = new System.Drawing.Point(28, 20);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(55, 13);
            this.lblKeyword.TabIndex = 0;
            this.lblKeyword.Text = "Keyword";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(31, 57);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(569, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // cbKeywords
            // 
            this.cbKeywords.FormattingEnabled = true;
            this.cbKeywords.Location = new System.Drawing.Point(98, 17);
            this.cbKeywords.Name = "cbKeywords";
            this.cbKeywords.Size = new System.Drawing.Size(502, 21);
            this.cbKeywords.TabIndex = 2;
            this.cbKeywords.SelectedIndexChanged += new System.EventHandler(this.cbKeywords_SelectedIndexChanged);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 387);
            this.Controls.Add(this.cbKeywords);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblKeyword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GoogleResults Watcher Reports";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbKeywords;
    }
}