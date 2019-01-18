using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QMS.quoting
{
    public partial class quotePreview : Form
    {

        //Load variable here
        public static int loadcurrQt;
        public quotePreview()
        {
            InitializeComponent();
            //Load in Current Invoice Number to filter report
            loadQuote.Text = quoteLoad.thisQuote;
            //Variable changed to int
            loadcurrQt = Int32.Parse(loadQuote.Text);
        }
            
        private void quotePreview_Load(object sender, EventArgs e)
        {
                this.quotesCompleteTableAdapter.Fill(this.alldata.quotesComplete, loadcurrQt);


                this.reportViewer1.RefreshReport();
        }

        //private void quotePreview_Load_1(object sender, EventArgs e)
        //{
            // TODO: This line of code loads data into the 'alldata.quotesComplete' table. You can move, or remove it, as needed.
            //this.quotesCompleteTableAdapter.Fill(this.alldata.quotesComplete);

        //}
    }
}
