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
using QMS;



namespace QMS
{
    public partial class QMSParent : Form
    {
        private int childFormNumber = 0;
        

        //Construct Username using "string and message"
        public QMSParent()
        {

             
            InitializeComponent();
            //Load in Username to Label1 as "Message"
            statusBar1.Panels[3].Text = loginForm.userName;
           
         
        }
        

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Exiting QSync";
            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void QMSParent_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
        }

        private void testMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.ShowDialog();
        }

        private void fileMenu_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "File Options Menu";
        }

        private void fileMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            statusBar1.Panels[0].Text = "File - Menu";
        }

        private void newToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create a New Document";
        }

        private void quotationToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create a new Quotation";
        }

        private void dummyInvoiceToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create a new Dummy Invoice";
        }

        private void serviceWorksheetToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Add a Customer to be Serviced";
        }

        private void shutterProfileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Create a New Shutter Profile";
        }

        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Exit QMS QSync";
        }

        private void printToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Print an Existing Document";
        }

        private void quotationToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Print a Quotation";
        }

        private void invoiceToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Print a Invoice";
        }

        private void serviceWorksheetsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Print Monthly Service Worksheets";
        }

        private void shutterProfileToolStripMenuItem2_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Print a Shutter Profile Sheet";
        }

        private void fileMenu_DropDownClosed(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "QMS QSync - by Your IT Link";
        }

        private void dummyInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoiceLoad invf = new invoiceLoad();
            invf.Show();
        }

        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoiceLoad invp = new invoiceLoad();
            invp.Show();
        }
    }

        }
