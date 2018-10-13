using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmLibraryCard : Form
    {
        public string sNum;
        public string ln;
        public string fn;
        public string mn;
        public string el;
        public string ct;
        public string yr;
        public string cn;
        public string em;
        public Image qr;


        public frmLibraryCard()
        {
            InitializeComponent();
        }

        private void pbCard_Paint(object sender, PaintEventArgs e)
        {
            var fontFamily = new FontFamily("Tahoma");
            var font = new Font(fontFamily, 16, FontStyle.Bold, GraphicsUnit.Pixel);
            var solidBrush = new SolidBrush(Color.Black);

            e.Graphics.DrawString("LIBRARY CARD", font, solidBrush, new PointF(120, 10));
            e.Graphics.DrawString(sNum, font, solidBrush, new PointF(10, 70));
            e.Graphics.DrawString(ln + ", " + fn +" " + mn, font, solidBrush, new PointF(10, 95));

            font = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString(el, font, solidBrush, new PointF(25, 115));
            e.Graphics.DrawString(ct + "-" + yr, font, solidBrush, new PointF(25, 135));
            e.Graphics.DrawString(cn, font, solidBrush, new PointF(25, 155));
            e.Graphics.DrawString(em, font, solidBrush, new PointF(25, 175));

            Bitmap bmp = new Bitmap(pbCard.Width, pbCard.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(pbCard.Image, 0, 0, 330, 209);
                g.DrawImage(pbLogo.Image, 13, 10, 100, 50);
                g.DrawImage(qr, 220, 35, 100, 100);
            }

            pbCard.Image = bmp;
            pbLogo.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if(pd.ShowDialog()==DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int width = Convert.ToInt32(pbCard.Width);
            int height = Convert.ToInt32(pbCard.Height);
            Bitmap bm = new Bitmap(width, height);
            pbCard.DrawToBitmap(bm, new Rectangle (0,0, width, height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                int width = Convert.ToInt32(pbCard.Width);
                int height = Convert.ToInt32(pbCard.Height);
                Bitmap bm = new Bitmap(width, height);
                pbCard.DrawToBitmap(bm, new Rectangle(0,0,width, height));
                bm.Save(sfd.FileName + ".png", ImageFormat.Png);

            }
        }
    }
}
