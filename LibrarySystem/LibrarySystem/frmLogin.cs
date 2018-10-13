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

namespace LibrarySystem
{
    public partial class frmLogin : Form
    {
        public static string username;
        public static int lvl;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            using (MySqlConnection con = new MySqlConnection("datasource=127.0.0.1; port = 3306;username = root; password=; database=dbLibrary; convert zero datetime=True;"))
            {
                using (MySqlCommand com = new MySqlCommand())
                {
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "SELECT * FROM tblUsers WHERE username = '" + txtUsername.Text +
                                        "' COLLATE Latin1_General_CS AND password = '" + txtPassword.Text + "' COLLATE Latin1_General_CS ;";

                    try
                    {
                        con.Open();
                        MySqlDataReader sdr = com.ExecuteReader();
                        if (sdr.Read() == true)
                        {
                            //if user is existing
                            //it will go to the main form
                            frmUserAccount ua = new frmUserAccount();
                            username = txtUsername.Text;

                            lvl = sdr.GetInt32(6);
                            frmMain mainfrm = new frmMain();
                            mainfrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username and/or password!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    con.Close();
                }
            }
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
            this.AcceptButton = this.button1;

        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.ShowDialog();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //this.AcceptButton = this.btnLogin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnLogin.PerformClick();
            btnLogin_Click(new object(), new EventArgs());
        }
    }
}
