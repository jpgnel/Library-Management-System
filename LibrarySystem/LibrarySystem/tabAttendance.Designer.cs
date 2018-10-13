namespace LibrarySystem
{
    partial class tabAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabAttendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntBack = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOUT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSNum = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.dgv1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStNum = new System.Windows.Forms.Label();
            this.lblSNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCT = new System.Windows.Forms.Label();
            this.lblYS = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntBack)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1366, 40);
            this.panel1.TabIndex = 1;
            // 
            // bntBack
            // 
            this.bntBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBack.Image = ((System.Drawing.Image)(resources.GetObject("bntBack.Image")));
            this.bntBack.Location = new System.Drawing.Point(11, 7);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(25, 25);
            this.bntBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntBack.TabIndex = 1;
            this.bntBack.TabStop = false;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(360, 17);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "LIBRARY SYSTEM - ATTENDANCE MONITORING";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 690);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnOUT);
            this.panel2.Controls.Add(this.btnIN);
            this.panel2.Controls.Add(this.txtSNum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 680);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOUT
            // 
            this.btnOUT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.btnOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOUT.BorderRadius = 5;
            this.btnOUT.ButtonText = "TIME-OUT";
            this.btnOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOUT.DisabledColor = System.Drawing.Color.Gray;
            this.btnOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOUT.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOUT.Iconimage = null;
            this.btnOUT.Iconimage_right = null;
            this.btnOUT.Iconimage_right_Selected = null;
            this.btnOUT.Iconimage_Selected = null;
            this.btnOUT.IconMarginLeft = 0;
            this.btnOUT.IconMarginRight = 0;
            this.btnOUT.IconRightVisible = false;
            this.btnOUT.IconRightZoom = 0D;
            this.btnOUT.IconVisible = false;
            this.btnOUT.IconZoom = 90D;
            this.btnOUT.IsTab = false;
            this.btnOUT.Location = new System.Drawing.Point(411, 617);
            this.btnOUT.Margin = new System.Windows.Forms.Padding(5);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(57)))), ((int)(((byte)(46)))));
            this.btnOUT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(57)))), ((int)(((byte)(35)))));
            this.btnOUT.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOUT.selected = false;
            this.btnOUT.Size = new System.Drawing.Size(113, 54);
            this.btnOUT.TabIndex = 12;
            this.btnOUT.Text = "TIME-OUT";
            this.btnOUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOUT.Textcolor = System.Drawing.Color.White;
            this.btnOUT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOUT.Visible = false;
            // 
            // btnIN
            // 
            this.btnIN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIN.BorderRadius = 5;
            this.btnIN.ButtonText = "TIME-IN";
            this.btnIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIN.DisabledColor = System.Drawing.Color.Gray;
            this.btnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIN.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIN.Iconimage")));
            this.btnIN.Iconimage_right = null;
            this.btnIN.Iconimage_right_Selected = null;
            this.btnIN.Iconimage_Selected = null;
            this.btnIN.IconMarginLeft = 0;
            this.btnIN.IconMarginRight = 0;
            this.btnIN.IconRightVisible = false;
            this.btnIN.IconRightZoom = 0D;
            this.btnIN.IconVisible = false;
            this.btnIN.IconZoom = 90D;
            this.btnIN.IsTab = false;
            this.btnIN.Location = new System.Drawing.Point(181, 617);
            this.btnIN.Margin = new System.Windows.Forms.Padding(5);
            this.btnIN.Name = "btnIN";
            this.btnIN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnIN.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIN.selected = false;
            this.btnIN.Size = new System.Drawing.Size(113, 54);
            this.btnIN.TabIndex = 13;
            this.btnIN.Text = "TIME-IN";
            this.btnIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIN.Textcolor = System.Drawing.Color.White;
            this.btnIN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Visible = false;
            // 
            // txtSNum
            // 
            this.txtSNum.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.txtSNum.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSNum.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.txtSNum.BorderThickness = 3;
            this.txtSNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSNum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNum.ForeColor = System.Drawing.Color.White;
            this.txtSNum.isPassword = false;
            this.txtSNum.Location = new System.Drawing.Point(282, 563);
            this.txtSNum.Margin = new System.Windows.Forms.Padding(5);
            this.txtSNum.Name = "txtSNum";
            this.txtSNum.Size = new System.Drawing.Size(298, 46);
            this.txtSNum.TabIndex = 5;
            this.txtSNum.TabStop = false;
            this.txtSNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSNum.Enter += new System.EventHandler(this.txtSNum_Enter);
            this.txtSNum.Leave += new System.EventHandler(this.txtSNum_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            this.label4.TextChanged += new System.EventHandler(this.label4_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(117, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Student No.:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(468, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(119, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan your QR Code";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(13, 89);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(395, 53);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Mon, 00-00-0000";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Britannic Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(431, 89);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00 : 00 AM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblYS);
            this.panel3.Controls.Add(this.lblCT);
            this.panel3.Controls.Add(this.pbImage);
            this.panel3.Controls.Add(this.dgv1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblStNum);
            this.panel3.Controls.Add(this.lblSNum);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(708, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 680);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(475, 24);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(155, 155);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // dgv1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv1.DoubleBuffered = true;
            this.dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv1.Enabled = false;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv1.HeaderForeColor = System.Drawing.Color.White;
            this.dgv1.Location = new System.Drawing.Point(0, 229);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(653, 451);
            this.dgv1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No.:";
            // 
            // lblStNum
            // 
            this.lblStNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStNum.AutoSize = true;
            this.lblStNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStNum.ForeColor = System.Drawing.Color.White;
            this.lblStNum.Location = new System.Drawing.Point(187, 24);
            this.lblStNum.Name = "lblStNum";
            this.lblStNum.Size = new System.Drawing.Size(0, 28);
            this.lblStNum.TabIndex = 1;
            this.lblStNum.TextChanged += new System.EventHandler(this.lblSNum_TextChanged);
            // 
            // lblSNum
            // 
            this.lblSNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSNum.AutoSize = true;
            this.lblSNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNum.ForeColor = System.Drawing.Color.White;
            this.lblSNum.Location = new System.Drawing.Point(187, 24);
            this.lblSNum.Name = "lblSNum";
            this.lblSNum.Size = new System.Drawing.Size(0, 28);
            this.lblSNum.TabIndex = 1;
            this.lblSNum.Visible = false;
            this.lblSNum.TextChanged += new System.EventHandler(this.lblSNum_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(115, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 28);
            this.lblName.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Course/Track:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Year-Section:";
            // 
            // lblCT
            // 
            this.lblCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCT.AutoSize = true;
            this.lblCT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCT.ForeColor = System.Drawing.Color.White;
            this.lblCT.Location = new System.Drawing.Point(211, 114);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(0, 28);
            this.lblCT.TabIndex = 3;
            // 
            // lblYS
            // 
            this.lblYS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYS.AutoSize = true;
            this.lblYS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYS.ForeColor = System.Drawing.Color.White;
            this.lblYS.Location = new System.Drawing.Point(211, 163);
            this.lblYS.Name = "lblYS";
            this.lblYS.Size = new System.Drawing.Size(0, 28);
            this.lblYS.TabIndex = 4;
            // 
            // tabAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1366, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tabAttendance";
            this.Load += new System.EventHandler(this.tabAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntBack)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bntBack;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSNum;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnOUT;
        private Bunifu.Framework.UI.BunifuFlatButton btnIN;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblStNum;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblYS;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}