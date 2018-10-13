using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class tabBooks : UserControl
    {
        public tabBooks()
        {
            InitializeComponent();
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            tabBookInfo1.Show();
            tabHoldings1.Hide();
        }

        private void btnHoldings_Click(object sender, EventArgs e)
        {
            tabBookInfo1.Hide();
            tabHoldings1.Show();
        }

        private void tabHoldings1_Load(object sender, EventArgs e)
        {

        }

        private void tabBooks_Load(object sender, EventArgs e)
        {
            tabBookInfo1.Show();
            tabHoldings1.Hide();
        }
    }
}
