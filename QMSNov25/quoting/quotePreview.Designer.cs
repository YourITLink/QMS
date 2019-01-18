namespace QMS.quoting
{
    partial class quotePreview
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
            this.quotesCompleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alldata = new QMS.alldata();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.loadQuote = new System.Windows.Forms.TextBox();
            this.quotesCompleteTableAdapter = new QMS.alldataTableAdapters.quotesCompleteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quotesCompleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldata)).BeginInit();
            this.SuspendLayout();
            // 
            // quotesCompleteBindingSource
            // 
            this.quotesCompleteBindingSource.DataMember = "quotesComplete";
            this.quotesCompleteBindingSource.DataSource = this.alldata;
            // 
            // alldata
            // 
            this.alldata.DataSetName = "alldata";
            this.alldata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "quotesComplete";
            reportDataSource1.Value = this.quotesCompleteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QMS.quoting.quotePreview.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(845, 776);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // loadQuote
            // 
            this.loadQuote.Enabled = false;
            this.loadQuote.Location = new System.Drawing.Point(0, 731);
            this.loadQuote.Name = "loadQuote";
            this.loadQuote.Size = new System.Drawing.Size(100, 20);
            this.loadQuote.TabIndex = 2;
            this.loadQuote.TabStop = false;
            this.loadQuote.Visible = false;
            // 
            // quotesCompleteTableAdapter
            // 
            this.quotesCompleteTableAdapter.ClearBeforeFill = true;
            // 
            // quotePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 776);
            this.Controls.Add(this.loadQuote);
            this.Controls.Add(this.reportViewer1);
            this.Name = "quotePreview";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotation Preview | QSync by Your IT Link";
            this.Load += new System.EventHandler(this.quotePreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotesCompleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private alldata alldata;
        private alldataTableAdapters.quotesCompleteTableAdapter quotesCompleteTableAdapter;
        private System.Windows.Forms.TextBox loadQuote;
        private System.Windows.Forms.BindingSource quotesCompleteBindingSource;
    }
}