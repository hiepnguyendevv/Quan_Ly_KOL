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
        bool checkTxb()
        {
            
            if(txbTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống tên đăng nhập", "Thông báo");
                return false;
            }
            else if(txbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống mật khẩu", "Thông báo");
                return false;
            }
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TaiKhoan where TenTk='" + txbTaiKhoan.Text + "' and MatKhau ='" + txbMatKhau.Text + "'", conn);
            conn.Open();
            if (checkTxb())
            {
                reader = cmd.ExecuteReader();
                int count = 0;
                string chucDanh = "";
                while (reader.Read())
                {
                    count += 1;
                    chucDanh = reader["ChucDanh"].ToString();
                }
                if (count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    if (chucDanh == "admin")
                    {
                        Home_QuanLy ql = new Home_QuanLy();
                        ql.ShowDialog();
                    }
                    else if(chucDanh == "kol")
                    {
                        Home_KOL kol = new Home_KOL();
                        kol.ShowDialog();
                    }
                    else
                    {
                        Home_KH kh = new Home_KH();
                        kh.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            conn.Close();

        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                System.Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
         
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
