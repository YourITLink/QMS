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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void schBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alldata);

        }

        private void getDataToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.schTableAdapter.Fill(this.alldata.sch, _SearchValueToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
