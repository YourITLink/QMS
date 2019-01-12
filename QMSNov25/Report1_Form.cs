using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QMS
{
    public partial class Report1_Form : Form
    {
        public static int loadcurr;
        public Report1_Form()
        {
            InitializeComponent();
            //Load in Current Invoice Number to filter report
            loadInv.Text = invoiceLoad.thisInvoice;
            loadcurr = Int32.Parse(loadInv.Text);



        }

    

    private void Report1_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alldata.InvoiceComplete' table. You can move, or remove it, as needed.
            loadInv.Text = invoiceLoad.thisInvoice;
            this.InvoiceCompleteTableAdapter.Fill(this.alldata.InvoiceComplete,loadcurr);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
