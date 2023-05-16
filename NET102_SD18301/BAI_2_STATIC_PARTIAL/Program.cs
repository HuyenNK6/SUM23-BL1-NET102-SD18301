using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_STATIC_PARTIAL
{
    internal class Program
    {
        #region Static
        /*
         * Đặc điểm của thành viên tĩnh:
            ❖Được khởi tạo 1 lần duy nhất ngay khi biên dịch
            chương trình.
            ❖Có thể dùng chung cho mọi đối tượng.
            ❖Được gọi thông qua tên lớp.
            ❖Được huỷ khi kết thúc chương trình.
          ❑Có 4 loại thành viên tĩnh chính:
            ❖Biến tĩnh (static variable).
            ❖Phương thức tĩnh (static method).
            ❖Phương thức khởi tạo tĩnh (static constructor).
            ❖Lớp tĩnh (static class)
         */
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            SinhVien sv1 = new SinhVien("PH123", "Nam");
            sv1.InThongTin();
            SinhVien sv2 = new SinhVien("PH456", "Tuan");
            sv2.InThongTin();

            //sử dụng phương thức tĩnh
            ////=> không cần phải khởi tạo đối tượng
           // SinhVien.InThongTin();
            SinhVien.StaticMethod();

            float pi = MyMath.PI;
            string quocGia = MyMath.quocGia;
            int pow = MyMath.pow(3);
            Console.WriteLine("pow= "+ pow);

        }
    }
}
