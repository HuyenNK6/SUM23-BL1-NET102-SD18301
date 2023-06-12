using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            int chon;
            Console.WriteLine(" 1. Nhập 1 đối tượng hoặc danh sách đối tượng\r\n" +
                   "2. Xuất danh sách đối tượng\r\n" +
                   "3. Lưu file đối tượng\r\n" +
                   "4. Đọc file đối tượng\r\nÁP DỤNG LINQ\r\n" +
                   "5. Sắp xếp giảm dần theo năm xuất bản\r\n" +
                   "6. Sắp xếp tăng dần theo giá\r\n" +
                   "7. Tìm kiếm sách theo Code\r\n" +
                   "8. Xóa Sách theo code\r\n" +
                   "9. Sửa thông tin của Sách theo code\r\n" +
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
