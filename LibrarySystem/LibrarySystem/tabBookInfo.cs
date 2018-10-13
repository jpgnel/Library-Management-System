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
    public partial class tabBookInfo : UserControl
    {
        string bid;
        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT `ISBN`, `Title`, `Author`, `Category`, `Publication`, `PublicationYear`, `Edition`, `Copyright`, `Volume`, `NumPages` FROM `tblbookinfo`", dbConnect.con);
        DataSet ds = new DataSet();

        public tabBookInfo()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            txtISBN.Text = "";
            txtAuthor.Text = "";
            txtTitle.Text = "";
            txtPublication.Text = "";
            txtPubYear.Text = "";
            txtEdition.Text = "";
            txtCopyright.Text = "";
            txtVolume.Text = "";
            txtNumPages.Text = "";
            txtCategory.Text = "";

            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnCancel.Visible = true;
        }

        private void bookData()
        {
            ds.Clear();
            sda.Fill(ds, "tblbookInfo");
            bunifuCustomDataGrid1.DataSource = ds.Tables["tblbookInfo"];
            bunifuCustomDataGrid1.Columns[0].HeaderText = "ISBN";
            bunifuCustomDataGrid1.Columns[1].HeaderText = "TITLE";
            bunifuCustomDataGrid1.Columns[2].HeaderText = "AUTHOR";
            bunifuCustomDataGrid1.Columns[3].HeaderText = "CATEGORY";
            bunifuCustomDataGrid1.Columns[4].HeaderText = "PUBLICATION";
            bunifuCustomDataGrid1.Columns[5].HeaderText = "PUBLICATION YEAR";
            bunifuCustomDataGrid1.Columns[6].HeaderText = "EDITION";
            bunifuCustomDataGrid1.Columns[7].HeaderText = "VOLUME";
            bunifuCustomDataGrid1.Columns[8].HeaderText = "COPYRIGHT";
            bunifuCustomDataGrid1.Columns[9].HeaderText = "NUMBER OF PAGES";
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            
            if (txtISBN.Text != "")
            {
                dbConnect.com = new MySqlCommand("SELECT * FROM `tblbookInfo` WHERE ISBN = @bn", dbConnect.con);
                dbConnect.com.Parameters.AddWithValue("@bn", txtISBN.Text);
                dbConnect.con.Open();
                int ISBNExist = Convert.ToInt32(dbConnect.com.ExecuteScalar());
                dbConnect.con.Close();
                if (ISBNExist > 0)
                {
                    MessageBox.Show("Book with ISBN "+ txtISBN.Text +" already exists.");
                    txtISBN.Focus();
                }
            }
        }

        private void tabBookInfo_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void insertData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "INSERT INTO `tblbookInfo`(`ISBN`, `Title`, `Author`, `Category`, `Publication`, `PublicationYear`, `Edition`, `Copyright`, `Volume`, `NumPages`)" +
                                        "VALUES (@bn,@t,@a,@ca,@pu,@py,@ed,@cr,@v,@np)";
                dbConnect.com.Parameters.AddWithValue("@bn", txtISBN.Text);
                dbConnect.com.Parameters.AddWithValue("@t", txtTitle.Text);
                dbConnect.com.Parameters.AddWithValue("@a", txtAuthor.Text);
                dbConnect.com.Parameters.AddWithValue("@ca", txtCategory.Text);
                dbConnect.com.Parameters.AddWithValue("@pu", txtPublication.Text);
                dbConnect.com.Parameters.AddWithValue("@py", txtPubYear.Text);
                dbConnect.com.Parameters.AddWithValue("@ed", txtEdition.Text);
                dbConnect.com.Parameters.AddWithValue("@cr", txtCopyright.Text);
                dbConnect.com.Parameters.AddWithValue("@v", txtVolume.Text);
                dbConnect.com.Parameters.AddWithValue("@np", txtNumPages.Text);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {

            }
            else
            {
                insertData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void updateData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "UPDATE `tblbookInfo` SET `ISBN` = @bn, `Title` = @t, `Author` = @a, `Category` = @ca, " +
                                            "`Publication` = @pu, `PublicationYear` = @py, `Edition` = @ed, " +
                                            "`Copyright` = @cr, `Volume` = @v, `NumPages` = @np WHERE `bookID` = @bid;";
                dbConnect.com.Parameters.AddWithValue("@bid", bid);
                dbConnect.com.Parameters.AddWithValue("@bn", txtISBN.Text);
                dbConnect.com.Parameters.AddWithValue("@t", txtTitle.Text);
                dbConnect.com.Parameters.AddWithValue("@a", txtAuthor.Text);
                dbConnect.com.Parameters.AddWithValue("@ca", txtCategory.Text);
                dbConnect.com.Parameters.AddWithValue("@pu", txtPublication.Text);
                dbConnect.com.Parameters.AddWithValue("@py", txtPubYear.Text);
                dbConnect.com.Parameters.AddWithValue("@ed", txtEdition.Text);
                dbConnect.com.Parameters.AddWithValue("@cr", txtCopyright.Text);
                dbConnect.com.Parameters.AddWithValue("@v", txtVolume.Text);
                dbConnect.com.Parameters.AddWithValue("@np", txtNumPages.Text);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Update Successful!");
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

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                using (dbConnect.com = new MySqlCommand())
                {
                    dbConnect.com.Connection = dbConnect.con;
                    dbConnect.com.CommandType = CommandType.Text;
                    dbConnect.com.CommandText = "select * from tblbookInfo where ISBN = @bn";
                    dbConnect.com.Parameters.AddWithValue("@bn", bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString());
                    sda = new MySqlDataAdapter(dbConnect.com);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    txtISBN.Text = dt.Rows[0][1].ToString();
                    txtTitle.Text = dt.Rows[0][2].ToString();
                    txtAuthor.Text = dt.Rows[0][3].ToString();
                    txtCategory.Text = dt.Rows[0][4].ToString();
                    txtPublication.Text = dt.Rows[0][5].ToString();
                    txtPubYear.Text = dt.Rows[0][6].ToString();
                    txtEdition.Text = dt.Rows[0][7].ToString();
                    txtCopyright.Text = dt.Rows[0][8].ToString();
                    txtVolume.Text = dt.Rows[0][9].ToString();
                    txtNumPages.Text = dt.Rows[0][10].ToString();
                    bid = dt.Rows[0][0].ToString();
                }

                btnUpdate.Visible = true;
                btnCancel.Visible = false;
                btnDelete.Visible = true;
                btnSave.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (dbConnect.com = new MySqlCommand())
                    {
                        dbConnect.com.Connection = dbConnect.con;
                        dbConnect.com.CommandText = "UPDATE `tblbookInfo` SET `status` = 1 WHERE `ISBN` = @bn;";
                        dbConnect.com.Parameters.AddWithValue("@bn", txtISBN.Text);
                        try
                        {
                            dbConnect.con.Open();
                            int recordsAffected = dbConnect.com.ExecuteNonQuery();
                            MessageBox.Show("Book Deleted!");
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clearFields();
            }
        }

        private void tabBookInfo_Leave(object sender, EventArgs e)
        {
            clearFields();
        }

        private void tabBookInfo_VisibleChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private DataTable GetData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "SELECT `ISBN`, `Title`, `Author`, `Category`, `Publication`, `PublicationYear`, `Edition`, "+
                                            "`Copyright`, `Volume`, `NumPages` FROM `tblbookinfo` WHERE `status` = 0;";

                MySqlDataAdapter da = new MySqlDataAdapter(dbConnect.com);
                DataTable dt = new DataTable();
                try
                {
                    dbConnect.con.Open();
                    da.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                    bunifuCustomDataGrid1.Columns[0].HeaderText = "ISBN";
                    bunifuCustomDataGrid1.Columns[1].HeaderText = "TITLE";
                    bunifuCustomDataGrid1.Columns[2].HeaderText = "AUTHOR";
                    bunifuCustomDataGrid1.Columns[3].HeaderText = "CATEGORY";
                    bunifuCustomDataGrid1.Columns[4].HeaderText = "PUBLICATION";
                    bunifuCustomDataGrid1.Columns[5].HeaderText = "PUBLICATION YEAR";
                    bunifuCustomDataGrid1.Columns[6].HeaderText = "EDITION";
                    bunifuCustomDataGrid1.Columns[7].HeaderText = "COPYRIGHT";
                    bunifuCustomDataGrid1.Columns[8].HeaderText = "VOLUME";
                    bunifuCustomDataGrid1.Columns[9].HeaderText = "NUMBER OF PAGES";
                    bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                finally
                { dbConnect.con.Close(); }
                return dt;
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
            if (txtISBN.Text.Length > 13)
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtPubYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtNumPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }
    }
}
