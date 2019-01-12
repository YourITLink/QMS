namespace QMS
{
    partial class Report1_Form
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report1_Form));
            this.InvoiceCompleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alldata = new QMS.alldata();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoiceCompleteTableAdapter = new QMS.alldataTableAdapters.InvoiceCompleteTableAdapter();
            this.loadInv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceCompleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldata)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceCompleteBindingSource
            // 
            this.InvoiceCompleteBindingSource.DataMember = "InvoiceComplete";
            this.InvoiceCompleteBindingSource.DataSource = this.alldata;
            // 
            // alldata
            // 
            this.alldata.DataSetName = "alldata";
            this.alldata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "invoiceCompleted";
            reportDataSource1.Value = this.InvoiceCompleteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QMS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 716);
            this.reportViewer1.TabIndex = 0;
            // 
            // InvoiceCompleteTableAdapter
            // 
            this.InvoiceCompleteTableAdapter.ClearBeforeFill = true;
            // 
            // loadInv
            // 
            this.loadInv.Enabled = false;
            this.loadInv.Location = new System.Drawing.Point(12, 719);
            this.loadInv.Name = "loadInv";
            this.loadInv.Size = new System.Drawing.Size(100, 20);
            this.loadInv.TabIndex = 1;
            this.loadInv.Visible = false;
            // 
            // Report1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 738);
            this.Controls.Add(this.loadInv);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report1_Form";
            this.Text = "QSync Invoice Preview";
            this.Load += new System.EventHandler(this.Report1_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceCompleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InvoiceCompleteBindingSource;
        private alldata alldata;
        private alldataTableAdapters.InvoiceCompleteTableAdapter InvoiceCompleteTableAdapter;
        private System.Windows.Forms.TextBox loadInv;
    }
}