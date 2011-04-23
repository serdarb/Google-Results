namespace GoogleResults
{
    partial class frmOptions
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
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtResultPath = new System.Windows.Forms.TextBox();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.txtResultCount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 20);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(81, 13);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Result File Path";
            // 
            // txtResultPath
            // 
            this.txtResultPath.Location = new System.Drawing.Point(112, 17);
            this.txtResultPath.Name = "txtResultPath";
            this.txtResultPath.Size = new System.Drawing.Size(125, 20);
            this.txtResultPath.TabIndex = 1;
            this.txtResultPath.Text = "results.txt";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(12, 46);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(68, 13);
            this.lblResultCount.TabIndex = 2;
            this.lblResultCount.Text = "Result Count";
            // 
            // txtResultCount
            // 
            this.txtResultCount.Location = new System.Drawing.Point(112, 43);
            this.txtResultCount.Name = "txtResultCount";
            this.txtResultCount.Size = new System.Drawing.Size(125, 20);
            this.txtResultCount.TabIndex = 3;
            this.txtResultCount.Text = "100";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(243, 16);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(29, 21);
            this.btnFilePath.TabIndex = 5;
            this.btnFilePath.Text = "...";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 103);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtResultCount);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.txtResultPath);
            this.Controls.Add(this.lblFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Google Result Watcher Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtResultPath;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.TextBox txtResultCount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}