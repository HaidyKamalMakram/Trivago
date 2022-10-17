namespace CrystalReports_Startup
{
    partial class Form1
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
            this.GenerateReport_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Category_cmb = new System.Windows.Forms.ComboBox();
            this.StartDate_txt = new System.Windows.Forms.TextBox();
            this.EndDate_txt = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // GenerateReport_btn
            // 
            this.GenerateReport_btn.Location = new System.Drawing.Point(403, 70);
            this.GenerateReport_btn.Name = "GenerateReport_btn";
            this.GenerateReport_btn.Size = new System.Drawing.Size(108, 30);
            this.GenerateReport_btn.TabIndex = 0;
            this.GenerateReport_btn.Text = "Generate Report";
            this.GenerateReport_btn.UseVisualStyleBackColor = true;
            this.GenerateReport_btn.Click += new System.EventHandler(this.GenerateReport_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // Category_cmb
            // 
            this.Category_cmb.FormattingEnabled = true;
            this.Category_cmb.Location = new System.Drawing.Point(120, 28);
            this.Category_cmb.Name = "Category_cmb";
            this.Category_cmb.Size = new System.Drawing.Size(168, 21);
            this.Category_cmb.TabIndex = 4;
//            this.Category_cmb.SelectedIndexChanged += new System.EventHandler(this.Category_cmb_SelectedIndexChanged);
            // 
            // StartDate_txt
            // 
            this.StartDate_txt.Location = new System.Drawing.Point(441, 29);
            this.StartDate_txt.Name = "StartDate_txt";
            this.StartDate_txt.Size = new System.Drawing.Size(148, 20);
            this.StartDate_txt.TabIndex = 5;
            // 
            // EndDate_txt
            // 
            this.EndDate_txt.Location = new System.Drawing.Point(675, 32);
            this.EndDate_txt.Name = "EndDate_txt";
            this.EndDate_txt.Size = new System.Drawing.Size(171, 20);
            this.EndDate_txt.TabIndex = 6;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(8, 111);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(964, 603);
            this.crystalReportViewer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 726);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.EndDate_txt);
            this.Controls.Add(this.StartDate_txt);
            this.Controls.Add(this.Category_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateReport_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateReport_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Category_cmb;
        private System.Windows.Forms.TextBox StartDate_txt;
        private System.Windows.Forms.TextBox EndDate_txt;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}

