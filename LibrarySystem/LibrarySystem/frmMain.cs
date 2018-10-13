using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin loginFrm = new frmLogin();
            loginFrm.Show();
            this.Close();
        }

        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            tabStudentInfo1.Enabled = false;
            tabStudentInfo1.Hide();
            tabBorrow1.Hide();
            tabBorrow1.Enabled = false;
            tabBooks1.Show();
            tabBooks1.Enabled = true;
            tabReports1.Enabled = false;
            tabReports1.Hide();
            tabLibrarian1.Hide();
            tabLibrarian1.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(frmLogin.lvl != 0)
            {
                btnLibrarian.Visible = false;
            }
            timer1.Start();
            tabStudentInfo1.Hide();
            tabStudentInfo1.Enabled = false;
            tabBorrow1.Hide();
            tabBorrow1.Enabled = false;
            tabBooks1.Show();
            tabReports1.Hide();
            tabReports1.Enabled = false;
            tabLibrarian1.Hide();
            tabLibrarian1.Enabled = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            tabStudentInfo1.Enabled = true;
            tabStudentInfo1.Show();
            tabBorrow1.Hide();
            tabBorrow1.Enabled = false;
            tabBooks1.Hide();
            tabBooks1.Enabled = false;
            tabReports1.Enabled = false;
            tabReports1.Hide();
            tabLibrarian1.Hide();
            tabLibrarian1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <= 100)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            tabAttendance att = new tabAttendance();
            att.ShowDialog();
        }

        private void btnBorrowRecords_Click(object sender, EventArgs e)
        {
            tabStudentInfo1.Enabled = false;
            tabStudentInfo1.Hide();
            tabBorrow1.Show();
            tabBorrow1.Enabled = true;
            tabBooks1.Hide();
            tabBooks1.Enabled = false;
            tabReports1.Enabled = false;
            tabReports1.Hide();
            tabLibrarian1.Hide();
            tabLibrarian1.Enabled = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmUserAccount ua = new frmUserAccount();
            ua.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabStudentInfo1.Enabled = false;
            tabStudentInfo1.Hide();
            tabBorrow1.Hide();
            tabBorrow1.Enabled = false;
            tabBooks1.Hide();
            tabBooks1.Enabled = false;
            tabReports1.Show();
            tabReports1.Enabled = true;
            tabLibrarian1.Hide();
            tabLibrarian1.Enabled = false;
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            tabLibrarian1.Show();
            tabLibrarian1.Enabled = true;
            tabStudentInfo1.Enabled = false;
            tabStudentInfo1.Hide();
            tabBorrow1.Hide();
            tabBorrow1.Enabled = false;
            tabBooks1.Hide();
            tabBooks1.Enabled = false;
            tabReports1.Hide();
            tabReports1.Enabled = false;
        }
    }
}
