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
    public partial class Home_KOL : Form
    {
        static public Home_KOL instance;
        public Label lbMa;
        public Home_KOL()
        {
            InitializeComponent();
            instance = this;
            lbMa = lbMaKOL;
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
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            openChildForm(new KOL_Lich());
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_KOL_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.getConnection();

            string tk = DangNhap.instance.txbDn.Text;

            string query = "select * from TaiKhoan,KOL where TaiKhoan.MaKOL= KOL.MaKOL and TaiKhoan.TenTk='" + tk + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    lbMaKOL.Text = dr["MaKOL"].ToString();
                    lbTenKOL.Text = dr["TenKOL"].ToString();
                    lbGioiTinh.Text = dr["GioiTinh"].ToString();
                    lbNs.Text = dr["NgaySinh"].ToString();
                    lbDiaChi.Text = dr["DiaChi"].ToString();
                    lbSDT.Text = dr["SoDienThoai"].ToString();
                }
            }
            conn.Close();
        }
    }
}
