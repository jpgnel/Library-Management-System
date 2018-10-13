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
    public partial class tabHoldings : UserControl
    {
        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT `AccNum`, `ISBN` FROM `tblholdings`", dbConnect.con);
        DataSet ds = new DataSet();
        private int y;

        public tabHoldings()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void insertData()
        {
            dbConnect.isOpen();
            Boolean success = false;
            y = Convert.ToInt32(txtNumCopies.Text);

            if (y > 0) {
                for (int x = 0; x < y; x++)
                {
                    using (dbConnect.com = new MySqlCommand())
                    {
                        dbConnect.com.Connection = dbConnect.con;
                        dbConnect.com.CommandText = "INSERT INTO `tblholdings`(`ISBN`, `status`) VALUES (@isbn, @s)";
                        dbConnect.com.Parameters.AddWithValue("@isbn", txtISBN.Text);
                        dbConnect.com.Parameters.AddWithValue("@s", 0);
                        try
                        {
                            dbConnect.con.Open();
                            int recordsAffected = dbConnect.com.ExecuteNonQuery();
                            success = true;
                        }
                        catch (MySqlException ex)
                        {
                            success = false;
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            dbConnect.con.Close();
                        }
                    }
                }

                if(success == true)
                {
                    clearFields();
                    GetData();
                    MessageBox.Show("Input Successful!");
                }
            }
            else
            {
                MessageBox.Show("Number of copies can't be less than or equal to 0.");
            }
        }

        //private void h()
        //{
        //    ds.Clear();
        //    sda.Fill(ds, "tblholdings");
        //    bunifuCustomDataGrid1.DataSource = ds.Tables["tblholdings"];
        //    bunifuCustomDataGrid1.Columns[0].HeaderText = "ACCESSION NUMBER";
        //    bunifuCustomDataGrid1.Columns[1].HeaderText = "ISBN";
        //    bunifuCustomDataGrid1.Columns[0].DefaultCellStyle.Format = "D5";
        //    bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //}

        private DataTable GetData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "SELECT `AccNum`, h.ISBN, `Title`, `Author`, `Category`, `Edition`, `Volume` " +
                                            " FROM `tblholdings` AS h INNER JOIN `tblbookinfo` AS b ON h.ISBN = b.ISBN  WHERE h.status = 0 && `AccNum` IS NOT Null && `AccNum` <> ''; ";

                MySqlDataAdapter da = new MySqlDataAdapter(dbConnect.com);
                DataTable dt = new DataTable();
                try
                {
                    dbConnect.con.Open();
                    da.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                    bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    bunifuCustomDataGrid1.DataSource = dt;
                    bunifuCustomDataGrid1.Columns[0].HeaderText = "ACCESSION NUMBER";
                    bunifuCustomDataGrid1.Columns[1].HeaderText = "ISBN";
                    bunifuCustomDataGrid1.Columns[2].HeaderText = "TITLE";
                    bunifuCustomDataGrid1.Columns[3].HeaderText = "AUTHOR";
                    bunifuCustomDataGrid1.Columns[4].HeaderText = "CATEGORY";
                    bunifuCustomDataGrid1.Columns[5].HeaderText = "EDITION";
                    bunifuCustomDataGrid1.Columns[6].HeaderText = "VOLUME";
                    bunifuCustomDataGrid1.Columns[0].DefaultCellStyle.Format = "D5";
                    bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                finally
                { dbConnect.con.Close(); }
                return dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            save();
        }

        private void save()
        {
            txtAccNum.Visible = false;
            txtNumCopies.Enabled = true;
            txtNumCopies.BorderColorMouseHover = Color.FromArgb(251, 66, 72);
            txtNumCopies.BorderColorIdle = Color.Silver;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = true;
            btnDelete.Visible = false;
        }

        private void clearFields()
        {
            txtISBN.Text = "";
            txtNumCopies.Text = "";
            txtAccNum.Text = "";
        }

        private void tabHoldings_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbConnect.isOpen();
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                using (dbConnect.com = new MySqlCommand())
                {
                    dbConnect.com.Connection = dbConnect.con;
                    dbConnect.com.CommandType = CommandType.Text;
                    dbConnect.com.CommandText = "select * from tblHoldings where AccNum = @an";
                    dbConnect.com.Parameters.AddWithValue("@an", bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString());
                    sda = new MySqlDataAdapter(dbConnect.com);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    txtAccNum.Text = dt.Rows[0][0].ToString();
                    txtISBN.Text = dt.Rows[0][1].ToString();
                }

                txtAccNum.Visible = true;
                txtNumCopies.Enabled = false;
                txtNumCopies.BorderColorMouseHover = Color.Black;
                txtNumCopies.BorderColorIdle = Color.Black;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = true;
                btnCancel.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void updateData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "UPDATE `tblHoldings` SET `ISBN`= @isbn WHERE AccNum = @an;";
                dbConnect.com.Parameters.AddWithValue("@an", txtAccNum.Text);
                dbConnect.com.Parameters.AddWithValue("@isbn", txtISBN.Text);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Update Successful!");
                    clearFields();
                    GetData();
                    save();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {
            txtAccNum.TextChanged -= txtAccNum_TextChanged;
            string text = txtAccNum.Text.TrimStart('0');
            txtAccNum.Text = text.PadLeft(5, '0');
            txtAccNum.TextChanged += txtAccNum_TextChanged;
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            if (txtISBN.Text != "")
            {
                dbConnect.com = new MySqlCommand("SELECT * FROM `tblbookinfo` WHERE ISBN = @sn", dbConnect.con);
                dbConnect.com.Parameters.AddWithValue("@sn", txtISBN.Text);
                dbConnect.con.Open();
                int BookExist = Convert.ToInt32(dbConnect.com.ExecuteScalar());
                dbConnect.con.Close();
                if (BookExist <= 0)
                {
                    MessageBox.Show("Book with ISBN: " + txtISBN.Text + " does not exist.");
                    txtISBN.Focus();
                }
            }
        }

        private void tabHoldings_VisibleChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "UPDATE `tblHoldings` SET `status`= @s WHERE AccNum = @an;";
                dbConnect.com.Parameters.AddWithValue("@an", txtAccNum.Text);
                dbConnect.com.Parameters.AddWithValue("@s", 1);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Update Successful!");
                    clearFields();
                    GetData();
                    save();
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

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
            if (txtISBN.Text.Length > 11)
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtNumCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }
    }
}
