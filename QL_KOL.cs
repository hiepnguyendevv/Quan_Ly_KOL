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
    public partial class QL_KOL : Form
    {
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

            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
           
           string id  = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deleteDataKOL(id))
            {
                dataGridView1.DataSource =  modify.getData();
            }
            else
            {
                MessageBox.Show("Lỗi không xóa được");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = modify.BindData("select * from KOL");
            cboDiaChi.DataSource = listDiaChi;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string name = txbName.Text;
            string gioiTinh = radioMale.Checked ? radioMale.Text : radioFmale.Text;
            DateTime ngaySinh = this.dateTimeKOL.Value;
            string diaChi = cboDiaChi.Text;
            string sdt = txbSDT.Text;
            int gia = int.Parse(txbGia.Text);
            KOL kol = new KOL(id, name, gioiTinh, ngaySinh, diaChi, sdt,gia);
            if (checkTextBox())
            {
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

            string id = txbID.Text;
            string name = txbName.Text;
            string gioiTinh = radioMale.Checked ? radioMale.Text : radioFmale.Text;
            DateTime ngaySinh = this.dateTimeKOL.Value;
            string diaChi = cboDiaChi.Text;
            string sdt = txbSDT.Text;
            int gia = int.Parse(txbGia.Text);
            KOL kol = new KOL(id, name, gioiTinh, ngaySinh, diaChi, sdt,gia);
            if (modify.updateDataKOL(kol))
            {
                dataGridView1.DataSource = modify.getData();
            }
            else
            {
                MessageBox.Show("Lỗi không sửa đươc");
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
    }
}
