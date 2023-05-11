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

            Menu();
            //Cho cho1 = new Cho();
            //cho1.Ma = "CH1";
            //cho1.Ten = "Titi";
            //cho1.CanNang = 5;
            ////cho1.GioiTinh = 2;
            //cho1.Loai = "Poodle";
            //cho1.InThongTin();
            //cho1.TiengKeu();

            //string s1 = "abc";
            //string s2 = "10";
            //string sum = s1 + s2;
            ////ép kiểu từ string về số int
            //int n1= Convert.ToInt32(s1);
            //int n2= Convert.ToInt32(s2);
            //int tong = n1 + n2;
            //Console.WriteLine(tong);

        }
        static void Menu()
        {
            ChoService service = new ChoService();
            int chon;
            do
            {
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("1. Nhap DS");
                Console.WriteLine("2. Xuat DS");
                Console.WriteLine("3. Tim kiem");
                Console.WriteLine("4. Liet ke cai");
                Console.WriteLine("5. Sua can nang");
                Console.WriteLine("6. Sap xep tang dan theo can");
                Console.WriteLine("7. Xoa");
                Console.WriteLine("--------------------");
                Console.WriteLine("Moi chon: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        service.NhapDS();
                        //cách 2:
                        //service.Add();
                        break;
                    case 2:
                        service.XuatDS();
                        break;
                    case 3:
                        service.TimKiem();
                        break;
                    case 4:
                        service.LietKe();
                        //cách 2:
                        service.InChoCai();
                        break;
                    case 5:
                        service.Sua();
                        break;
                    case 6:
                        service.SapXep();
                        break;
                    case 7:
                        service.Xoa();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (chon != 0);
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
