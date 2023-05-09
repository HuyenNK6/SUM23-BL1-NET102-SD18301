using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_OnTap_OOP
{
    internal abstract class DongVat
    {
        //1. thuộc tính
        private string ma;
        private string ten;
        private double canNang;
        private int gioiTinh; //1- đực, 2- cái

        //2. constructor
        //ctor + tab
        public DongVat()
        {

        }

        public DongVat(string ma, string ten, double canNang, int gioiTinh)
        {
            this.ma = ma;
            this.ten = ten;
            this.canNang = canNang;
            this.gioiTinh = gioiTinh;
        }
        //3. properties
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public double CanNang { get => canNang; set => canNang = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        //4. InThongTin()
        public virtual void InThongTin()
        {
            Console.Write($"{ma}| {ten}| {canNang}|" +
                $" {(gioiTinh == 1 ? "đực": "cái")}");
        }
        /*
         * Toán tử Ba ngôi
         * <Biểu thức> ? <KQ đúng> : <KQ sai>
         */
        public abstract void TiengKeu();
    }
}
