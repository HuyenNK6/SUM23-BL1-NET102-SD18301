using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_OnTap_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            Cho cho1 = new Cho();
            cho1.Ma = "CH1";
            cho1.Ten = "Titi";
            cho1.CanNang = 5;
            //cho1.GioiTinh = 2;
            cho1.Loai = "Poodle";
            cho1.InThongTin();
            cho1.TiengKeu();
        }
    }
}
/*
 * BTVN: 
 * 1. Xây dựng class ChoService.cs
 * - Tạo List <Cho>
 * 2. Trong Program.cs, tạo Menu (có vòng lặp)
 * Menu gọi các chức năng bên ChoService sang:
 * - Nhập danh sách
 * - Xuất danh sách
 * - Tìm kiếm theo mã
 * - Liệt kê tất cả con chó có giới tính cái
 * - Sửa cân nặng
 * - Sắp xếp tăng dần theo cân nặng
 * - Xóa khỏi danh sách
 */
