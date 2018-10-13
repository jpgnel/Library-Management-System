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
    public partial class tabBorrow : UserControl
    {

        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT `borrowID`,`accNum`,`studNum`, `borrowTime`, `dueTime`, `returnTime` FROM `tblBorrow` WHERE `status` = 0", dbConnect.con);
        DataSet ds = new DataSet();

        public tabBorrow()
        {
            InitializeComponent();
        }

        private void txtANum_Leave(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            if (txtANum.Text != "")
            {
                dbConnect.com = new MySqlCommand("SELECT * FROM `tblHoldings` WHERE AccNum = @sn", dbConnect.con);
                dbConnect.com.Parameters.AddWithValue("@sn", txtANum.Text);
                dbConnect.con.Open();
                int StudExist = Convert.ToInt32(dbConnect.com.ExecuteScalar());
                dbConnect.con.Close();
                if (StudExist <= 0)
                {
                    MessageBox.Show("Book with Accession Number: " + txtANum.Text + " doesn't exist.");
                    txtANum.Text = "";
                    txtANum.Focus();
                }
            }
            else
            {
                dbConnect.com = new MySqlCommand("SELECT * FROM `tblborrow` WHERE `status` = 1 && `accNum` = @an", dbConnect.con);
                dbConnect.com.Parameters.AddWithValue("@an", txtANum.Text);
                dbConnect.con.Open();
                int StudExist = Convert.ToInt32(dbConnect.com.ExecuteScalar());
                dbConnect.con.Close();
                if (StudExist > 0)
                {
                    MessageBox.Show("Book with Accession Number: " + txtANum.Text + " is still borrowed.");
                    txtANum.Text = "";
                    txtANum.Focus();
                }
            }
        }

        private void txtSNum_Leave(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            if (txtSNum.Text != "")
            {
                dbConnect.com = new MySqlCommand("SELECT * FROM `tblstudents` WHERE studentNo = @sn", dbConnect.con);
                dbConnect.com.Parameters.AddWithValue("@sn", txtSNum.Text);
                dbConnect.con.Open();
                int StudExist = Convert.ToInt32(dbConnect.com.ExecuteScalar());
                dbConnect.con.Close();
                if (StudExist <= 0)
                {
                    MessageBox.Show("Student with Student Number: " + txtSNum.Text + " does not exist.");
                    txtSNum.Focus();
                }
            }
        }

        private void tabBorrow_Load(object sender, EventArgs e)
        {
            GetData();

            DateTime today = DateTime.Now.ToLocalTime();

            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
            {
                if (today >= DateTime.Parse("6:00 PM") && today < DateTime.Parse("8:00 AM"))
                {
                    lblClose.Visible = true;
                    txtANum.Enabled = false;
                    txtSNum.Enabled = false;
                    txtBTime.Enabled = false;
                    txtDue.Enabled = false;
                }
                if (today.DayOfWeek != DayOfWeek.Friday)
                { 
                    if (today >= DateTime.Parse("5:30 PM") && today < DateTime.Parse("6:00 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddDays(1).ToString("08:00 'AM', MMM-dd-yyyy");
                    }
                    else if (today >= DateTime.Parse("8:00 AM") && today < DateTime.Parse("5:30 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddHours(2).ToString("hh:mm tt, MMM-dd-yyyy");
                    }
                }
                else
                {
                    if (today >= DateTime.Parse("4:30 PM") && today < DateTime.Parse("6:00 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddDays(3).ToString("08:00 'AM', MMM-dd-yyyy");
                    }
                    else if (today >= DateTime.Parse("8:00 AM") && today < DateTime.Parse("4:30 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddHours(2).ToString("hh:mm tt, MMM-dd-yyyy");
                    }
                }
            }
            else
            {
                lblClose.Visible = true;
                txtANum.Enabled = false;
                txtSNum.Enabled = false;
                txtBTime.Enabled = false;
                txtDue.Enabled = false;
            }
            
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void insertData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "INSERT INTO `tblBorrow`(`accNum`,`studNum`, `borrowTime`, `dueTime`, `status`)" +
                                        "VALUES (@an,@sn,@bt,@dt,@s)";
                dbConnect.com.Parameters.AddWithValue("@an", txtANum.Text);
                dbConnect.com.Parameters.AddWithValue("@sn", txtSNum.Text);
                dbConnect.com.Parameters.AddWithValue("@bt", txtBTime.Text);
                dbConnect.com.Parameters.AddWithValue("@dt", txtDue.Text);
                dbConnect.com.Parameters.AddWithValue("@s", 0);
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
            txtANum.Text = "";
            txtSNum.Text = "";
            txtReturnTime.Text = "";
             
        }

        //private void h()
        //{
        //    ds.Clear();
        //    sda.Fill(ds, "tblBorrow");
        //    bunifuCustomDataGrid1.DataSource = ds.Tables["tblBorrow"];
        //    bunifuCustomDataGrid1.Columns[0].HeaderText = "TRANSACTION ID";
        //    bunifuCustomDataGrid1.Columns[1].HeaderText = "ACCESSION NUMBER";
        //    bunifuCustomDataGrid1.Columns[2].HeaderText = "STUDENT NUMBER";
        //    bunifuCustomDataGrid1.Columns[3].HeaderText = "BORROW TIME";
        //    bunifuCustomDataGrid1.Columns[4].HeaderText = "DUE TIME";
        //    bunifuCustomDataGrid1.Columns[5].HeaderText = "RETURN TIME";
        //    bunifuCustomDataGrid1.Columns[1].DefaultCellStyle.Format = "D5";
        //    bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //}

        string bid;

        private void updateData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "UPDATE `tblBorrow` SET `returnTime`= @rt, `status`= @s  WHERE `borrowID` = @bid;";
                dbConnect.com.Parameters.AddWithValue("@bid", bid);
                dbConnect.com.Parameters.AddWithValue("@rt", txtReturnTime.Text);
                dbConnect.com.Parameters.AddWithValue("@s", 1);
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

        bool cellClick = false;

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellClick = true;
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                using (dbConnect.com = new MySqlCommand())
                {
                    dbConnect.com.Connection = dbConnect.con;
                    dbConnect.com.CommandType = CommandType.Text;
                    dbConnect.com.CommandText = "select * from tblBorrow where borrowID = @bid";
                    dbConnect.com.Parameters.AddWithValue("@bid", bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString());
                    sda = new MySqlDataAdapter(dbConnect.com);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    txtANum.Text = dt.Rows[0][1].ToString();
                    txtSNum.Text = dt.Rows[0][2].ToString();
                    txtBTime.Text = dt.Rows[0][3].ToString();
                    txtDue.Text = dt.Rows[0][4].ToString();
                    txtReturnTime.Text = txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                    lblReturn.Visible = true;
                    bid = dt.Rows[0][0].ToString();
                }

                txtReturnTime.Visible = true;
                btnReturn.Visible = true;
                btnBorrow.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            updateData();
            clearFields();
            btnBorrow.Visible = true;
            btnReturn.Visible = false;
            txtReturnTime.Visible = false;
            lblReturn.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel transaction?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clearFields();
                btnBorrow.Visible = true;
                btnReturn.Visible = false;
                txtReturnTime.Visible = false;
                lblReturn.Visible = false;
            }
        }

        private void tabBorrow_Leave(object sender, EventArgs e)
        {
            clearFields();
        }

        private DataTable GetData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "SELECT b.borrowID, h.AccNum, h.ISBN, i.Title, i.Author, b.studNum, s.LastName, s.FirstName, s.course_track, s.year_section, " + 
                                            "b.borrowTime, b.dueTime, b.returnTime " +
                                            "FROM `tblBorrow` AS b " +
                                            "INNER JOIN `tblHoldings` AS h ON b.accNum = h.AccNum " +
                                            "INNER JOIN `tblBookInfo` AS i ON h.ISBN = i.ISBN " + 
                                            "INNER JOIN `tblStudents` AS s ON b.studNum = s.studentNo; ";

                MySqlDataAdapter da = new MySqlDataAdapter(dbConnect.com);
                DataTable dt = new DataTable();
                try
                {
                    dbConnect.con.Open();
                    da.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                    bunifuCustomDataGrid1.DataSource = dt;
                    bunifuCustomDataGrid1.Columns[0].HeaderText = "Borrow ID";
                    bunifuCustomDataGrid1.Columns[1].HeaderText = "ACCESSION NUMBER";
                    bunifuCustomDataGrid1.Columns[2].HeaderText = "ISBN";
                    bunifuCustomDataGrid1.Columns[3].HeaderText = "TITLE";
                    bunifuCustomDataGrid1.Columns[4].HeaderText = "AUTHOR";
                    bunifuCustomDataGrid1.Columns[5].HeaderText = "STUDENT NUMBER";
                    bunifuCustomDataGrid1.Columns[6].HeaderText = "LAST NAME";
                    bunifuCustomDataGrid1.Columns[7].HeaderText = "FIRST NAME";
                    bunifuCustomDataGrid1.Columns[8].HeaderText = "COURSE/TRACK";
                    bunifuCustomDataGrid1.Columns[9].HeaderText = "YEAR-SECTION";
                    bunifuCustomDataGrid1.Columns[10].HeaderText = "BORROW TIME";
                    bunifuCustomDataGrid1.Columns[11].HeaderText = "DUE TIME";
                    bunifuCustomDataGrid1.Columns[12].HeaderText = "RETURN TIME";
                    bunifuCustomDataGrid1.Columns[0].DefaultCellStyle.Format = "D5";
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

        private void tabBorrow_VisibleChanged(object sender, EventArgs e)
        {
            GetData();

            DateTime today = DateTime.Now.ToLocalTime();

            if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
            {
                if (today >= DateTime.Parse("6:00 PM") && today < DateTime.Parse("8:00 AM"))
                {
                    lblClose.Visible = true;
                    txtANum.Enabled = false;
                    txtSNum.Enabled = false;
                    txtBTime.Enabled = false;
                    txtDue.Enabled = false;
                }
                if (today.DayOfWeek != DayOfWeek.Friday)
                {
                    if (today >= DateTime.Parse("5:30 PM") && today < DateTime.Parse("6:00 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddDays(1).ToString("08:00 'AM', MMM-dd-yyyy");
                    }
                    else if (today >= DateTime.Parse("8:00 AM") && today < DateTime.Parse("5:30 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddHours(2).ToString("hh:mm tt, MMM-dd-yyyy");
                    }
                }
                else
                {
                    if (today >= DateTime.Parse("4:30 PM") && today < DateTime.Parse("6:00 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddDays(3).ToString("08:00 'AM', MMM-dd-yyyy");
                    }
                    else if (today >= DateTime.Parse("8:00 AM") && today < DateTime.Parse("4:30 PM"))
                    {
                        txtANum.Enabled = true;
                        txtSNum.Enabled = true;
                        txtBTime.Enabled = true;
                        txtDue.Enabled = true;
                        txtBTime.Text = DateTime.Now.ToString("hh:mm tt, MMM-dd-yyyy");
                        txtDue.Text = DateTime.Now.AddHours(2).ToString("hh:mm tt, MMM-dd-yyyy");
                    }
                }
            }
            else
            {
                lblClose.Visible = true;
                txtANum.Enabled = false;
                txtSNum.Enabled = false;
                txtBTime.Enabled = false;
                txtDue.Enabled = false;
            }

        }

        private void txtANum_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtANum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtSNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
            if (txtSNum.Text.Length > 10)
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void bunifuCustomDataGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.bunifuCustomDataGrid1.Rows)
            {
                    if (rw.Cells[11].Value == null && rw.Cells[11].Value == DBNull.Value && (String.IsNullOrWhiteSpace(rw.Cells[11].Value.ToString())) && DateTime.Parse(rw.Cells[11].Value.ToString()) < DateTime.Today)
                    {
                        rw.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if(rw.Cells[11].Value == null || rw.Cells[11].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[11].Value.ToString()))
                    {
                        rw.DefaultCellStyle.BackColor = Color.Green;
                    }
            }
        }
    }
}
