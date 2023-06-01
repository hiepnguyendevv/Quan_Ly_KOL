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
    public partial class HopDong : Form
    {
        public HopDong()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void HopDong_Load(object sender, EventArgs e)
        {

            dataGrid_Lich.DataSource = modify.BindData("select KOL.TenKOL,KOL.SoDienThoai,KOL.GiaCoc, ChiTietCongViec.ThoiGian from KOL inner join ChiTietCongViec on ChiTietCongViec.MaKOL = KOL.MaKOL inner join KH on ChiTietCongViec.MaKH = KH.MaKH where KH.MaKH = '"+Home_KH.instance.lbMa.Text+"'");
        }
    }
}
