
namespace QuanLyTk
{
    partial class TaiKhoan_KH
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
            this.dataGrid_TTKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TTKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_TTKH
            // 
            this.dataGrid_TTKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_TTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_TTKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid_TTKH.Location = new System.Drawing.Point(0, 208);
            this.dataGrid_TTKH.Name = "dataGrid_TTKH";
            this.dataGrid_TTKH.Size = new System.Drawing.Size(521, 153);
            this.dataGrid_TTKH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(157, 29);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(153, 20);
            this.txbTen.TabIndex = 2;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(157, 67);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(153, 20);
            this.txbDiaChi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ";
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(157, 102);
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(153, 20);
            this.txbSdt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(367, 129);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 29);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // TaiKhoan_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 361);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txbSdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_TTKH);
            this.Name = "TaiKhoan_KH";
            this.Text = "TaiKhoan_KH";
            this.Load += new System.EventHandler(this.TaiKhoan_KH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_TTKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.DataGridView dataGrid_TTKH;
    }
}