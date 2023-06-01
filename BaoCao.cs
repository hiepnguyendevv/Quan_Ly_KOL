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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Modify modify = new Modify();
        private void BaoCao_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.BindData("select ChiTietCongViec.MaGD,KH.TenKH, KOL.TenKOL,KOL.GiaCoc , ChiTietCongViec.ThoiGian from ChiTietCongViec inner join KH on ChiTietCongViec.MaKH = KH.MaKH inner join KOL on ChiTietCongViec.MaKOL = KOL.MaKOL ");
        }
    }
}
