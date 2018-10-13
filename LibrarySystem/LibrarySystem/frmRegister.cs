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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtPW.Text == txtPW1.Text)
            {
                insertData();
            }
        }

        private void insertData()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "INSERT INTO `tblUsers`(`lastName`, `firstName`, `middleName`, `username`, `password`, `status`)" +
                                        "VALUES (@ln,@fn,@mn,@un,@pw,@s)";
                dbConnect.com.Parameters.AddWithValue("@ln", txtLName.Text);
                dbConnect.com.Parameters.AddWithValue("@fn", txtFName.Text);
                dbConnect.com.Parameters.AddWithValue("@mn", txtMName.Text);
                dbConnect.com.Parameters.AddWithValue("@un", txtUName.Text);
                dbConnect.com.Parameters.AddWithValue("@pw", txtPW.Text);
                dbConnect.com.Parameters.AddWithValue("@s", 0);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered!");
                    clearFields();
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

        private void clearFields()
        {
            txtLName.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtUName.Text = "";
            txtPW.Text = "";
            txtPW1.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel transaction?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dbConnect.con != null && dbConnect.con.State == ConnectionState.Open)
                {
                    dbConnect.con.Close();
                }
                clearFields();

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
    }
}
