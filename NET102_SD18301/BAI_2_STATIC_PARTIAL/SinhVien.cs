using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_STATIC_PARTIAL
{
    internal class SinhVien
    {
        private string msv;
        private string ten;
        public static string truong = "Poly";

        //biến static là thuộc tính chung của mọi đối tượng của lớp SinhVien
        //Static constructor sẽ được gọi một lần duy nhất khi chương trình được nạp lên.
        static SinhVien()
        {
            Console.WriteLine("Đây là phương thức khởi tạo tĩnh");
        }
        public SinhVien()
        {

        }

        public SinhVien(string msv, string ten)
        {
            this.msv = msv;
            this.ten = ten;
        }
        public string Msv { get => msv; set => msv = value; }
        public string Ten { get => ten; set => ten = value; }

        public void InThongTin()
        {
            Console.WriteLine($"{msv}| {ten}| {truong}");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Đây là phương thức tĩnh");
        }
    }
}
