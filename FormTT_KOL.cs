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
        public FormTT_KOL()
        {
            InitializeComponent();
        }

        private void FormTT_KOL_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            check_XN.Checked = false;
        }

        private void check_XN_CheckedChanged(object sender, EventArgs e)
        {
            if (check_XN.Checked)
            {
                btnThanhToan.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Bạn xác nhận thanh toán?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    SqlConnection conn = Connection.getConnection();
            //    string query = "insert into ChiTietCongViec values(@MaKH,@MaKOL,@ThoiGian,@GiaCoc)";
            //    conn.Open();
            //    cmd = new SqlCommand(query, conn);

            //    conn.Close();
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
