namespace LibrarySystem
{
    partial class frmUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAccount));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntBack = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPW3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPW2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPW1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntBack)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
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
            this.panel1.Controls.Add(this.bntBack);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 40);
            this.panel1.TabIndex = 3;
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
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(173, 17);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "LIBRARIAN ACCOUNT";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.txtPW3);
            this.panel2.Controls.Add(this.txtPW2);
            this.panel2.Controls.Add(this.txtPW1);
            this.panel2.Controls.Add(this.txtUName);
            this.panel2.Controls.Add(this.txtMName);
            this.panel2.Controls.Add(this.txtFName);
            this.panel2.Controls.Add(this.txtLName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 420);
            this.panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageActive = null;
            this.btnCancel.Location = new System.Drawing.Point(228, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 56);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancel.TabIndex = 32;
            this.btnCancel.TabStop = false;
            this.btnCancel.Zoom = 15;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageActive = null;
            this.btnSave.Location = new System.Drawing.Point(83, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 31;
            this.btnSave.TabStop = false;
            this.btnSave.Zoom = 15;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(14, 163);
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
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(14, 301);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(159, 16);
            this.bunifuCustomLabel8.TabIndex = 25;
            this.bunifuCustomLabel8.Text = "Confirm New Password:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(14, 255);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(105, 16);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "New Password:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(14, 209);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(99, 16);
            this.bunifuCustomLabel5.TabIndex = 27;
            this.bunifuCustomLabel5.Text = "Old Password:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(17, 117);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(96, 16);
            this.bunifuCustomLabel4.TabIndex = 28;
            this.bunifuCustomLabel4.Text = "Middle Name:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(17, 71);
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 16);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Last Name:";
            // 
            // txtPW3
            // 
            this.txtPW3.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPW3.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPW3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPW3.BorderThickness = 3;
            this.txtPW3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPW3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPW3.ForeColor = System.Drawing.Color.White;
            this.txtPW3.isPassword = true;
            this.txtPW3.Location = new System.Drawing.Point(172, 292);
            this.txtPW3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW3.Name = "txtPW3";
            this.txtPW3.Size = new System.Drawing.Size(235, 38);
            this.txtPW3.TabIndex = 7;
            this.txtPW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPW2
            // 
            this.txtPW2.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPW2.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPW2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPW2.BorderThickness = 3;
            this.txtPW2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPW2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPW2.ForeColor = System.Drawing.Color.White;
            this.txtPW2.isPassword = true;
            this.txtPW2.Location = new System.Drawing.Point(172, 246);
            this.txtPW2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW2.Name = "txtPW2";
            this.txtPW2.Size = new System.Drawing.Size(235, 38);
            this.txtPW2.TabIndex = 6;
            this.txtPW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPW1
            // 
            this.txtPW1.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPW1.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPW1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPW1.BorderThickness = 3;
            this.txtPW1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPW1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPW1.ForeColor = System.Drawing.Color.White;
            this.txtPW1.isPassword = true;
            this.txtPW1.Location = new System.Drawing.Point(172, 200);
            this.txtPW1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPW1.Name = "txtPW1";
            this.txtPW1.Size = new System.Drawing.Size(235, 38);
            this.txtPW1.TabIndex = 5;
            this.txtPW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUName
            // 
            this.txtUName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtUName.BorderThickness = 3;
            this.txtUName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUName.ForeColor = System.Drawing.Color.White;
            this.txtUName.isPassword = false;
            this.txtUName.Location = new System.Drawing.Point(172, 154);
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
            this.txtMName.ForeColor = System.Drawing.Color.White;
            this.txtMName.isPassword = false;
            this.txtMName.Location = new System.Drawing.Point(172, 108);
            this.txtMName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(235, 38);
            this.txtMName.TabIndex = 3;
            this.txtMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMName_KeyPress);
            // 
            // txtFName
            // 
            this.txtFName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtFName.BorderThickness = 3;
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFName.ForeColor = System.Drawing.Color.White;
            this.txtFName.isPassword = false;
            this.txtFName.Location = new System.Drawing.Point(172, 62);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(235, 38);
            this.txtFName.TabIndex = 2;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFName_KeyPress);
            // 
            // txtLName
            // 
            this.txtLName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtLName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtLName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtLName.BorderThickness = 3;
            this.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLName.ForeColor = System.Drawing.Color.White;
            this.txtLName.isPassword = false;
            this.txtLName.Location = new System.Drawing.Point(172, 16);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(235, 38);
            this.txtLName.TabIndex = 1;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLName_KeyPress);
            // 
            // frmUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(424, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserAccount";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnCancel;
        private Bunifu.Framework.UI.BunifuImageButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPW3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPW2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPW1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLName;
        private System.Windows.Forms.PictureBox bntBack;
    }
}