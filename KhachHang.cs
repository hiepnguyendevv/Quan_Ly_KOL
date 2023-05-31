using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTk
{
    class KhachHang
    {
        private string id;
        private string name;
        private string diaChi;
        private string sdt;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public KhachHang()
        {

        }

        public KhachHang(string id, string name, string diaChi, string sdt)
        {
            this.id = id;
            this.name = name;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }
    }
}
