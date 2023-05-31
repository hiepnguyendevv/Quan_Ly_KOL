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
    public partial class QL_KH : Form
    {
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
            string id = txbID.Text;
            if (modify.deleteDataKH(id))
            {
                datagridViewKH.DataSource = modify.BindData("select * from KH");
            }
            else {
                MessageBox.Show("Lỗi không thêm được", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            //string query = "select * from KH where TenKH like'%" + txbTimKiem.Text + "%'";
            //modify.BindData(query);
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
