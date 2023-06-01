using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace QuanLyTk
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        

        private void ThanhToan_Load(object sender, EventArgs e)
        {

            LbTenKOL.Text = FormTT_KOL.instance.lbTenKOL.Text;
            lbTenKH.Text = Home_KH.instance.lbTen.Text;
            lbTien.Text = FormTT_KOL.instance.lbCoc.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTT_KOL tt_kol = new FormTT_KOL();
            tt_kol.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string number = Convert.ToString( rd.Next(101, 300));
            SqlConnection conn = Connection.getConnection();
            string query = "insert into ChiTietCongViec values(@MaGD,@MaKH,@MaKOL,@ThoiGian)";
            if(MessageBox.Show("Bạn có xác nhận thanh toán ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaGD", SqlDbType.VarChar).Value = number;
                cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = Home_KH.instance.lbMa.Text;
                cmd.Parameters.Add("@MaKOL", SqlDbType.VarChar).Value = FormTT_KOL.instance.lbMa.Text;
                cmd.Parameters.Add("@ThoiGian", SqlDbType.DateTime).Value = FormTT_KOL.instance.time.Value.ToShortDateString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh toán thành công");


            }
            catch
            {
                MessageBox.Show("Lỗi thanh toán");
            }
            finally
            {
                conn.Close();
            }
            }
            
            
        }
    }
}
