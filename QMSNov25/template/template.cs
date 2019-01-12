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

namespace QMS.template
{
    public partial class template : MaterialForm
    {

        public template()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            statusBar1.Panels[0].Text = "FORM OPEN STATUS BAR TEXT";
            statusBar1.Panels[3].Text = loginForm.userName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
        }

        // Form status texts
        //
        private void file_New_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create New Invoice";
        }
        private void fileNew_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Creating New Dummy Invoice - Complete required fields";
        }

        private void file_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Once deleted the record cannot be recovered, are you sure you want to delete the current record?", "WARNING - DELETE RECORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                //this.invoicesBindingSource.RemoveCurrent();
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
            //this.invoicesBindingSource.EndEdit();
            //this.invitemsBindingSource1.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.alldata);
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
            //this.invoicesBindingSource.MoveLast();
            statusBar1.Panels[0].Text = "Go to Last Invoice";
        }
        private void com_PrevRecord_Click(object sender, EventArgs e)
        {
            //this.invoicesBindingSource.MovePrevious();
            statusBar1.Panels[0].Text = "Go to Previous Invoice";
        }
        private void com_nextRecord_Click(object sender, EventArgs e)
        {
            //this.invoicesBindingSource.MoveNext();
            statusBar1.Panels[0].Text = "Go to Next Invoice";
        }
        private void com_firstRecord_Click(object sender, EventArgs e)
        {
            //this.invoicesBindingSource.MoveFirst();
            statusBar1.Panels[0].Text = "Go to First Invoice";
        }
        private void com_NewRecord_Click(object sender, EventArgs e)
        {
            //this.invoicesBindingSource.AddNew();
            //this.comboBox1.Text = loginForm.userName;
            //this.comboBox2.Text = "NSW";
            //this.comboBox4.Text = "NSW";
            statusBar1.Panels[0].Text = "Create New Invoice";
        }
        private void file_Save_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.invoicesBindingSource.EndEdit();
            //this.invitemsBindingSource1.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.alldata);
            statusBar1.Panels[0].Text = "Record Saved - Commited to database";
            MessageBox.Show("Record update completed.");
        }
        private void com_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes ==
                MessageBox.Show("Once deleted the record cannot be recovered, are you sure you want to delete the current record?", "WARNING - DELETE RECORD?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                //this.invoicesBindingSource.RemoveCurrent();
                statusBar1.Panels[0].Text = "The record has been deleted";
            }
        }
        private void file_About_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.ShowDialog();
        }
        private void com_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }

}
