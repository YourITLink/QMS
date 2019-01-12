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

    public partial class loginForm : MaterialForm
    {

        public static string userName;
        public static string test;

        public loginForm()  
        {
            InitializeComponent();
            timer1.Enabled = true;
            statusBar1.Panels[0].Text = "QSync - Login to Continue";
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["LogAuth"].ConnectionString; 
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                using (MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"select count(*) from logauth where UserName=@UserName and Password=@Password";
                    cmd.Parameters.Add(new MySqlParameter("UserName", UsernameO.Text));
                    cmd.Parameters.Add(new MySqlParameter("Password", PasswordO.Text));
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i > 0)
                    {
                        loginForm.userName = UsernameO.Text;
                        QMSParent invf = new QMSParent();
                        
                       
                        invf.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("UserName or Password error.");
                        

                    }
                    
                }
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            statusBar1.Panels[1].Text = DateTime.Now.ToString("hh:mm tt");
            statusBar1.Panels[2].Text = DateTime.Now.ToString("dd/MM/yy");
        }
        private void UsernameO_Enter(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Enter Your Username";
        }

        private void UsernameO_Leave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "QSync - Login to Continue";
        }

        private void PasswordO_Enter(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Enter your Password";
        }

        private void PasswordO_Leave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "QSync - Login to Continue";
        }

        private void metroButton1_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Continue to QSync";
        }

        private void metroButton1_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "QSync - Login to Continue";
        }

        private void metroButton2_MouseHover(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Cancel - Application will EXIT";
        }

        private void metroButton2_MouseLeave(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "QSync - Login to Continue";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


    }
}
