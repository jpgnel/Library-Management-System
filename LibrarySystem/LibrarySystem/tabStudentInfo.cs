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
using ZXing;
using ZXing.QrCode;
using Zen.Barcode;
using System.IO;

namespace LibrarySystem
{
    public partial class tabStudentInfo : UserControl
    {
        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT `studentNo`, `lastName`, `firstName`, `middleName`, `course_track`, `year_section`, `contactNo`, `emailAdd` FROM `tblstudents`", dbConnect.con);
        DataSet ds = new DataSet();
        byte[] qrCode, data;
        string ct;
        string sid;

        public tabStudentInfo()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            try
            {
                if(txtStudentNumber.Text == "" || txtLastName.Text == "" || txtFirstName.Text == "" || txtYrSec.Text == "" || txtContactNo.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Please don't leave a field blank.");
                }
                else
                {
                    l = cbEducLevel.selectedIndex;
                    switch (l)
                    {
                        case 0:
                            level = "College";
                            break;
                        case 1:
                            level = "Senior High School";
                            break;
                    }
                    if (level == "College")
                    {
                        cbTrack.Visible = false;
                        lblTrack.Visible = false;
                        cbCourse.Visible = true;
                        lblCourse.Visible = true;
                        c = cbCourse.selectedIndex;
                        switch (c)
                        {
                            case 0:
                                cstr = "BSIT";
                                break;
                            case 1:
                                cstr = "BSBM";
                                break;
                            case 2:
                                cstr = "BSHRM";
                                break;
                            case 3:
                                cstr = "BSTM";
                                break;
                        }
                       
                    }
                    else if (level == "Senior High School")
                    {
                        cbCourse.Visible = false;
                        lblCourse.Visible = false;
                        cbTrack.Visible = true;
                        lblTrack.Visible = true;
                        c = cbTrack.selectedIndex;
                        switch (c)
                        {
                            case 0:
                                cstr = "ICT";
                                break;
                            case 1:
                                cstr = "ABM";
                                break;
                            case 2:
                                cstr = "STEM";
                                break;
                            case 3:
                                cstr = "HUMMS";
                                break;
                            case 4:
                                cstr = "TECVOC";
                                break;
                        }
                       
                    }
                    ImageConverter imgConverter = new ImageConverter();
                    qrCode = (System.Byte[])imgConverter.ConvertTo(pbQR.Image, Type.GetType("System.Byte[]"));

                    insertData();
                    GetData();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void insertData()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "INSERT INTO `tblstudents`(`studentNo`, `lastName`, `firstName`, `middleName`, `educLevel`, `course_track`, `year_section`, `contactNo`, `emailAdd`, `qrCode`, `status`)" +
                                        "VALUES (@sn,@ln,@fn,@mn,@el,@ct,@ys,@cn,@ea,@qr,@st)";
                dbConnect.com.Parameters.AddWithValue("@sn", txtStudentNumber.Text);
                dbConnect.com.Parameters.AddWithValue("@ln", txtLastName.Text);
                dbConnect.com.Parameters.AddWithValue("@fn", txtFirstName.Text);
                dbConnect.com.Parameters.AddWithValue("@mn", txtMiddleName.Text);
                dbConnect.com.Parameters.AddWithValue("@el", level);
                dbConnect.com.Parameters.AddWithValue("@ct", cstr);
                dbConnect.com.Parameters.AddWithValue("@ys", txtYrSec.Text);
                dbConnect.com.Parameters.AddWithValue("@cn", txtContactNo.Text);
                dbConnect.com.Parameters.AddWithValue("@ea", txtEmail.Text);
                dbConnect.com.Parameters.AddWithValue("@qr", qrCode);
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
            txtStudentNumber.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            cbEducLevel.ResetText();
            cbCourse.ResetText();
            cbTrack.ResetText();
            txtMiddleName.Text = "";
            txtYrSec.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            pbQR.Image = pbQR.InitialImage;
            //pbImage.Image = pbImage.InitialImage;

            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            bunifuImageButton3.Visible = false;
        }

        private void h()
        {
            ds.Clear();
            sda.Fill(ds, "tblStudents");
            bunifuCustomDataGrid1.DataSource = ds.Tables["tblStudents"];
            bunifuCustomDataGrid1.Columns[0].HeaderText = "STUDENT NUMBER";
            bunifuCustomDataGrid1.Columns[1].HeaderText = "LAST NAME";
            bunifuCustomDataGrid1.Columns[2].HeaderText = "FIRST NAME";
            bunifuCustomDataGrid1.Columns[3].HeaderText = "MIDDLE NAME";
            bunifuCustomDataGrid1.Columns[4].HeaderText = "COURSE/TRACK";
            bunifuCustomDataGrid1.Columns[5].HeaderText = "YEAR AND SECTION";
            bunifuCustomDataGrid1.Columns[6].HeaderText = "CONTACT #";
            bunifuCustomDataGrid1.Columns[7].HeaderText = "EMAIL ADDRESS";
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }

            if (txtStudentNumber.Text.Length > 11)
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtStudentNumber_Leave(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            if (txtStudentNumber.Text != "")
            {
                using (MySqlConnection con = new MySqlConnection("datasource=127.0.0.1; port = 3306;username = root; password=; database=dbLibrary; convert zero datetime=True;"))
                {
                    using (MySqlCommand com = new MySqlCommand())
                    {
                        com.Connection = con;
                        com.CommandType = CommandType.Text;
                        com.CommandText = "SELECT * FROM `tblstudents` WHERE studentNo = @sn";
                        com.Parameters.AddWithValue("@sn", txtStudentNumber.Text);

                        try
                        {
                            con.Open();
                            MySqlDataReader sdr = com.ExecuteReader();
                            if(sdr.Read() == true) {
                                if (sdr.GetInt32(13) == 0)
                                {
                                    MessageBox.Show("Student already exists.");
                                    txtStudentNumber.Focus();
                                }
                            }
                            else
                            {
                                QrCodeEncodingOptions options = new QrCodeEncodingOptions
                                {
                                    DisableECI = true,
                                    CharacterSet = "UTF-8",
                                    Width = 500,
                                    Height = 500,
                                    Margin = 0
                                };
                                var qr = new ZXing.BarcodeWriter();
                                qr.Options = options;
                                qr.Format = ZXing.BarcodeFormat.QR_CODE;
                                var result = new Bitmap(qr.Write(txtStudentNumber.Text));
                                pbQR.Image = result;
                                //CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
                                //pbQR.Image = qrcode.Draw(txtStudentNumber.Text, 500);

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
        }

        private void tabStudentInfo_Load(object sender, EventArgs e)
        {
            
            GetData();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            //if (txtLastName.Text == "")
            //{
            //    MessageBox.Show("Please don't leave Last Name field blank.");
            //    txtLastName.Focus();
            //}
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            //if (txtFirstName.Text == "")
            //{
            //    MessageBox.Show("Please don't leave First Name field blank.");
            //    txtFirstName.Focus();
            //}
        }

        private void txtContactNo_Leave(object sender, EventArgs e)
        {
            //if (txtContactNo.Text == "")
            //{
            //    MessageBox.Show("Please don't leave Contact Number field blank.");
            //    txtContactNo.Focus();
            //}
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //if (txtEmail.Text == "")
            //{
            //    MessageBox.Show("Please don't leave Email Address field blank.");
            //    txtContactNo.Focus();
            //}
            //else
            //{
                //try
                //{
                //    var eMailValidator = new System.Net.Mail.MailAddress(txtEmail.Text);
                //}
                //catch (System.FormatException ex)
                //{
                //    MessageBox.Show("Invalid E-mail Address!");
                //    txtEmail.Focus();
                //}
            //}
            
        }

        private void cbEducLevel_onItemSelected(object sender, EventArgs e)
        {
            if(cbEducLevel.selectedIndex == 0)
            {
                cbCourse.Visible = true;
                lblCourse.Visible = true;
                cbTrack.Visible = false;
                lblTrack.Visible = false;
                ct = cbCourse.selectedValue;
            }
            if(cbEducLevel.selectedIndex == 1)
            {
                cbCourse.Visible = false;
                lblCourse.Visible = false;
                cbTrack.Visible = true;
                lblTrack.Visible = true ;
                ct = cbTrack.selectedValue;
            }
        }

        private void txtStudentNumber_OnValueChanged(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            //ds.Tables["tblStudents"].DefaultView.RowFilter = "Convert(studentNo, 'System.String')like '" + txtStudentNumber.Text + "%'";
            //bunifuCustomDataGrid1.DataSource = ds.Tables["tblStudents"].DefaultView;
            //bunifuCustomDataGrid1.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }

        int c;
        string cstr;
        string level;
        int l;

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbConnect.isOpen();
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                try
                {
                    using (dbConnect.com = new MySqlCommand())
                    {
                        dbConnect.com.Connection = dbConnect.con;
                        dbConnect.com.CommandType = CommandType.Text;
                        dbConnect.com.CommandText = "select * from tblStudents where studentNo = @sn";
                        dbConnect.com.Parameters.AddWithValue("@sn", bunifuCustomDataGrid1.SelectedRows[0].Cells[0].Value.ToString());
                        sda = new MySqlDataAdapter(dbConnect.com);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        txtStudentNumber.Text = dt.Rows[0][1].ToString();
                        txtLastName.Text = dt.Rows[0][2].ToString();
                        txtFirstName.Text = dt.Rows[0][3].ToString();
                        txtMiddleName.Text = dt.Rows[0][4].ToString();
                        
                        cbEducLevel.Text = dt.Rows[0][5].ToString();
                        level = dt.Rows[0][5].ToString();

                        if (level == "College")
                        {
                            cbTrack.Visible = false;
                            lblTrack.Visible = false;
                            cbCourse.Visible = true;
                            lblCourse.Visible = true;
                            //c = cbCourse.selectedIndex;
                            //switch (c)
                            //{
                            //    case 0: cstr = "BSIT";
                            //        break;
                            //    case 1: cstr = "BSBM";
                            //        break;
                            //    case 2: cstr = "BSHRM";
                            //        break;
                            //    case 3: cstr = "BSTM";
                            //        break;
                            //}
                            cbCourse.Text = dt.Rows[0][6].ToString();
                            cstr = dt.Rows[0][6].ToString();
                        }
                        else if (level == "Senior High School")
                        {
                            cbCourse.Visible = false;
                            lblCourse.Visible = false;
                            cbTrack.Visible = true;
                            lblTrack.Visible = true;
                            //c = cbTrack.selectedIndex;
                            //switch (c)
                            //{
                            //    case 0: cstr = "ICT";
                            //        break;
                            //    case 1: cstr = "ABM";
                            //        break;
                            //    case 2: cstr = "STEM";
                            //        break;
                            //    case 3: cstr = "HUMMS";
                            //        break;
                            //    case 4: cstr = "TECVOC";
                            //        break;
                            //}
                            cbTrack.Text = dt.Rows[0][6].ToString();
                            cstr = dt.Rows[0][6].ToString();
                        }
                        txtYrSec.Text = dt.Rows[0][7].ToString();
                        txtContactNo.Text = dt.Rows[0][8].ToString();
                        txtEmail.Text = dt.Rows[0][9].ToString();
                        if (dt.Rows[0][10] != DBNull.Value)
                        {
                            pbQR.Image = byteArrayToImage((byte[])dt.Rows[0][10]);
                        }

                        sid = dt.Rows[0][0].ToString();
                    }

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

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            var imageConverter = new System.Drawing.ImageConverter();
            return imageConverter.ConvertFrom(byteArrayIn) as System.Drawing.Image;
        }

        private void txtYrSec_Leave(object sender, EventArgs e)
        {
            //if (txtYrSec.Text == "")
            //{
            //    MessageBox.Show("Please don't leave Year and Section field blank.");
            //    txtYrSec.Focus();
            //}
        }

        private void btnLibCard_Click(object sender, EventArgs e)
        {
            string mName = "";
            if(txtStudentNumber.Text != "")
            {
                if(txtMiddleName.Text != "")
                {
                    mName = txtMiddleName.Text;
                    mName = mName[0] + "."; 
                }
                
                frmLibraryCard lc = new frmLibraryCard();

                lc.sNum = txtStudentNumber.Text;
                lc.ln = txtLastName.Text;
                lc.fn = txtFirstName.Text;
                lc.mn = mName;
                lc.el = level;
                lc.ct = cstr;
                lc.yr = txtYrSec.Text;
                lc.cn = txtContactNo.Text;
                lc.em = txtEmail.Text;
                lc.qr = pbQR.Image;

                lc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a student first.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            updateData();
        }

        private void updateData()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandText = "UPDATE `tblstudents` SET `studentNo`= @sn, `lastName`= @ln,`firstName`= @fn,`middleName`= @mn," +
                                            "`educLevel`= @el,`course_track`= @ct,`year_section`= @ys,`contactNo` = @cn," +
                                            "`emailAdd`= @ea, `qrCode` = @qr WHERE studentID = @si;";
                dbConnect.com.Parameters.AddWithValue("@si", sid);
                dbConnect.com.Parameters.AddWithValue("@sn", txtStudentNumber.Text);
                dbConnect.com.Parameters.AddWithValue("@ln", txtLastName.Text);
                dbConnect.com.Parameters.AddWithValue("@fn", txtFirstName.Text);
                dbConnect.com.Parameters.AddWithValue("@mn", txtMiddleName.Text);
                dbConnect.com.Parameters.AddWithValue("@el", level);
                dbConnect.com.Parameters.AddWithValue("@ct", ct);
                dbConnect.com.Parameters.AddWithValue("@ys", txtYrSec.Text);
                dbConnect.com.Parameters.AddWithValue("@cn", txtContactNo.Text);
                dbConnect.com.Parameters.AddWithValue("@ea", txtEmail.Text);
                dbConnect.com.Parameters.AddWithValue("@qr", qrCode);
                try
                {
                    dbConnect.con.Open();
                    int recordsAffected = dbConnect.com.ExecuteNonQuery();
                    MessageBox.Show("Update Successful!");
                    clearFields();
                    GetData();
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            dbConnect.isOpen();
            if (bunifuCustomDataGrid1.Rows.Count > 1 && bunifuCustomDataGrid1.SelectedRows[0].Index != bunifuCustomDataGrid1.Rows.Count - 1)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (dbConnect.com = new MySqlCommand())
                    {
                        dbConnect.com.Connection = dbConnect.con;
                        dbConnect.com.CommandText = "UPDATE `tblstudents` SET `status`= 1 WHERE `studentNo` = @sn;";
                        dbConnect.com.Parameters.AddWithValue("@sn", txtStudentNumber.Text);
                        try
                        {
                            dbConnect.con.Open();
                            int recordsAffected = dbConnect.com.ExecuteNonQuery();
                            MessageBox.Show("Student Deleted!");
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

        //Boolean chosePhoto = false;

        private void panel1_Leave(object sender, EventArgs e)
        {

        }

        private void tabStudentInfo_Leave(object sender, EventArgs e)
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

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar)))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is illegal.
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {

        }

        //private void btnChooseImage_Click(object sender, EventArgs e)
        ////{
        ////    chosePhoto = true;
        ////    OpenFileDialog open = new OpenFileDialog();
        ////    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        ////    if (open.ShowDialog() == DialogResult.OK)
        ////    {
        ////        pbImage.Image = new Bitmap(open.FileName);
        ////        Image image = Image.FromFile(open.FileName);

        ////        ImageConverter imgConverter = new ImageConverter();
        ////        data = (System.Byte[])imgConverter.ConvertTo(pbImage.Image, Type.GetType("System.Byte[]"));
        ////    }
        //}

        private DataTable GetData()
        {
            dbConnect.isOpen();
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "SELECT `studentNo`, `lastName`, `firstName`, `middleName`, `educLevel`, "+
                                            "`course_track`, `year_section`, `contactNo`, `emailAdd` FROM `tblstudents` WHERE `status` = 0;";

                MySqlDataAdapter da = new MySqlDataAdapter(dbConnect.com);
                DataTable dt = new DataTable();
                try
                {
                    dbConnect.con.Open();
                    da.Fill(dt);
                    bunifuCustomDataGrid1.DataSource = dt;
                    bunifuCustomDataGrid1.Columns[0].HeaderText = "STUDENT NUMBER";
                    bunifuCustomDataGrid1.Columns[1].HeaderText = "LAST NAME";
                    bunifuCustomDataGrid1.Columns[2].HeaderText = "FIRST NAME";
                    bunifuCustomDataGrid1.Columns[3].HeaderText = "MIDDLE NAME";
                    bunifuCustomDataGrid1.Columns[4].HeaderText = "LEVEL";
                    bunifuCustomDataGrid1.Columns[5].HeaderText = "COURSE/TRACK";
                    bunifuCustomDataGrid1.Columns[6].HeaderText = "YEAR-SECTION";
                    bunifuCustomDataGrid1.Columns[7].HeaderText = "CONTACT NO.";
                    bunifuCustomDataGrid1.Columns[8].HeaderText = "EMAIL ADDRESS";
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
    }
}

