using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using System.Configuration;
using Bunifu.Framework.UI;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QMS
{
    public partial class searchInvoice : MaterialForm
    {
        public searchInvoice(string s)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            timer1.Enabled = true;
            timer1.Interval = 1000;
            statusBar1.Panels[3].Text = s;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);

        }

        private void searchInvoice_Load(object sender, EventArgs e)
        {
            this.invoicesTableAdapter.Fill(this.alldata.invoices);
            // TODO: This line of code loads data into the 'alldata.invitems' table. You can move, or remove it, as needed.
            this.invitemsTableAdapter.InvNbrItemFill(this.alldata.invitems);
            // TODO: This line of code loads data into the 'alldata.invoices' table. You can move, or remove it, as needed.
        }

       
    }
    }
