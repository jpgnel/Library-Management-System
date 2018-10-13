namespace LibrarySystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccount = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAttendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBorrowRecords = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBookInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnLibrarian = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabReports1 = new LibrarySystem.tabReports();
            this.tabBorrow1 = new LibrarySystem.tabBorrow();
            this.tabBooks1 = new LibrarySystem.tabBooks();
            this.tabStudentInfo1 = new LibrarySystem.tabStudentInfo();
            this.tabLibrarian1 = new LibrarySystem.tabLibrarian();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(88)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLogout, BunifuAnimatorNS.DecorationType.None);
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1333, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(25, 25);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMini
            // 
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(1304, 7);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 1;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(7, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(139, 17);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "LIBRARY SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLibrarian);
            this.panel2.Controls.Add(this.btnAttendance);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnBorrowRecords);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.btnBookInfo);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 690);
            this.panel2.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnAccount, BunifuAnimatorNS.DecorationType.None);
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageActive = null;
            this.btnAccount.Location = new System.Drawing.Point(15, 189);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(50, 50);
            this.btnAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAccount.TabIndex = 2;
            this.btnAccount.TabStop = false;
            this.btnAccount.Zoom = 10;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendance.BorderRadius = 0;
            this.btnAttendance.ButtonText = "   Attendance";
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnAttendance, BunifuAnimatorNS.DecorationType.None);
            this.btnAttendance.DisabledColor = System.Drawing.Color.Gray;
            this.btnAttendance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAttendance.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Iconimage")));
            this.btnAttendance.Iconimage_right = null;
            this.btnAttendance.Iconimage_right_Selected = null;
            this.btnAttendance.Iconimage_Selected = null;
            this.btnAttendance.IconMarginLeft = 0;
            this.btnAttendance.IconMarginRight = 0;
            this.btnAttendance.IconRightVisible = true;
            this.btnAttendance.IconRightZoom = 0D;
            this.btnAttendance.IconVisible = true;
            this.btnAttendance.IconZoom = 80D;
            this.btnAttendance.IsTab = true;
            this.btnAttendance.Location = new System.Drawing.Point(0, 512);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAttendance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAttendance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAttendance.selected = false;
            this.btnAttendance.Size = new System.Drawing.Size(275, 67);
            this.btnAttendance.TabIndex = 0;
            this.btnAttendance.Text = "   Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Textcolor = System.Drawing.Color.White;
            this.btnAttendance.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnReports
            // 
            this.btnReports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.BorderRadius = 0;
            this.btnReports.ButtonText = "   Reports";
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.btnReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnReports.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReports.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReports.Iconimage")));
            this.btnReports.Iconimage_right = null;
            this.btnReports.Iconimage_right_Selected = null;
            this.btnReports.Iconimage_Selected = null;
            this.btnReports.IconMarginLeft = 0;
            this.btnReports.IconMarginRight = 0;
            this.btnReports.IconRightVisible = true;
            this.btnReports.IconRightZoom = 0D;
            this.btnReports.IconVisible = true;
            this.btnReports.IconZoom = 80D;
            this.btnReports.IsTab = true;
            this.btnReports.Location = new System.Drawing.Point(0, 449);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReports.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReports.selected = false;
            this.btnReports.Size = new System.Drawing.Size(275, 67);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "   Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Textcolor = System.Drawing.Color.White;
            this.btnReports.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnBorrowRecords
            // 
            this.btnBorrowRecords.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBorrowRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrowRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrowRecords.BorderRadius = 0;
            this.btnBorrowRecords.ButtonText = "   Borrowing Records";
            this.btnBorrowRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnBorrowRecords, BunifuAnimatorNS.DecorationType.None);
            this.btnBorrowRecords.DisabledColor = System.Drawing.Color.Gray;
            this.btnBorrowRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowRecords.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBorrowRecords.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBorrowRecords.Iconimage")));
            this.btnBorrowRecords.Iconimage_right = null;
            this.btnBorrowRecords.Iconimage_right_Selected = null;
            this.btnBorrowRecords.Iconimage_Selected = null;
            this.btnBorrowRecords.IconMarginLeft = 0;
            this.btnBorrowRecords.IconMarginRight = 0;
            this.btnBorrowRecords.IconRightVisible = true;
            this.btnBorrowRecords.IconRightZoom = 0D;
            this.btnBorrowRecords.IconVisible = true;
            this.btnBorrowRecords.IconZoom = 80D;
            this.btnBorrowRecords.IsTab = true;
            this.btnBorrowRecords.Location = new System.Drawing.Point(0, 385);
            this.btnBorrowRecords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrowRecords.Name = "btnBorrowRecords";
            this.btnBorrowRecords.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBorrowRecords.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBorrowRecords.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBorrowRecords.selected = false;
            this.btnBorrowRecords.Size = new System.Drawing.Size(275, 67);
            this.btnBorrowRecords.TabIndex = 0;
            this.btnBorrowRecords.Text = "   Borrowing Records";
            this.btnBorrowRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowRecords.Textcolor = System.Drawing.Color.White;
            this.btnBorrowRecords.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowRecords.Click += new System.EventHandler(this.btnBorrowRecords_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Student Information";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 80D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 322);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(275, 67);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.Text = "   Student Information";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBookInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBookInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookInfo.BorderRadius = 0;
            this.btnBookInfo.ButtonText = "   Book Information";
            this.btnBookInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnBookInfo, BunifuAnimatorNS.DecorationType.None);
            this.btnBookInfo.DisabledColor = System.Drawing.Color.Gray;
            this.btnBookInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBookInfo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBookInfo.Iconimage")));
            this.btnBookInfo.Iconimage_right = null;
            this.btnBookInfo.Iconimage_right_Selected = null;
            this.btnBookInfo.Iconimage_Selected = null;
            this.btnBookInfo.IconMarginLeft = 0;
            this.btnBookInfo.IconMarginRight = 0;
            this.btnBookInfo.IconRightVisible = true;
            this.btnBookInfo.IconRightZoom = 0D;
            this.btnBookInfo.IconVisible = true;
            this.btnBookInfo.IconZoom = 80D;
            this.btnBookInfo.IsTab = true;
            this.btnBookInfo.Location = new System.Drawing.Point(0, 258);
            this.btnBookInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBookInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBookInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBookInfo.selected = true;
            this.btnBookInfo.Size = new System.Drawing.Size(275, 67);
            this.btnBookInfo.TabIndex = 0;
            this.btnBookInfo.Text = "   Book Information";
            this.btnBookInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookInfo.Textcolor = System.Drawing.Color.White;
            this.btnBookInfo.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInfo.Click += new System.EventHandler(this.btnBookInfo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.panel3.Controls.Add(this.tabLibrarian1);
            this.panel3.Controls.Add(this.tabReports1);
            this.panel3.Controls.Add(this.tabBorrow1);
            this.panel3.Controls.Add(this.tabBooks1);
            this.panel3.Controls.Add(this.tabStudentInfo1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(272, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 690);
            this.panel3.TabIndex = 2;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 30;
            this.bunifuTransition1.MaxAnimationTime = 2000;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLibrarian.BackColor = System.Drawing.Color.Transparent;
            this.btnLibrarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLibrarian.BorderRadius = 0;
            this.btnLibrarian.ButtonText = "   Manage Librarian";
            this.btnLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLibrarian, BunifuAnimatorNS.DecorationType.None);
            this.btnLibrarian.DisabledColor = System.Drawing.Color.Gray;
            this.btnLibrarian.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLibrarian.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLibrarian.Iconimage")));
            this.btnLibrarian.Iconimage_right = null;
            this.btnLibrarian.Iconimage_right_Selected = null;
            this.btnLibrarian.Iconimage_Selected = null;
            this.btnLibrarian.IconMarginLeft = 0;
            this.btnLibrarian.IconMarginRight = 0;
            this.btnLibrarian.IconRightVisible = true;
            this.btnLibrarian.IconRightZoom = 0D;
            this.btnLibrarian.IconVisible = true;
            this.btnLibrarian.IconZoom = 80D;
            this.btnLibrarian.IsTab = true;
            this.btnLibrarian.Location = new System.Drawing.Point(0, 611);
            this.btnLibrarian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLibrarian.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLibrarian.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLibrarian.selected = false;
            this.btnLibrarian.Size = new System.Drawing.Size(275, 67);
            this.btnLibrarian.TabIndex = 0;
            this.btnLibrarian.Text = "   Manage Librarian";
            this.btnLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrarian.Textcolor = System.Drawing.Color.White;
            this.btnLibrarian.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.Click += new System.EventHandler(this.btnLibrarian_Click);
            // 
            // tabReports1
            // 
            this.bunifuTransition1.SetDecoration(this.tabReports1, BunifuAnimatorNS.DecorationType.None);
            this.tabReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReports1.Location = new System.Drawing.Point(0, 0);
            this.tabReports1.Name = "tabReports1";
            this.tabReports1.Size = new System.Drawing.Size(1094, 690);
            this.tabReports1.TabIndex = 4;
            this.tabReports1.Visible = false;
            // 
            // tabBorrow1
            // 
            this.bunifuTransition1.SetDecoration(this.tabBorrow1, BunifuAnimatorNS.DecorationType.None);
            this.tabBorrow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBorrow1.Location = new System.Drawing.Point(0, 0);
            this.tabBorrow1.Name = "tabBorrow1";
            this.tabBorrow1.Size = new System.Drawing.Size(1094, 690);
            this.tabBorrow1.TabIndex = 3;
            // 
            // tabBooks1
            // 
            this.bunifuTransition1.SetDecoration(this.tabBooks1, BunifuAnimatorNS.DecorationType.None);
            this.tabBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBooks1.Location = new System.Drawing.Point(0, 0);
            this.tabBooks1.Name = "tabBooks1";
            this.tabBooks1.Size = new System.Drawing.Size(1094, 690);
            this.tabBooks1.TabIndex = 2;
            // 
            // tabStudentInfo1
            // 
            this.bunifuTransition1.SetDecoration(this.tabStudentInfo1, BunifuAnimatorNS.DecorationType.None);
            this.tabStudentInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStudentInfo1.Location = new System.Drawing.Point(0, 0);
            this.tabStudentInfo1.Name = "tabStudentInfo1";
            this.tabStudentInfo1.Size = new System.Drawing.Size(1094, 690);
            this.tabStudentInfo1.TabIndex = 1;
            // 
            // tabLibrarian1
            // 
            this.bunifuTransition1.SetDecoration(this.tabLibrarian1, BunifuAnimatorNS.DecorationType.None);
            this.tabLibrarian1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLibrarian1.Location = new System.Drawing.Point(0, 0);
            this.tabLibrarian1.Name = "tabLibrarian1";
            this.tabLibrarian1.Size = new System.Drawing.Size(1094, 690);
            this.tabLibrarian1.TabIndex = 5;
            this.tabLibrarian1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1366, 730);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReports;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrowRecords;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnBookInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private tabStudentInfo tabStudentInfo1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAttendance;
        private tabBooks tabBooks1;
        private tabBorrow tabBorrow1;
        private Bunifu.Framework.UI.BunifuImageButton btnAccount;
        private tabReports tabReports1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLibrarian;
        private tabLibrarian tabLibrarian1;
    }
}