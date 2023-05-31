using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTk
{
    class KOL
    {
        private string id;
        private string name;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string sdt;
        private int giacoc;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Giacoc { get => giacoc; set => giacoc = value; }

        public KOL()
        {

        }

        public KOL(string id, string name, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt,int gia)
        {
            this.id = id;
            this.name = name;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.giacoc = gia;
        }
    }
}
