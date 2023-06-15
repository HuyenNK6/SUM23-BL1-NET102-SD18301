using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_18_DE_TONG_HOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            SachService service = new SachService();
            //đường dẫn các bạn tự tạo
            string path = @"D:\FPT Polytechnic\FPL-4. SUM 2023\Block 1\4-SD18301-NET102\NET102_SD18301\SUM23-BL1-NET102-SD18301\NET102_SD18301\BAI_18_DE_TONG_HOP\FileSach.txt";
            int chon;
            Console.WriteLine(" 1. Nhập 1 đối tượng hoặc danh sách đối tượng\r\n" +
                   "2. Xuất danh sách đối tượng\r\n" +
                   "3. Lưu file đối tượng\r\n" +
                   "4. Đọc file đối tượng\r\nÁP DỤNG LINQ\r\n" +
                   "5. Sắp xếp giảm dần theo năm xuất bản\r\n" +
                   "6. Sắp xếp tăng dần theo giá\r\n" +
                   "7. Tìm kiếm sách theo ID\r\n" +
                   "8. Xóa Sách theo ID\r\n" +
                   "9. Sửa thông tin của Sách theo ID\r\n" +
                   "10. Xuất danh sách các Sách có giá trong khoảng người dùng nhập\r\n" +
                   "11. Xuất danh sách các Sách được xuất bản sau năm 2000\r\n" +
                   "12. Tìm tất cả Sách có thể loại chính xác là Sách khoa học\r\n" +
                   "13. Tìm tất cả Sách có tên gần đúng (tên chứa) được nhập từ bàn phím\r\n" +
                   "14. Xuất thông tin của Sách có giá lớn nhất và bé nhất\r\n" +
                   "15. Đếm xem có tất cả bao nhiêu Sách có giá ngoài khoảng người dùng nhập\r\n" +
                   "16. Xuất danh sách 5 Sách mới được sản xuất\r\n" +
                   "0.Thoát ");
            do
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Mời chọn chức năng: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        service.NhapDS();
                        break;
                    case 2:
                        service.XuatDS();
                        break; 
                    case 3:
                        File.WriteAllText(path, "");
                        service.GhiFile(path);
                        break;
                    case 4:
                        List<Sach> lst= service.DocFile(path);
                        foreach (var item in lst)
                        {
                            item.InThongTin();
                        }
                        break;
                    case 5:
                        service.SapXepGiamDanTheoNamXB();
                        break;
                    case 6:
                        service.SapXepTangDanTheoGia();
                        break;
                    case 7:
                        service.TimKiemTheoID();
                        break;
                    case 8:
                        // service.XoaTheoID_Cach1();
                        service.XoaTheoID_Cach2();
                        break;
                    case 9:
                        service.SuaTheoID();
                        break;
                    case 13:
                        service.DSTheoTenGanDung();
                        break;
                    case 15:
                        service.DemGiaNgoaiKhoang();
                        break;
                    case 16:
                        service.Top5SachMoi();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Mời nhập lại!!!!!");
                        break;
                }
            } while (chon!=0);
        }
    }
}
