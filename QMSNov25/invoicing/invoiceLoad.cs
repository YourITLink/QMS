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


namespace QMS
{
    //
    // Form Initialization 
    //
    public partial class invoiceLoad : MaterialForm
    {
        public static string loadInvoice;
        public static string CustNo;
        public static string thisInvoice;

        

        public invoiceLoad()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            statusBar1.Panels[0].Text = "Create/Edit/View Dummy Invoices";
            statusBar1.Panels[3].Text = loginForm.userName;



        }
        
        //
        // Form load events
        //
        private void invoiceCreate_Load(object sender, EventArgs e)
        {
            this.invoicesTableAdapter.Fill(this.alldata.invoices);
            // TODO: This line of code loads data into the 'alldata.invitems' table. You can move, or remove it, as needed.
            this.invitemsTableAdapter.FillBy(this.alldata.invitems);
            // TODO: This line of code loads data into the 'alldata.quoteitems' table. You can move, or remove it, as needed.
            this.nswpcTableAdapter.Fill(this.alldata.nswpc);
            // TODO: This line of code loads data into the 'alldata.invoicetype' table. You can move, or remove it, as needed.
            this.invoicetypeTableAdapter.Fill(this.alldata.invoicetype);
            // TODO: This line of code loads data into the 'alldata.states' table. You can move, or remove it, as needed.
            this.statesTableAdapter.fillState(this.alldata.states);
            // TODO: This line of code loads data into the 'alldata.nswpc' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'alldata.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.alldata.staff);
            // TODO: This line of code loads data into the 'alldata.staff' table. You can move, or remove it, as needed.
            //Test "IN" variable collection of Invoice number for current record
            //Test write variable to form view textbox 
            //Load "Invoice Number" as a variable to use outside this form
            invoiceLoad.loadInvoice = invoiceNumberTextBox.Text;
            invoiceLoad.CustNo = accountNoTextBox.Text;
            currentInvoice.Text = this.invoiceNumberTextBox.Text;
        }
        //
        // Form data binding sources
        //
        //
        // Form status time and date display
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
            currentInvoice.Text = this.invoiceNumberTextBox.Text;

        }
        //
        // Form status texts
        //
        private void newToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create New Invoice";
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Creating New Dummy Invoice - Complete required fields";
        }
        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Record Deleted - Cannot Undo";
        }
        
        //
        // Form search box
        //
        private void searchTextBox_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Find an Invoice";
        }
        //
        // Form Data command buttons
        //
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.invitemsBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);
            statusBar1.Panels[0].Text = "Record Saved - Commited to database";
            MessageBox.Show("Record update completed.");
        }
        //
        // Form menu commands
        //
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lastRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.invoicesBindingSource.MoveLast();
            statusBar1.Panels[0].Text = "Go to Last Invoice";
        }
        private void lastRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.invoicesBindingSource.MovePrevious();
            statusBar1.Panels[0].Text = "Go to Previous Invoice";
        }
        private void nextRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.invoicesBindingSource.MoveNext();
            statusBar1.Panels[0].Text = "Go to Next Invoice";
        }
        private void firstRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.invoicesBindingSource.MoveFirst();
            statusBar1.Panels[0].Text = "Go to First Invoice";
        }
        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.invoicesBindingSource.AddNew();
            this.comboBox1.Text = loginForm.userName;
            this.comboBox2.Text = "NSW";
            this.comboBox4.Text = "NSW";
            statusBar1.Panels[0].Text = "Create New Invoice";
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.invitemsBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);
            statusBar1.Panels[0].Text = "Record Saved - Commited to database";
            MessageBox.Show("Record update completed.");
        }
        private void deleteInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.invoicesBindingSource.RemoveCurrent();
            statusBar1.Panels[0].Text = "Invoice Deleted from System";
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.ShowDialog();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Searching Records for...";
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(invoiceLoad.thisInvoice);
            invoiceLoad.thisInvoice = currentInvoice.Text;
            Report1_Form invp = new Report1_Form();
            invp.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentInvoice.Text = this.invoiceNumberTextBox.Text;
        }

       
    }
}

