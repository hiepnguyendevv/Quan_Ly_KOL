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
    public partial class Home_KH : Form
    {
        public static Home_KH instance;
        public Home_KH()
        {
            InitializeComponent();
            instance = this;
        }
        Modify modify = new Modify();

        private Form currentChildForm;

        public void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            openChildForm(new Booking());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void Home_KH_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn rời khỏi","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGird_TTKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Home_KH_Load(object sender, EventArgs e)
        {
            
            string tk = DangNhap.instance.txbDn.Text;
            

            DataGridView dataGrid_TTKH = new DataGridView();
            
            dataGrid_TTKH.DataSource = modify.BindData("select KH.MaKH, KH.TenKH,.KH.DiaChi,KH.Sdt from TaiKhoan,KH where TaiKhoan.MaKH = KH.MaKH and TaiKhoan.TenTk='"+tk+"'");
        
            

            //dataGrid_TTKH.Columns[0].Name = "MaKH";
            //dataGrid_TTKH.Columns[1].Name = "TenKH";
            //dataGrid_TTKH.Columns[2].Name = "DiaChi";
            //dataGrid_TTKH.Columns[3].Name = "Sdt";

            //dataGrid_TTKH.Columns[0].DataPropertyName = "MaKH";
            //dataGrid_TTKH.Columns[1].DataPropertyName = "TenKH";
            //dataGrid_TTKH.Columns[2].DataPropertyName = "DiaChi";
            //dataGrid_TTKH.Columns[3].DataPropertyName = "Sdt";

            if (dataGrid_TTKH.DataSource != null)
            {
                lbMaKH.Text = dataGrid_TTKH.Rows[0].Cells[0].Value.ToString();
                lbTenKH.Text = dataGrid_TTKH.Rows[0].Cells[1].Value.ToString();
                lbDiaChi.Text = dataGrid_TTKH.Rows[0].Cells[2].Value.ToString();
                lbSDT.Text = dataGrid_TTKH.Rows[0].Cells[3].Value.ToString();
            }

            
        }
    }
}
