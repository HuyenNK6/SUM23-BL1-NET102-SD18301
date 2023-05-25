using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_OnTap_OOP
{
    internal class Cho : DongVat
    {
        private string loai;
        private double? canNang;
        public Cho()
        {
            Console.WriteLine("Đây là con chó");
            this.GioiTinh = 1;
        }

        public Cho(string ma, string ten, double canNang, int gioiTinh, string loai) : base(ma, ten, canNang, gioiTinh)
        {
            this.loai = loai;
        }

        public string Loai { get => loai; set => loai = value; }

        public override void TiengKeu()
        {
            Console.WriteLine("Gâu gâu");
        }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"| {loai}");
        }
    }
}
