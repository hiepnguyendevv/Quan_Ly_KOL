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
    public partial class Home_QuanLy : Form
    {
        public Home_QuanLy()
        {
            InitializeComponent();
        }

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

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new QL_KH());
        }

        private void btnKOL_Click(object sender, EventArgs e)
        {
            openChildForm(new QL_KOL());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void Home_QuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }
    }
}
