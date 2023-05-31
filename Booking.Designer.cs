
namespace QuanLyTk
{
    partial class Booking
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
            this.dataGridView_DsKOL = new System.Windows.Forms.DataGridView();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DsKOL)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DsKOL
            // 
            this.dataGridView_DsKOL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DsKOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DsKOL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_DsKOL.Location = new System.Drawing.Point(0, 138);
            this.dataGridView_DsKOL.Name = "dataGridView_DsKOL";
            this.dataGridView_DsKOL.ReadOnly = true;
            this.dataGridView_DsKOL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DsKOL.Size = new System.Drawing.Size(547, 214);
            this.dataGridView_DsKOL.TabIndex = 0;
            this.dataGridView_DsKOL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DsKOL_CellClick);
            this.dataGridView_DsKOL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DsKOL_CellContentClick);
            this.dataGridView_DsKOL.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DsKOL_CellContentDoubleClick);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBooking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(12, 37);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(96, 31);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.Location = new System.Drawing.Point(12, 74);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(144, 31);
            this.btnThongTin.TabIndex = 2;
            this.btnThongTin.Text = "Xem thông tin";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(547, 352);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.dataGridView_DsKOL);
            this.Controls.Add(this.btnThongTin);
            this.Name = "Booking";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DsKOL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DsKOL;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnThongTin;
    }
}