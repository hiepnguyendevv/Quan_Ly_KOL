using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuanLyTk
{
    public partial class FormTT_KOL : Form
    {
        //SqlCommand cmd;
        //SqlDataAdapter data;
        public static FormTT_KOL instance;
        public Label lbMa;
        public Label lbTenKOL;
        public Label lbGt;
        public Label lbNs;
        public Label lbDc;
        public Label lbSoDt;
        public Label lbCoc;
        public DateTimePicker time;
        public FormTT_KOL()
        {
            InitializeComponent();
            instance = this;
            lbMa = lbKOL;
            lbTenKOL = lbName;
            lbGt = lbGioiTinh;
            lbNs = lbNgaySinh;
            lbDc = lbDiaChi;
            lbSoDt = lbSdt;
            lbCoc = lbGia;
            time = date_lich;
        }

        private void FormTT_KOL_Load(object sender, EventArgs e)
        {
            btnBooking.Enabled = false;
            check_XN.Checked = false;
        }

        private void check_XN_CheckedChanged(object sender, EventArgs e)
        {
            if (check_XN.Checked)
            {
                btnBooking.Enabled = true;
            }
            else
            {
                btnBooking.Enabled = false;
            }
        }

        


        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan tt = new ThanhToan();
            tt.ShowDialog();
        }
    }
}
