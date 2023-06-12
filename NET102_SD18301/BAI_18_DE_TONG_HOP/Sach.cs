using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_18_DE_TONG_HOP
{
    internal class Sach
    {
        private int id;
        private string ten;
        private string theLoai;
        private int namXuatBan;
        private double gia;

        public Sach()
        {

        }

        public Sach(int id, string ten, string theLoai, int namXuatBan, double gia)
        {
            this.id = id;
            this.ten = ten;
            this.theLoai = theLoai;
            this.namXuatBan = namXuatBan;
            this.gia = gia;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int NamXuatBan { get => namXuatBan; set => namXuatBan = value; }
        public double Gia { get => gia; set => gia = value; }

        public void InThongTin()
        {
            Console.WriteLine($"{id}|{ten}|{theLoai}|{namXuatBan}|{gia}");
        }
        public string ObjToString()
        {
            return $"{id}|{ten}|{theLoai}|{namXuatBan}|{gia}\n";
        }
    }
}
