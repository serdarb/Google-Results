namespace GoogleResults
{
    partial class frmMain
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblMyDomain = new System.Windows.Forms.Label();
            this.lblRivalDomains = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtMyDomain = new System.Windows.Forms.TextBox();
            this.txtRivalDomains = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(254, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 40);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Start";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(18, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(230, 24);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "status";
            // 
            // lblExpression
            // 
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExpression.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblExpression.Location = new System.Drawing.Point(352, 38);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(385, 34);
            this.lblExpression.TabIndex = 2;
            this.lblExpression.Text = "This little app crawls the google results and records positions. \r\nYou can see ba" +
                "sic graphs of your searches by keywords.\r\n\r\n";
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeyword.Location = new System.Drawing.Point(13, 117);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(67, 16);
            this.lblKeyword.TabIndex = 3;
            this.lblKeyword.Text = "Keyword";
            // 
            // lblMyDomain
            // 
            this.lblMyDomain.AutoSize = true;
            this.lblMyDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMyDomain.Location = new System.Drawing.Point(13, 172);
            this.lblMyDomain.Name = "lblMyDomain";
            this.lblMyDomain.Size = new System.Drawing.Size(85, 16);
            this.lblMyDomain.TabIndex = 4;
            this.lblMyDomain.Text = "My Domain";
            // 
            // lblRivalDomains
            // 
            this.lblRivalDomains.AutoSize = true;
            this.lblRivalDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRivalDomains.Location = new System.Drawing.Point(12, 227);
            this.lblRivalDomains.Name = "lblRivalDomains";
            this.lblRivalDomains.Size = new System.Drawing.Size(109, 16);
            this.lblRivalDomains.TabIndex = 5;
            this.lblRivalDomains.Text = "Rival Domains";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(22, 136);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(205, 20);
            this.txtKeyword.TabIndex = 6;
            // 
            // txtMyDomain
            // 
            this.txtMyDomain.Location = new System.Drawing.Point(22, 191);
            this.txtMyDomain.Name = "txtMyDomain";
            this.txtMyDomain.Size = new System.Drawing.Size(205, 20);
            this.txtMyDomain.TabIndex = 7;
            // 
            // txtRivalDomains
            // 
            this.txtRivalDomains.Location = new System.Drawing.Point(22, 246);
            this.txtRivalDomains.Multiline = true;
            this.txtRivalDomains.Name = "txtRivalDomains";
            this.txtRivalDomains.Size = new System.Drawing.Size(205, 86);
            this.txtRivalDomains.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(237, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(254, 136);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(483, 196);
            this.txtResults.TabIndex = 11;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblLine.Location = new System.Drawing.Point(14, 90);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(722, 13);
            this.lblLine.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 358);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRivalDomains);
            this.Controls.Add(this.txtMyDomain);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.lblRivalDomains);
            this.Controls.Add(this.lblMyDomain);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Results Watcher";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblMyDomain;
        private System.Windows.Forms.Label lblRivalDomains;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.TextBox txtMyDomain;
        private System.Windows.Forms.TextBox txtRivalDomains;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblLine;
    }
}

