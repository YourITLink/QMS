using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MySql.Data.MySqlClient;
using System.Configuration;
using Bunifu.Framework.UI;

namespace QMS.quoting
{
    public partial class quoteLoad : MaterialForm
    {
        public static string currqt;

        public quoteLoad()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            statusBar1.Panels[0].Text = "Quotations - QSync by Your IT Link";
            statusBar1.Panels[3].Text = loginForm.userName;
        }

        private void quoteLoad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alldata.quotes' table. You can move, or remove it, as needed.
            this.quotesTableAdapter.Fill(this.alldata.quotes);
            // TODO: This line of code loads data into the 'alldata.nswpc' table. You can move, or remove it, as needed.
            this.nswpcTableAdapter.Fill(this.alldata.nswpc);
            // TODO: This line of code loads data into the 'alldata.states' table. You can move, or remove it, as needed.
            this.statesTableAdapter.fillState(this.alldata.states);
            // TODO: This line of code loads data into the 'alldata.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.alldata.staff);
            // TODO: This line of code loads data into the 'alldata.quoteitems' table. You can move, or remove it, as needed.
            this.quoteitemsTableAdapter.Fill(this.alldata.quoteitems);
            getQuote.Text = quoteNumberTextBox.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
            getQuote.Text = quoteNumberTextBox.Text;
        }

        // Form status texts
        //
        private void file_New_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Save changes to quote";
        }
        private void fileNew_Click(object sender, EventArgs e)
        {

        }

        private void file_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Once deleted the record cannot be recovered, are you sure you want to delete the current record?", "WARNING - DELETE RECORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                this.quotesBindingSource.RemoveCurrent();
                statusBar1.Panels[0].Text = "The record has been deleted";
            }
        }
        //
        // Form search box
        //
        private void com_search_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Find an Invoice";
        }
        //
        // Form Data command buttons
        //
        private void com_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotesBindingSource.EndEdit();
            this.quoteitemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);
            statusBar1.Panels[0].Text = "Record Saved - Commited to database";
            MessageBox.Show("Record update completed.");
        }
        //
        // Form menu commands
        //
        private void com_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void com_lastRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MoveLast();
            statusBar1.Panels[0].Text = "Go to Last Invoice";
        }
        private void com_PrevRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MovePrevious();
            statusBar1.Panels[0].Text = "Go to Previous Invoice";
        }
        private void com_nextRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MoveNext();
            statusBar1.Panels[0].Text = "Go to Next Invoice";
        }
        private void com_firstRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MoveFirst();
            statusBar1.Panels[0].Text = "Go to First Invoice";
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.AddNew();
            this.comboBox1.Text = "New";
            this.comboBox5.Text = loginForm.userName;
            this.comboBox3.Text = "NSW";
            statusBar1.Panels[0].Text = "Create New Invoice";
        }
        private void file_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotesBindingSource.EndEdit();
            this.quoteitemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);
            statusBar1.Panels[0].Text = "Record Saved - Commited to database";
            MessageBox.Show("Record update completed.");
        }
        private void com_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Once deleted the record cannot be recovered, are you sure you want to delete the current record?", "WARNING - DELETE RECORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                this.quotesBindingSource.RemoveCurrent();
                statusBar1.Panels[0].Text = "The record has been deleted";
            }
        }
        private void file_About_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.ShowDialog();
        }
        private void glo_Exit_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Close Form";
        }

        private void com_Search_TextChanged(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Searching Records for...";
        }
        private void file_Search_Click(object sender, EventArgs e)
        {
            //invoicing.invSearchForm isf = new invoicing.invSearchForm();
            //isf.ShowDialog();
        }

        private void file_Print_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(invoiceLoad.thisInvoice);
            //invoiceLoad.thisInvoice = currentInvoice.Text;
            Report1_Form invp = new Report1_Form();
            invp.ShowDialog();
        }

        private void quotesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
