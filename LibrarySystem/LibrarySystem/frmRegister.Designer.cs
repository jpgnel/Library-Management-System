namespace LibrarySystem
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.bntBack = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPW1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPW = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bntBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntBack
            // 
            this.bntBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBack.Image = ((System.Drawing.Image)(resources.GetObject("bntBack.Image")));
            this.bntBack.Location = new System.Drawing.Point(12, 9);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(25, 25);
            this.bntBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntBack.TabIndex = 2;
            this.bntBack.TabStop = false;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(14, 203);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(76, 16);
            this.bunifuCustomLabel6.TabIndex = 24;
            this.bunifuCustomLabel6.Text = "Username:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(14, 295);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(127, 16);
            this.bunifuCustomLabel8.TabIndex = 25;
            this.bunifuCustomLabel8.Text = "Confirm Password:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(14, 249);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(73, 16);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "Password:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(17, 157);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(96, 16);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Middle Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(88)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.bntBack);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 40);
            this.panel1.TabIndex = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(86, 17);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "REGISTER";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(17, 111);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 16);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "First Name:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 65);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 16);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Last Name:";
            // 
            // txtPW1
            // 
            this.txtPW1.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPW1.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPW1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPW1.BorderThickness = 3;
            this.txtPW1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPW1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPW1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPW1.isPassword = false;
            this.txtPW1.Location = new System.Drawing.Point(151, 286);
            this.txtPW1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW1.Name = "txtPW1";
            this.txtPW1.Size = new System.Drawing.Size(235, 38);
            this.txtPW1.TabIndex = 6;
            this.txtPW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPW
            // 
            this.txtPW.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPW.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPW.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPW.BorderThickness = 3;
            this.txtPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPW.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPW.isPassword = false;
            this.txtPW.Location = new System.Drawing.Point(151, 240);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(235, 38);
            this.txtPW.TabIndex = 5;
            this.txtPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUName
            // 
            this.txtUName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtUName.BorderThickness = 3;
            this.txtUName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUName.isPassword = false;
            this.txtUName.Location = new System.Drawing.Point(151, 194);
            this.txtUName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(235, 38);
            this.txtUName.TabIndex = 4;
            this.txtUName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMName
            // 
            this.txtMName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMName.BorderThickness = 3;
            this.txtMName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMName.isPassword = false;
            this.txtMName.Location = new System.Drawing.Point(151, 148);
            this.txtMName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(235, 38);
            this.txtMName.TabIndex = 3;
            this.txtMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFName
            // 
            this.txtFName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFName.BorderThickness = 3;
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFName.isPassword = false;
            this.txtFName.Location = new System.Drawing.Point(151, 102);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(235, 38);
            this.txtFName.TabIndex = 2;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLName
            // 
            this.txtLName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtLName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtLName.BorderThickness = 3;
            this.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLName.isPassword = false;
            this.txtLName.Location = new System.Drawing.Point(151, 56);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(235, 38);
            this.txtLName.TabIndex = 1;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.txtPW1);
            this.panel2.Controls.Add(this.txtPW);
            this.panel2.Controls.Add(this.txtUName);
            this.panel2.Controls.Add(this.txtMName);
            this.panel2.Controls.Add(this.txtFName);
            this.panel2.Controls.Add(this.txtLName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 433);
            this.panel2.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.BorderRadius = 7;
            this.btnRegister.ButtonText = "REGISTER";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegister.Iconimage = null;
            this.btnRegister.Iconimage_right = null;
            this.btnRegister.Iconimage_right_Selected = null;
            this.btnRegister.Iconimage_Selected = null;
            this.btnRegister.IconMarginLeft = 0;
            this.btnRegister.IconMarginRight = 0;
            this.btnRegister.IconRightVisible = false;
            this.btnRegister.IconRightZoom = 0D;
            this.btnRegister.IconVisible = false;
            this.btnRegister.IconZoom = 90D;
            this.btnRegister.IsTab = false;
            this.btnRegister.Location = new System.Drawing.Point(60, 348);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.selected = false;
            this.btnRegister.Size = new System.Drawing.Size(121, 57);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Textcolor = System.Drawing.Color.Transparent;
            this.btnRegister.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(58)))), ((int)(((byte)(47)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 7;
            this.btnCancel.ButtonText = "CANCEL";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = false;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = false;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(222, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(58)))), ((int)(((byte)(47)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(58)))), ((int)(((byte)(47)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(121, 57);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.Transparent;
            this.btnCancel.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.bntBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bntBack;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPW1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPW;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLName;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegister;
    }
}