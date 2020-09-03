namespace Lab7KuprV3
{
    partial class Form5
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_2TableAdapter1 = new Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.View_2TableAdapter();
            this.courseWorkFor7LabDataSet1 = new Lab7KuprV3.CourseWorkFor7LabDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.courseWorkFor7LabDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lab7KuprV3.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(621, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // view_2TableAdapter1
            // 
            this.view_2TableAdapter1.ClearBeforeFill = true;
            // 
            // courseWorkFor7LabDataSet1
            // 
            this.courseWorkFor7LabDataSet1.DataSetName = "CourseWorkFor7LabDataSet";
            this.courseWorkFor7LabDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form5";
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseWorkFor7LabDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CourseWorkFor7LabDataSetTableAdapters.View_2TableAdapter view_2TableAdapter1;
        private CourseWorkFor7LabDataSet courseWorkFor7LabDataSet1;
    }
}