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
    public partial class QL_KOL : Form
    {
        SqlCommand cmd;
        List<string> listDiaChi = new List<string>() { "Hà Nội", "Hải Phòng", "Hồ Chí Minh" };
        Modify modify = new Modify();
        KOL kol = new KOL();
        int index = -1;
     
        public QL_KOL()
        {
            InitializeComponent();
        }
         void clear()
        {
            txbID.Text = "";
            txbName.Text = "";
            txbSDT.Text = "";
            cboDiaChi.Text = "";
        }

        bool checkTextBox()
        {
            if (txbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Id", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(!radioFmale.Checked && !radioMale.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (cboDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn địa chỉ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if ( txbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(txbGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            bool check = int.TryParse(txbGia.Text, out int gia);
            if(check == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            SqlConnection conn = Connection.getConnection();
            string id = txbID.Text;
            int count = 0;
            string tquery = "select ChiTietCongViec.MaGD from ChiTietCongViec, KOL where ChiTietCongViec.MaKOL = KOL.MaKOL and KOL.MaKOL = '" + id + "'";

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

                string query = "delete KOL where MaKOL = @MaKOL";

                try
                {
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@MaKOL", SqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    dataGridView1.DataSource = modify.BindData("select * from KOL");
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
                if (MessageBox.Show("KOL hiện đang có hợp đồng, nên không thể xóa.Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string query = "delete ChiTietCongViec where MaKOL = @KOL";
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@MaKOL", SqlDbType.VarChar).Value = id;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa giao dịch của KOL thành công");
                    dataGridView1.DataSource = modify.BindData("select * from KOL");

                    conn.Close();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = modify.BindData("select * from KOL");
            cboDiaChi.DataSource = listDiaChi;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                string id = txbID.Text;
                string name = txbName.Text;
                string gioiTinh = radioMale.Checked ? radioMale.Text : radioFmale.Text;
                DateTime ngaySinh = this.dateTimeKOL.Value;
                string diaChi = cboDiaChi.Text;
                string sdt = txbSDT.Text;
                int gia = int.Parse(txbGia.Text);
                KOL kol = new KOL(id, name, gioiTinh, ngaySinh, diaChi, sdt, gia);

                if (modify.insertDataKOL(kol))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = modify.BindData("select * from KOL");

                }
                else
                {
                    MessageBox.Show("Lỗi không thêm đươc");
                }
                clear();
            }
            
                
            
            
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkTextBox()) {
                string id = txbID.Text;
                string name = txbName.Text;
                string gioiTinh = radioMale.Checked ? radioMale.Text : radioFmale.Text;
                DateTime ngaySinh = this.dateTimeKOL.Value;
                string diaChi = cboDiaChi.Text;
                string sdt = txbSDT.Text;
                int gia = int.Parse(txbGia.Text);
                KOL kol = new KOL(id, name, gioiTinh, ngaySinh, diaChi, sdt, gia);
                if (modify.updateDataKOL(kol))
                {
                    dataGridView1.DataSource = modify.getData();
                }
                else
                {
                    MessageBox.Show("Lỗi không sửa đươc");
                }
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gioiTinh = radioMale.Checked ? radioMale.Text : radioFmale.Text;
            index = dataGridView1.CurrentCell.RowIndex;
            if (index != -1)
            {
                txbID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txbName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
               
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "select * from KOL where MaKOL like '%" + txbTimKiem.Text.Trim() + "%'";
            dataGridView1.DataSource = modify.BindData(query);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.BindData("select * from KOL");
        }
    }
}
