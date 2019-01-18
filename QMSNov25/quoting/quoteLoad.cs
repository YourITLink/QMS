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
        public static string thisQuote;

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
            currentQuote.Text = quoteNumberTextBox.Text;

        }
 //
 // Menu / Command Bar Action Events
 //
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
            currentQuote.Text = quoteNumberTextBox.Text;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Once deleted the record cannot be recovered, are you sure you want to delete the current record?", "WARNING - DELETE RECORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                this.quotesBindingSource.RemoveCurrent();
                statusBar1.Panels[0].Text = "The record has been deleted";
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Search for a Quote";
        }
        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotesBindingSource.EndEdit();
            this.quoteitemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);
            statusBar1.Panels[0].Text = "Record Saved - Commited to database";
            MessageBox.Show("Your changes to the quote have been saved.", "Changes Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LastRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MoveLast();
            statusBar1.Panels[0].Text = "Last Quote in System Displayed";
        }
        private void PrevRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MovePrevious();
            statusBar1.Panels[0].Text = "Previous Quote Displayed";
        }
        private void NextRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MoveNext();
            statusBar1.Panels[0].Text = "Next Quote Displayed";
        }
        private void FirstRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.MoveFirst();
            statusBar1.Panels[0].Text = "First Quote Displayed";
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            this.quotesBindingSource.AddNew();
            this.comboBox1.Text = "New";
            this.comboBox5.Text = loginForm.userName;
            this.comboBox3.Text = "NSW";
            statusBar1.Panels[0].Text = "Create New Quotation";
        }
        private void About_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.ShowDialog();
            statusBar1.Panels[0].Text = "About QSync Loading";
        }
        private void Print_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(quoteLoad.thisQuote);
            quoteLoad.thisQuote = currentQuote.Text;
            quotePreview qtep = new quotePreview();
            qtep.ShowDialog();
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Searching Records for...";
        }
 //
 // Menu Hover Events into StatusBar Text
 //
        private void NewRecord_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create a new Quote";
        }
        private void Exit_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Close Form";
        }
        private void Delete_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Delete current quote";
        }
        private void Search_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Search for a Quote";
        }
        private void Save_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Save changes made to the Quote";
        }
        private void LastRecord_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Go to Last Quote";
        }
        private void PrevRecord_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Go to Previous Quote";
        }
        private void NextRecord_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Go to Next Quote";
        }
        private void FirstRecord_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Go to First Quote";
        }
        private void About_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "About QSync";
        }
        private void Print_Hover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Load a preview of the Quote to Print";
        }
    }
}
