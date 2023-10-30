namespace WindowsFormsApp2
{
    partial class CDS_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDS_System));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hamburgerMenu = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.orderspanel = new System.Windows.Forms.Panel();
            this.btn_Orders = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn5 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn4 = new System.Windows.Forms.Button();
            this.picPanel = new System.Windows.Forms.Panel();
            this.btn_Pictures = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.imageSlideshow1 = new WindowsFormsApp2.ImageSlideshow();
            this.buyNow1 = new WindowsFormsApp2.BuyNow();
            this.firstUserControl11 = new WindowsFormsApp2.FirstUserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.orderspanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.picPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hamburgerMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // hamburgerMenu
            // 
            this.hamburgerMenu.Image = ((System.Drawing.Image)(resources.GetObject("hamburgerMenu.Image")));
            this.hamburgerMenu.Location = new System.Drawing.Point(24, 15);
            this.hamburgerMenu.Name = "hamburgerMenu";
            this.hamburgerMenu.Size = new System.Drawing.Size(40, 30);
            this.hamburgerMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamburgerMenu.TabIndex = 2;
            this.hamburgerMenu.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.orderspanel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.picPanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.homePanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 384);
            this.panel2.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 49);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(15, 45);
            this.SidePanel.TabIndex = 3;
            // 
            // orderspanel
            // 
            this.orderspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.orderspanel.Controls.Add(this.btn_Orders);
            this.orderspanel.Location = new System.Drawing.Point(15, 100);
            this.orderspanel.Name = "orderspanel";
            this.orderspanel.Size = new System.Drawing.Size(225, 45);
            this.orderspanel.TabIndex = 8;
            // 
            // btn_Orders
            // 
            this.btn_Orders.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Orders.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Orders.FlatAppearance.BorderSize = 0;
            this.btn_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Orders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Orders.Image = ((System.Drawing.Image)(resources.GetObject("btn_Orders.Image")));
            this.btn_Orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Orders.Location = new System.Drawing.Point(0, 0);
            this.btn_Orders.Name = "btn_Orders";
            this.btn_Orders.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Orders.Size = new System.Drawing.Size(240, 45);
            this.btn_Orders.TabIndex = 2;
            this.btn_Orders.Text = "          Orders";
            this.btn_Orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Orders.UseVisualStyleBackColor = false;
            this.btn_Orders.Click += new System.EventHandler(this.btn_Orders_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.btn5);
            this.panel5.Location = new System.Drawing.Point(0, 304);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 45);
            this.panel5.TabIndex = 7;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5.Location = new System.Drawing.Point(0, 0);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn5.Size = new System.Drawing.Size(240, 45);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "          Home";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.btn4);
            this.panel8.Location = new System.Drawing.Point(0, 253);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 45);
            this.panel8.TabIndex = 7;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.Location = new System.Drawing.Point(0, 0);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn4.Size = new System.Drawing.Size(240, 45);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "          Home";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // picPanel
            // 
            this.picPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picPanel.Controls.Add(this.btn_Pictures);
            this.picPanel.Location = new System.Drawing.Point(15, 151);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(225, 45);
            this.picPanel.TabIndex = 7;
            // 
            // btn_Pictures
            // 
            this.btn_Pictures.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Pictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Pictures.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Pictures.FlatAppearance.BorderSize = 0;
            this.btn_Pictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pictures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pictures.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Pictures.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pictures.Image")));
            this.btn_Pictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pictures.Location = new System.Drawing.Point(0, 0);
            this.btn_Pictures.Name = "btn_Pictures";
            this.btn_Pictures.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Pictures.Size = new System.Drawing.Size(225, 45);
            this.btn_Pictures.TabIndex = 2;
            this.btn_Pictures.Text = "          Pictures";
            this.btn_Pictures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pictures.UseVisualStyleBackColor = false;
            this.btn_Pictures.Click += new System.EventHandler(this.btn_Chat_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 45);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Devices";
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.homePanel.Controls.Add(this.btn_Home);
            this.homePanel.Location = new System.Drawing.Point(15, 49);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(225, 45);
            this.homePanel.TabIndex = 3;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(225, 45);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "          Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 45);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "People";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.imageSlideshow1);
            this.panel9.Controls.Add(this.buyNow1);
            this.panel9.Controls.Add(this.firstUserControl11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(240, 66);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(560, 384);
            this.panel9.TabIndex = 2;
            // 
            // imageSlideshow1
            // 
            this.imageSlideshow1.BackColor = System.Drawing.Color.White;
            this.imageSlideshow1.Location = new System.Drawing.Point(3, 16);
            this.imageSlideshow1.Name = "imageSlideshow1";
            this.imageSlideshow1.Size = new System.Drawing.Size(567, 427);
            this.imageSlideshow1.TabIndex = 2;
            // 
            // buyNow1
            // 
            this.buyNow1.BackColor = System.Drawing.Color.White;
            this.buyNow1.Location = new System.Drawing.Point(0, 9);
            this.buyNow1.Name = "buyNow1";
            this.buyNow1.Size = new System.Drawing.Size(567, 427);
            this.buyNow1.TabIndex = 1;
            // 
            // firstUserControl11
            // 
            this.firstUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstUserControl11.Location = new System.Drawing.Point(0, 0);
            this.firstUserControl11.Name = "firstUserControl11";
            this.firstUserControl11.Size = new System.Drawing.Size(560, 384);
            this.firstUserControl11.TabIndex = 0;
            // 
            // CDS_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CDS_System";
            this.Text = "CDS_System";
            this.Load += new System.EventHandler(this.CDS_System_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.orderspanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.picPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox hamburgerMenu;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel picPanel;
        private System.Windows.Forms.Button btn_Pictures;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel SidePanel;
        private FirstUserControl1 firstUserControl11;
        private BuyNow buyNow1;
        private System.Windows.Forms.Panel orderspanel;
        private System.Windows.Forms.Button btn_Orders;
        private ImageSlideshow imageSlideshow1;
    }
}