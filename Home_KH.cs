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
    public partial class Home_KH : Form
    {
        public static Home_KH instance;
        public Label lbMa;
        public Label lbTen;

        public Home_KH()
        {
            InitializeComponent();
            instance = this;
            lbMa = lbMaKH;
            lbTen = lbTenKH;
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
            openChildForm(new TaiKhoan_KH());
        }

        private void Home_KH_FormClosed(object sender, FormClosedEventArgs e)
        {

        }





        private void Home_KH_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.getConnection();

            string tk = DangNhap.instance.txbDn.Text;

            string query = "select KH.MaKH, KH.TenKH,.KH.DiaChi,KH.Sdt from TaiKhoan,KH where TaiKhoan.MaKH = KH.MaKH and TaiKhoan.TenTk='" + tk + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    lbMaKH.Text = dr["MaKH"].ToString();
                    lbTenKH.Text = dr["TenKH"].ToString();
                    lbDiaChi.Text = dr["DiaChi"].ToString();
                    lbSDT.Text = dr["Sdt"].ToString();
                }
            }
            conn.Close();

        }

        private void lbMaKH_Click(object sender, EventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            openChildForm(new HopDong());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void Home_KH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                DangNhap dn = new DangNhap();
                dn.Closed += (s, args) => this.Close();
                dn.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
