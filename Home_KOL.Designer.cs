
namespace QuanLyTk
{
    partial class Home_KOL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLich = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.lbSDT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTenKOL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaKOL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbNs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnLich);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 416);
            this.panel1.TabIndex = 0;
            // 
            // btnLich
            // 
            this.btnLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLich.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLich.ForeColor = System.Drawing.Color.White;
            this.btnLich.Image = global::QuanLyTk.Properties.Resources.icons8_calendar_32;
            this.btnLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLich.Location = new System.Drawing.Point(3, 122);
            this.btnLich.Name = "btnLich";
            this.btnLich.Size = new System.Drawing.Size(178, 33);
            this.btnLich.TabIndex = 4;
            this.btnLich.Text = "Lịch làm việc";
            this.btnLich.UseVisualStyleBackColor = true;
            this.btnLich.Click += new System.EventHandler(this.btnLich_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::QuanLyTk.Properties.Resources.icons8_monitor_24;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 83);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 33);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "KOL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 39);
            this.panel2.TabIndex = 1;
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.lbNs);
            this.panel_body.Controls.Add(this.label8);
            this.panel_body.Controls.Add(this.lbGioiTinh);
            this.panel_body.Controls.Add(this.label4);
            this.panel_body.Controls.Add(this.lbSDT);
            this.panel_body.Controls.Add(this.label7);
            this.panel_body.Controls.Add(this.lbDiaChi);
            this.panel_body.Controls.Add(this.label5);
            this.panel_body.Controls.Add(this.lbTenKOL);
            this.panel_body.Controls.Add(this.label3);
            this.panel_body.Controls.Add(this.lbMaKOL);
            this.panel_body.Controls.Add(this.label2);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(184, 39);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(571, 377);
            this.panel_body.TabIndex = 2;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(200, 216);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(112, 21);
            this.lbSDT.TabIndex = 16;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số điện thoại:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(195, 183);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(69, 21);
            this.lbDiaChi.TabIndex = 14;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ:";
            // 
            // lbTenKOL
            // 
            this.lbTenKOL.AutoSize = true;
            this.lbTenKOL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKOL.Location = new System.Drawing.Point(200, 90);
            this.lbTenKOL.Name = "lbTenKOL";
            this.lbTenKOL.Size = new System.Drawing.Size(132, 21);
            this.lbTenKOL.TabIndex = 12;
            this.lbTenKOL.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên KOL:";
            // 
            // lbMaKOL
            // 
            this.lbMaKOL.AutoSize = true;
            this.lbMaKOL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKOL.Location = new System.Drawing.Point(195, 56);
            this.lbMaKOL.Name = "lbMaKOL";
            this.lbMaKOL.Size = new System.Drawing.Size(127, 21);
            this.lbMaKOL.TabIndex = 10;
            this.lbMaKOL.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã KOL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giới tính:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(200, 122);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(80, 21);
            this.lbGioiTinh.TabIndex = 18;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ngày sinh:";
            // 
            // lbNs
            // 
            this.lbNs.AutoSize = true;
            this.lbNs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNs.Location = new System.Drawing.Point(200, 148);
            this.lbNs.Name = "lbNs";
            this.lbNs.Size = new System.Drawing.Size(88, 21);
            this.lbNs.TabIndex = 20;
            this.lbNs.Text = "Ngày sinh:";
            // 
            // Home_KOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 416);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home_KOL";
            this.Text = "Home_KOL";
            this.Load += new System.EventHandler(this.Home_KOL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLich;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTenKOL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMaKOL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNs;
    }
}