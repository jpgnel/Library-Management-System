using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class tabLibrarian : UserControl
    {
        public tabLibrarian()
        {
            InitializeComponent();
        }

        private DataTable GetData()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "SELECT `userID`, `lastName`, `firstName`, `middleName` "+
                                            "FROM `tblusers` WHERE `status` = 0 && `level` = 1;";

                MySqlDataAdapter da = new MySqlDataAdapter(dbConnect.com);
                DataTable dt = new DataTable();
                try
                {
                    dbConnect.con.Open();
                    da.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                    bunifuCustomDataGrid1.Columns[0].HeaderText = "LIBRARIAN ID";
                    bunifuCustomDataGrid1.Columns[1].HeaderText = "LAST NAME";
                    bunifuCustomDataGrid1.Columns[2].HeaderText = "FIRST NAME";
                    bunifuCustomDataGrid1.Columns[3].HeaderText = "MIDDLE NAME";
                    bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                finally
                { dbConnect.con.Close(); }
                return dt;
            }
        }

        private void tabLibrarian_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void tabLibrarian_VisibleChanged(object sender, EventArgs e)
        {
            GetData();
        }

        string uid;

        private void updateData()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "UPDATE `tblUsers` SET `lastName`=@ln,`firstName`=@fn,`middleName`=@mn," +
                                            "`username`= @un,`password`=@pw WHERE `userID` = uid";
                dbConnect.com.Parameters.AddWithValue("@ln", txtLName.Text);
                dbConnect.com.Parameters.AddWithValue("@fn", txtFName.Text);
                dbConnect.com.Parameters.AddWithValue("@mn", txtMName.Text);
                dbConnect.com.Parameters.AddWithValue("@un", txtUName.Text);
                dbConnect.com.Parameters.AddWithValue("@pw", txtPW1.Text);
                dbConnect.com.Parameters.AddWithValue("@s", 0);
                dbConnect.com.Parameters.AddWithValue("@uid", uid);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Account Updated Successfully!");
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

        private void insertData()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "INSERT INTO `tblUsers` (`lastName`, `firstName`, `middleName`, `username`, `password`, `level`, `status`) " +
                                        "VALUES (@ln,@fn,@mn,@un,@pw, @lv, @st)";
                dbConnect.com.Parameters.AddWithValue("@ln", txtLName.Text);
                dbConnect.com.Parameters.AddWithValue("@fn", txtFName.Text);
                dbConnect.com.Parameters.AddWithValue("@mn", txtMName.Text);
                dbConnect.com.Parameters.AddWithValue("@un", txtUName.Text);
                dbConnect.com.Parameters.AddWithValue("@pw", txtPW1.Text);
                dbConnect.com.Parameters.AddWithValue("@lv", 1);
                dbConnect.com.Parameters.AddWithValue("@st", 0);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Input Successful!");
                    clearFields();
                    GetData();
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
            txtPW1.Text = "";
            txtUName.Text = "";

            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            bunifuImageButton3.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
            clearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clearFields();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (dbConnect.com = new MySqlCommand())
                    {
                        dbConnect.com.Connection = dbConnect.con;
                        dbConnect.com.CommandText = "UPDATE `tblUsers` SET `status`= 1 WHERE `userID` = @uid;";
                        dbConnect.com.Parameters.AddWithValue("@uid", uid);
                        try
                        {
                            dbConnect.con.Open();
                            int recordsAffected = dbConnect.com.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted!");
                            clearFields();
                            GetData();
                            btnSave.Visible = true;
                            btnUpdate.Visible = false;
                            bunifuImageButton3.Visible = false;
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
            }
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

        private void bunifuCustomDataGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter();
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                try
                {
                    using (dbConnect.com = new MySqlCommand())
                    {
                        dbConnect.com.Connection = dbConnect.con;
                        dbConnect.com.CommandType = CommandType.Text;
                        dbConnect.com.CommandText = "select * from `tblUsers` where `userID` = @uid";
                        dbConnect.com.Parameters.AddWithValue("@uid", bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString());
                        sda = new MySqlDataAdapter(dbConnect.com);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        uid = dt.Rows[0][0].ToString();
                        txtLName.Text = dt.Rows[0][1].ToString();
                        txtFName.Text = dt.Rows[0][2].ToString();
                        txtMName.Text = dt.Rows[0][3].ToString();
                        txtPW1.Text = dt.Rows[0][4].ToString();
                        txtUName.Text = dt.Rows[0][5].ToString();
                    }

                    txtPW1.Enabled = false;
                    txtUName.Enabled = false;
                    btnUpdate.Visible = true;
                    bunifuImageButton3.Visible = true;
                    btnCancel.Visible = false;
                    btnSave.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }
    }
}
