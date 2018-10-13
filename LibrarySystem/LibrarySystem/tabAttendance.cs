using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using Zen.Barcode;
using ZXing.QrCode;
using ZXing;
using MySql.Data.MySqlClient;
using System.IO;

namespace LibrarySystem
{
    public partial class tabAttendance : Form
    {
        MySqlDataAdapter sda = new MySqlDataAdapter();

        DataSet ds = new DataSet();

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        public tabAttendance()
        {
            InitializeComponent();
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pictureBox1.Image = null;
            if (dbConnect.con != null && dbConnect.con.State == ConnectionState.Open)
            {
                dbConnect.con.Close();
            }
            this.Close();
        }

        private void tabAttendance_Load(object sender, EventArgs e)
        {
            btnIN.Visible = false;
            btnOUT.Visible = false;
            timer1.Start();
            DgInfo();
            lblDate.Text = DateTime.Now.ToString("ddd, MM-dd-yyyy");
            lblTime.Text = DateTime.Now.ToString("hh : mm tt");

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo a in fic)
            {
                comboBox1.Items.Add(a.Name);
            }

            comboBox1.SelectedIndex = 0;

            vcd = new VideoCaptureDevice(fic[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer2.Enabled = true;
            timer2.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();

            }
            catch (Exception ex)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh : mm tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            BarcodeReader read = new BarcodeReader();
            if (pictureBox1.Image != null)
            {
                Result res = read.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    lblSNum.Text = res.ToString();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable GetDataTable()
        {
            using (dbConnect.com = new MySqlCommand())
            {
                dbConnect.com.Connection = dbConnect.con;            // <== lacking
                dbConnect.com.CommandType = CommandType.Text;
                dbConnect.com.CommandText = "SELECT l.`timeIn`, s.studentNo, s.lastName, s.firstName, s.middleName, s.educLevel, l.`timeOut` FROM `tblLogs` as l inner JOIN tblstudents as s on l.studentNo = s.studentNo where l.dateNow = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(dbConnect.com);
                dbConnect.con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dbConnect.con.Close();
                return dt;
            }
        }

        private void DgInfo()
        {
            dgv1.DataSource = GetDataTable();
            dgv1.Columns[0].HeaderText = "TIME IN";
            dgv1.Columns[1].HeaderText = "STUDENT NUMBER";
            dgv1.Columns[2].HeaderText = "LAST NAME";
            dgv1.Columns[3].HeaderText = "FIRST NAME";
            dgv1.Columns[4].HeaderText = "MIDDLE NAME";
            dgv1.Columns[5].HeaderText = "LEVEL";
            dgv1.Columns[6].HeaderText = "TIME-OUT";
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void lblSNum_TextChanged(object sender, EventArgs e)
        {
            timer3.Start();
            if (lblSNum.Text != "")
            {
                using (dbConnect.com = new MySqlCommand())
                {
                    dbConnect.com.Connection = dbConnect.con;
                    dbConnect.com.CommandType = CommandType.Text;
                    dbConnect.com.CommandText = "SELECT* FROM `tblstudents` WHERE studentNo = @sn;";
                    dbConnect.com.Parameters.AddWithValue("@sn", lblSNum.Text);

                    try
                    {
                        dbConnect.con.Open();
                        MySqlDataReader sdr = dbConnect.com.ExecuteReader();
                        Boolean sdread = sdr.Read();
                        dbConnect.con.Close();
                        if (sdread)
                        {
                            //lblStNum.Text = lblSNum.Text;
                            sda = new MySqlDataAdapter(dbConnect.com);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            lblSNum.Visible = true;
                            lblName.Text = dt.Rows[0][2].ToString() + ", " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString();
                            lblCT.Text = dt.Rows[0][5].ToString();
                            lblYS.Text = dt.Rows[0][6].ToString();
                            //if (dt.Rows[0][13] != DBNull.Value)
                            //{
                            //    byte[] image = (byte[])dt.Rows[0][13];
                            //    MemoryStream ms = new MemoryStream(image);
                            //    pbImage.Image = Image.FromStream(ms);
                            //}

                            dbConnect.com = new MySqlCommand("SELECT * FROM `tbllogs` WHERE `studentNo` = @sn && `dateNow` = @dn && `timeOut` IS NULL OR `timeOut` = ''", dbConnect.con);
                            dbConnect.com.Parameters.AddWithValue("@sn", lblSNum.Text);
                            dbConnect.com.Parameters.AddWithValue("@dn", DateTime.Now.ToString("yyyy-MM-dd"));
                            dbConnect.com.Parameters.AddWithValue("@to", DateTime.Now.ToString("hh:mm"));
                            dbConnect.con.Open();
                            int StudExist = Convert.ToInt32(dbConnect.com.ExecuteScalar());
                            dbConnect.con.Close();
                            if (StudExist <= 0)
                            {
                                using (dbConnect.com = new MySqlCommand())
                                {
                                    dbConnect.com.Connection = dbConnect.con;
                                    dbConnect.com.CommandText = "INSERT INTO `tblLogs`(`studentNo`, `dateNow`, `timeIn`) VALUES (@sn,@d,@ti)";
                                    dbConnect.com.Parameters.AddWithValue("@sn", lblSNum.Text);
                                    dbConnect.com.Parameters.AddWithValue("@d", DateTime.Now.ToString("yyyy-MM-dd"));
                                    dbConnect.com.Parameters.AddWithValue("@ti", DateTime.Now.ToString("hh:mm"));
                                    try
                                    {
                                        dbConnect.con.Open();
                                        int recordsAffected = dbConnect.com.ExecuteNonQuery();
                                        AutoClosingMessageBox.Show("Welcome to the library!", "Logged-in!", 1500);
                                        dbConnect.con.Close();

                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            else if (StudExist > 0)
                            {
                                using (dbConnect.com = new MySqlCommand())
                                {
                                    dbConnect.com.Connection = dbConnect.con;
                                    dbConnect.com.CommandText = "UPDATE `tbllogs` SET `timeOut`= @to WHERE `studentNo` = @sn && `dateNow` = @dn && `timeOut` IS NULL OR `timeOut` = ''";
                                    dbConnect.com.Parameters.AddWithValue("@sn", lblSNum.Text);
                                    dbConnect.com.Parameters.AddWithValue("@dn", DateTime.Now.ToString("yyyy-MM-dd"));
                                    dbConnect.com.Parameters.AddWithValue("@to", DateTime.Now.ToString("hh:mm"));
                                    try
                                    {
                                        dbConnect.con.Open();
                                        int recordsAffected = dbConnect.com.ExecuteNonQuery();
                                        AutoClosingMessageBox.Show("Thank you for visiting the library!", "Logged-out!", 1500);
                                        dbConnect.con.Close();

                                    }
                                    catch (MySqlException ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            

                        }
                        else
                        {
                            AutoClosingMessageBox.Show("Unrecognized Student Number!", "Error!", 1500);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            lblSNum.Text = "";
            DgInfo();
        }

        private void txtSNum_Enter(object sender, EventArgs e)
        {
            //btnIN.Visible = true;
            //btnOUT.Visible = true;
            this.AcceptButton = this.button1;
        }

        private void txtSNum_Leave(object sender, EventArgs e)
        {
            //btnIN.Visible = false;
            //btnOUT.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSNum.Text = txtSNum.Text;
        }
    }
}
