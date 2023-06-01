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
    public partial class TaiKhoan_KH : Form
    {
        public TaiKhoan_KH()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void TaiKhoan_KH_Load(object sender, EventArgs e)
        {
            string tk = DangNhap.instance.txbDn.Text;
            dataGrid_TTKH.DataSource = modify.BindData("select * from KH where MaKH = '"+Home_KH.instance.lbMa.Text+"'");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlConnection conn = Connection.getConnection();
            string query = "update KH set TenKH=@TenKH,DiaChi=@DiaChi,Sdt=@Sdt where MaKH =@MaKH";
           // if(MessageBox.Show("Bạn có muốn thay đổi không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
           // {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = Home_KH.instance.lbMa.Text;
                    cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = txbTen.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txbDiaChi.Text;
                    cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = txbSdt.Text;
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    dataGrid_TTKH.DataSource = modify.BindData("select * from KH where MaKH = '" + Home_KH.instance.lbMa.Text + "'");
                    
            }
                catch (Exception)
                {

                    MessageBox.Show("Không sửa được");
                }
                finally
                {
                    conn.Close();
                }
            //}
            
        }
    }
}
