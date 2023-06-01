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
    public partial class KOL_Lich : Form
    {
        public KOL_Lich()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void KOL_Lich_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.BindData("select KH.TenKH,KH.Sdt,KOL.GiaCoc, ChiTietCongViec.ThoiGian from KOL inner join ChiTietCongViec on ChiTietCongViec.MaKOL = KOL.MaKOL inner join KH on ChiTietCongViec.MaKH = KH.MaKH where KOL.MaKOL ='" + Home_KOL.instance.lbMa.Text + "'");
        }
    }
}
