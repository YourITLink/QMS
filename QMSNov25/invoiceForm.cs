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

namespace QMS
{
    public partial class invoiceForm : MaterialForm
    {
        public invoiceForm()
        {
            InitializeComponent();

            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

         }
        //Update data into Invoice
        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qmsDataSet);

        }

        private void invoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qmsDataSet.invitems' table. You can move, or remove it, as needed.
            this.invitemsTableAdapter.Fill(this.qmsDataSet.invitems);
            // TODO: This line of code loads data into the 'qmsDataSet.invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.qmsDataSet.invoices);

        }

        private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "File Menu";
        }

        private void fileToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "";
        }

        private void materialFlatButton1_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create new invoice";
        }

        private void materialFlatButton1_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "";
        }

        private void materialFlatButton2_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Find Invoice";
        }

        private void materialFlatButton2_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "";
        }

        private void materialFlatButton3_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Preview Current Invoice";
        }

        private void materialFlatButton3_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "";
        }

        private void materialFlatButton4_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Print current Invoice";
        }

        private void materialFlatButton4_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "";
        }

        private void materialFlatButton5_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Email current Invoice";
        }

        private void materialFlatButton5_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "";
        }

        private void invCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qmsDataSet);
            
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["LogAuth"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("FindQuote", con);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtInv = new DataTable();
                sqlda.Fill(dtInv);
                invNbrBindingSource.DataSource = dtInv;
                    
                }            

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
    }
}
