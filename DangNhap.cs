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
    public partial class DangNhap : Form
    {
        public static DangNhap instance;
        public TextBox txbDn;
        public DangNhap()
        {
            InitializeComponent();
            instance = this;
            txbDn = txbTaiKhoan;
        }
        SqlConnection conn = Connection.getConnection();
       
        SqlDataReader reader;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TenTk='" + txbTaiKhoan.Text + "' and MatKhau ='" + txbMatKhau.Text + "'", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            string chucDanh = "";
            while (reader.Read())
            {
                count += 1;
                chucDanh = reader["ChucDanh"].ToString();
            }
            if(count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                if(chucDanh == "admin")
                {
                    Home_QuanLy ql = new Home_QuanLy();
                    ql.ShowDialog();
                }else 
                {
                    Home_KH kh = new Home_KH();
                    kh.ShowDialog();
                } 
            }
            conn.Close();

        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
