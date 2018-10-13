namespace LibrarySystem
{
    partial class tabBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoldings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCatalog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabBookInfo1 = new LibrarySystem.tabBookInfo();
            this.tabHoldings1 = new LibrarySystem.tabHoldings();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 690);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabHoldings1);
            this.panel3.Controls.Add(this.tabBookInfo1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 651);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHoldings);
            this.panel2.Controls.Add(this.btnCatalog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 39);
            this.panel2.TabIndex = 0;
            // 
            // btnHoldings
            // 
            this.btnHoldings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHoldings.BackColor = System.Drawing.Color.Transparent;
            this.btnHoldings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoldings.BorderRadius = 0;
            this.btnHoldings.ButtonText = "Holdings";
            this.btnHoldings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoldings.DisabledColor = System.Drawing.Color.Gray;
            this.btnHoldings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoldings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHoldings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHoldings.Iconimage")));
            this.btnHoldings.Iconimage_right = null;
            this.btnHoldings.Iconimage_right_Selected = null;
            this.btnHoldings.Iconimage_Selected = null;
            this.btnHoldings.IconMarginLeft = 0;
            this.btnHoldings.IconMarginRight = 0;
            this.btnHoldings.IconRightVisible = false;
            this.btnHoldings.IconRightZoom = 0D;
            this.btnHoldings.IconVisible = false;
            this.btnHoldings.IconZoom = 90D;
            this.btnHoldings.IsTab = true;
            this.btnHoldings.Location = new System.Drawing.Point(121, 3);
            this.btnHoldings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHoldings.Name = "btnHoldings";
            this.btnHoldings.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHoldings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnHoldings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHoldings.selected = false;
            this.btnHoldings.Size = new System.Drawing.Size(123, 42);
            this.btnHoldings.TabIndex = 0;
            this.btnHoldings.Text = "Holdings";
            this.btnHoldings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoldings.Textcolor = System.Drawing.Color.White;
            this.btnHoldings.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoldings.Click += new System.EventHandler(this.btnHoldings_Click);
            // 
            // btnCatalog
            // 
            this.btnCatalog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatalog.BorderRadius = 0;
            this.btnCatalog.ButtonText = "Catalouging";
            this.btnCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalog.DisabledColor = System.Drawing.Color.Gray;
            this.btnCatalog.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCatalog.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCatalog.Iconimage")));
            this.btnCatalog.Iconimage_right = null;
            this.btnCatalog.Iconimage_right_Selected = null;
            this.btnCatalog.Iconimage_Selected = null;
            this.btnCatalog.IconMarginLeft = 0;
            this.btnCatalog.IconMarginRight = 0;
            this.btnCatalog.IconRightVisible = false;
            this.btnCatalog.IconRightZoom = 0D;
            this.btnCatalog.IconVisible = false;
            this.btnCatalog.IconZoom = 90D;
            this.btnCatalog.IsTab = true;
            this.btnCatalog.Location = new System.Drawing.Point(0, 3);
            this.btnCatalog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCatalog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnCatalog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCatalog.selected = true;
            this.btnCatalog.Size = new System.Drawing.Size(123, 42);
            this.btnCatalog.TabIndex = 0;
            this.btnCatalog.Text = "Catalouging";
            this.btnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.Textcolor = System.Drawing.Color.White;
            this.btnCatalog.TextFont = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // tabBookInfo1
            // 
            this.tabBookInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBookInfo1.Location = new System.Drawing.Point(0, 0);
            this.tabBookInfo1.Name = "tabBookInfo1";
            this.tabBookInfo1.Size = new System.Drawing.Size(1094, 651);
            this.tabBookInfo1.TabIndex = 0;
            // 
            // tabHoldings1
            // 
            this.tabHoldings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHoldings1.Location = new System.Drawing.Point(0, 0);
            this.tabHoldings1.Name = "tabHoldings1";
            this.tabHoldings1.Size = new System.Drawing.Size(1094, 651);
            this.tabHoldings1.TabIndex = 1;
            this.tabHoldings1.Load += new System.EventHandler(this.tabHoldings1_Load);
            // 
            // tabBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "tabBooks";
            this.Size = new System.Drawing.Size(1094, 690);
            this.Load += new System.EventHandler(this.tabBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnHoldings;
        private Bunifu.Framework.UI.BunifuFlatButton btnCatalog;
        private System.Windows.Forms.Panel panel3;
        private tabBookInfo tabBookInfo1;
        private tabHoldings tabHoldings1;
    }
}
