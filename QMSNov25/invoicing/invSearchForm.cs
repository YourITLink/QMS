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

namespace QMS.invoicing
{
    public partial class invSearchForm : MaterialForm
    {
        public invSearchForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            invSearchForm invs = new invSearchForm();
            invs.Show();
        }

        private void _SearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               // this.findInvTableAdapter.searchInvoice();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string value1 = dataGridView1.CurrentRow.Cells[0].Value != null ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : "";
            _SearchValue.Text = value1;
        }
    }
}
