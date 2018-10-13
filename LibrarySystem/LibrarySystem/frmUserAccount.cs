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
    public partial class frmUserAccount : Form
    {
        MySqlDataAdapter sda = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        public frmUserAccount()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "select * from tblUsers where username = @un";
                dbConnect.com.Parameters.AddWithValue("@un", frmLogin.username);
                sda = new MySqlDataAdapter(dbConnect.com);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(txtPW1.Text == dt.Rows[0][5].ToString())
                {
                    if (txtPW2.Text == txtPW3.Text)
                    {
                        updateData();
                    }
                    else
                    {
                        MessageBox.Show("The two new passwords do not match.");
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure you entered your old password correctly.");
                }
            }
            
        }
        

        private void updateData()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "UPDATE `tblUsers` SET `lastName`=@ln,`firstName`=@fn,`middleName`=@mn,"+
                                            "`username`=@un,`password`=@pw,`status`=@s WHERE username = @oun";
                dbConnect.com.Parameters.AddWithValue("@ln", txtLName.Text);
                dbConnect.com.Parameters.AddWithValue("@fn", txtFName.Text);
                dbConnect.com.Parameters.AddWithValue("@mn", txtMName.Text);
                dbConnect.com.Parameters.AddWithValue("@un", txtUName.Text);
                dbConnect.com.Parameters.AddWithValue("@pw", txtPW2.Text);
                dbConnect.com.Parameters.AddWithValue("@s", 0);
                dbConnect.com.Parameters.AddWithValue("@oun", frmLogin.username);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Account Updated!");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbConnect.con.Close();
                }
            }
        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "SELECT * FROM `tblusers` WHERE `username` = @un";
                dbConnect.com.Parameters.AddWithValue("@un", frmLogin.username);
                sda = new MySqlDataAdapter(dbConnect.com);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txtLName.Text = dt.Rows[0][1].ToString();
                txtFName.Text = dt.Rows[0][2].ToString();
                txtMName.Text = dt.Rows[0][3].ToString();
                txtUName.Text = dt.Rows[0][4].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel transaction?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dbConnect.con != null && dbConnect.con.State == ConnectionState.Open)
                {
                    dbConnect.con.Close();
                }
                this.Close();
            }
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            if (dbConnect.con != null && dbConnect.con.State == ConnectionState.Open)
            {
                dbConnect.con.Close();
            }
            this.Close();
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }
    }
}
