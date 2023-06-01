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
    public partial class QL_KH : Form
    {
        SqlCommand cmd;
        
        Modify modify = new Modify();
        int index = -1;
        public QL_KH()
        {
            InitializeComponent();
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            string query = "select * from KH";
            datagridViewKH.DataSource = modify.BindData(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string name = txbName.Text;
            string diachi = cboDiaChi.Text;
            string sdt = txbSDT.Text;

            KhachHang kh = new KhachHang(id, name, diachi, sdt);
            if (modify.insertDataKH(kh))
            {
                datagridViewKH.DataSource = modify.BindData("select * from KH");
            }
            else
            {
                MessageBox.Show("Lỗi không thêm được", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.getConnection();
            string id = txbID.Text;
            int count = 0;
            string tquery = "select ChiTietCongViec.MaGD from ChiTietCongViec, KH where ChiTietCongViec.MaKH = KH.MaKH and KH.MaKH ='" + id + "'";

            conn.Open();
   
            cmd = new SqlCommand(tquery, conn);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    count++;
                }
            }
            conn.Close();
            if (count == 0)
            {

                string query = "delete KH where MaKH = @MaKH";

                try
                {
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    datagridViewKH.DataSource = modify.BindData("select * from KH");
                }
                catch (Exception)
                {

                    MessageBox.Show("Lỗi không xóa được", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
               
            }
            else
            {
                if (MessageBox.Show("Khách hàng hiện đang có hợp đồng, nên không thể xóa.Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string query = "delete ChiTietCongViec where MaKH = @MaKH";
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa giao dịch thành công");
                    datagridViewKH.DataSource = modify.BindData("select * from KH");
                    
                    conn.Close();

                }
            }

           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string name = txbName.Text;
            string diachi = cboDiaChi.Text;
            string sdt = txbSDT.Text;

            KhachHang kh = new KhachHang(id, name, diachi, sdt);
            if (modify.updateDataKH(kh))
            {
                datagridViewKH.DataSource = modify.BindData("select * from KH");
            }
            else
            {
                MessageBox.Show("Lỗi không cập nhật được", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void datagridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = datagridViewKH.CurrentCell.RowIndex;
            if(index != -1)
            {
                txbID.Text = datagridViewKH.Rows[index].Cells[0].Value.ToString();
                txbName.Text = datagridViewKH.Rows[index].Cells[1].Value.ToString();
                cboDiaChi.Text = datagridViewKH.Rows[index].Cells[2].Value.ToString();
                txbSDT.Text = datagridViewKH.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from KH where TenKH like'%" + txbTimKiem.Text + "%'";
            modify.BindData(query);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "select * from KH where TenKH like'%" + txbTimKiem.Text + "%'";
            datagridViewKH.DataSource =  modify.BindData(query);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = "select * from KH";
            datagridViewKH.DataSource = modify.BindData(query);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
