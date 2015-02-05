namespace AntrianFM
{
    partial class Form6
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
            this.tgl2 = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tgl = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbLantai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tgl2
            // 
            this.tgl2.CustomFormat = "dd-MM-yyyy";
            this.tgl2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tgl2.Location = new System.Drawing.Point(181, 11);
            this.tgl2.Name = "tgl2";
            this.tgl2.Size = new System.Drawing.Size(96, 20);
            this.tgl2.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(389, 9);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "s/d";
            // 
            // tgl
            // 
            this.tgl.CustomFormat = "dd-MM-yyyy";
            this.tgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tgl.Location = new System.Drawing.Point(64, 11);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(82, 20);
            this.tgl.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AntrianFM.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.Size = new System.Drawing.Size(796, 595);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // cmbLantai
            // 
            this.cmbLantai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLantai.FormattingEnabled = true;
            this.cmbLantai.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbLantai.Location = new System.Drawing.Point(325, 10);
            this.cmbLantai.Name = "cmbLantai";
            this.cmbLantai.Size = new System.Drawing.Size(58, 21);
            this.cmbLantai.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lantai";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 636);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLantai);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tgl2);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Antrian";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tgl2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tgl;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cmbLantai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}