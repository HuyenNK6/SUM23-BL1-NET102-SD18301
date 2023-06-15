using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAI_18_DE_TONG_HOP
{
    internal class SachService
    {
        List<Sach> _lstSachs = new List<Sach>();
        public SachService()
        {           
            _lstSachs.Add(new Sach(100001,"Hạt giống tâm hồn", "Self-help",2019,90000));
            _lstSachs.Add(new Sach(100002,"Phân tích kỹ thuật", "Khoa học",2021,120000));
            _lstSachs.Add(new Sach(100003, "The Discoverers", "Khoa học", 2015,150000));
            //_lstSachs.Add(new Sach(100004, "Rùa và thỏ", "Truyện", 2010, 50000));
            //_lstSachs.Add(new Sach(100005, "Vũ trụ", "Khoa học", 2023, 80000));
            //_lstSachs.Add(new Sach(100006, "Đắc nhân tâm", "Self-help", 2022, 100000));
        }
        //delegate kết hợp generic

        public delegate string Check<T>(T a, T b);
       
        public static string CheckInput(string msg, string regex)
        {
            string input;
            do
            {
                Console.WriteLine("Mời nhập "+msg+": ");
                input = Console.ReadLine();
                if(!Regex.IsMatch(input, regex))
                {
                    Console.WriteLine("Mời nhập lại!!!!!");
                }
            } while (!Regex.IsMatch(input, regex));
            return input;
        }

        public void NhapDS()
        {
            Check<string> check = CheckInput;
            string tiepTuc;
            do
            {
                //1. khởi tạo
                Sach s = new Sach();
                //2. nhập tt
                //ID chỉ gồm 6 số
                s.Id = Convert.ToInt32(CheckInput("ID", @"^[0-9]{6}$"));
                s.Ten = CheckInput("tên", @"^[a-zA-Z0-9\\s]+$");
                //Console.Write("Nhập id: ");
                //s.Id = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Nhập tên: ");
                //s.Ten = Console.ReadLine();  
                Console.Write("Nhập thể loại: ");
                s.TheLoai = Console.ReadLine();
                Console.Write("Nhập năm xuất bản: ");
                s.NamXuatBan = Convert.ToInt32(Console.ReadLine());
                //số double có 2 phần: phần nguyên và phần thập phân
                s.Gia = Convert.ToDouble(check("giá", @"^[0-9]+\.?[0-9]*$"));
                //Console.Write("Nhập giá sách: ");
                //s.Gia = Convert.ToDouble(Console.ReadLine());
                //3. thêm đối tượng vào ds
                _lstSachs.Add(s);
                //4. hỏi tiếp tục
                Console.WriteLine("Co tiep tuc ko (co/ko)? ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));
        }
        public void XuatDS()
        {
            if (_lstSachs.Count == 0)
            {
                Console.WriteLine("Danh sách trống!!");
                return;
            }
            foreach (var item in _lstSachs)
            {
                item.InThongTin();
            }
        }

        public void GhiFile(string path)
        {
            if (File.Exists(path))
            {
                foreach (var item in _lstSachs)
                {
                    string line = item.ObjToString();
                    File.AppendAllText(path, line);
                }
                Console.WriteLine("Ghi file thành công!!!");
            }
            else
            {
                Console.WriteLine("File ko tồn tại!!!");
            }
        }
        public List<Sach> DocFile(string path)
        {
            List<Sach> list = new List<Sach>();
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (line.Trim().Length == 0)
                {
                    continue;
                }
                else
                {
                    string[] attributes = line.Split('|');
                
                    Sach s = new Sach();
                    s.Id = Convert.ToInt32(attributes[0].Trim());
                    s.Ten = attributes[1].Trim();
                    s.TheLoai = attributes[2].Trim();
                    s.NamXuatBan = Convert.ToInt32(attributes[3].Trim());
                    s.Gia = Convert.ToDouble(attributes[4].Trim());

                    list.Add(s);
                }
            }
            return list;
        }

        //5. Sắp xếp giảm dần theo năm xuất bản
        public void SapXepGiamDanTheoNamXB()
        {
            //sorting operator in LINQ
            _lstSachs = _lstSachs.OrderByDescending(s => s.NamXuatBan).ToList();
            XuatDS();
        }

        //"6. Sắp xếp tăng dần theo giá\r\n" +
        public void SapXepTangDanTheoGia()
        {
            //danh sách
            var result = from s in _lstSachs
                         orderby s.Gia 
                         select s;
            foreach (var item in result)
            {
                item.InThongTin();
            }
        }
        //           "7. Tìm kiếm sách theo id\r\n" +
        public void TimKiemTheoID()
        {
            Console.WriteLine("Nhập ID cần tìm: ");
            int id = Convert.ToInt32(Console.ReadLine());
            /* Method FirstOrDefault sẽ trả về phần tử đầu tiên của collection theo điều kiện, 
             * Nếu không có phần tử thoả mãn, 
             * kết quả trả về sẽ là default value type của object(thường là null)
             */
            //chỉ ra 1 kết quả
            var resultSearch = (from s in _lstSachs
                               where s.Id == id
                               select s).FirstOrDefault();
            if(resultSearch != null)
            {
                resultSearch.InThongTin();
            }
            else //resultSearch == null
            {
                Console.WriteLine("Không tìm thấy!!");
            }
           
        }
        //           "8. Xóa Sách theo ID\r\n" +
        //cách 1: tìm đối tượng -> xóa
        //cách 2: tìm vị trí -> xóa
        public void XoaTheoID_Cach1()
        {
            Console.WriteLine("Nhập ID cần xóa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            //kết quả là 1 đối tượng Sách đầu tiên tìm thấy
            var resultSearch = (from s in _lstSachs
                                where s.Id == id
                                select s).FirstOrDefault();
            if (resultSearch != null)
            {
                _lstSachs.Remove(resultSearch); //xóa theo đối tượng
                Console.WriteLine("Đã xóa thành công!!");
            }
            else //resultSearch == null
            {
                Console.WriteLine("Không tìm thấy!!");
            }
        }
        public void XoaTheoID_Cach2()
        {
            Console.WriteLine("Nhập ID cần xóa: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var index = _lstSachs.FindIndex(s => s.Id == id);

            if (index != -1)
            {
                _lstSachs.RemoveAt(index);// xóa theo vị trí
                Console.WriteLine("Đã xóa thành công!!");
            }
            else //resultSearch == null
            {
                Console.WriteLine("Không tìm thấy!!");
            }
        }

        //           "9. Sửa thông tin của Sách theo ID\r\n" + -> sửa 1 thông tin nào đó trừ ID
        public void SuaTheoID()
        {
            Console.WriteLine("Nhập ID cần sửa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var resultSearch = (from s in _lstSachs
                                where s.Id == id
                                select s).FirstOrDefault();
            if (resultSearch != null)
            {
                Console.WriteLine("Trước khi sửa: ");
                resultSearch.InThongTin();
                Console.WriteLine("Mời nhập giá mới: ");
                resultSearch.Gia = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Sau khi sửa: ");
                resultSearch.InThongTin();
            }
            else //resultSearch == null
            {
                Console.WriteLine("Không tìm thấy!!");
            }

        }
        //           "10. Xuất danh sách các Sách có giá trong khoảng người dùng nhập\r\n" + -> min- max
        //           "11. Xuất danh sách các Sách được xuất bản sau năm 2000\r\n" +
        //           "12. Tìm tất cả Sách có thể loại chính xác là Sách khoa học\r\n" + -> equal, String.compare
        //           "13. Tìm tất cả Sách có tên gần đúng (tên chứa) được nhập từ bàn phím\r\n" + -> contain
        //bắt đầu =... -> startwith..
        public void DSTheoTenGanDung()
        {
            Console.WriteLine("Nhập tên cần tìm: ");
            string input = Console.ReadLine();
            var tenGanDung = _lstSachs.Where(s => s.Ten.Contains(input)).ToList();
            if(tenGanDung.Count ==0)
            {
                Console.WriteLine("Không tìm thấy!!");
            }
            else
            {
                foreach (var item in tenGanDung)
                {
                    item.InThongTin();
                }
            }
        }
        //           "14. Xuất thông tin của Sách có giá lớn nhất và bé nhất\r\n" +
        //         "15. Đếm xem có tất cả bao nhiêu Sách có giá ngoài khoảng người dùng nhập\r\n" +
        public void DemGiaNgoaiKhoang()
        {
            Console.WriteLine("Nhập giá min: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập giá max: ");
            double max = Convert.ToDouble(Console.ReadLine());
            //cách 1:
            var count = _lstSachs.Where(s => s.Gia < min || s.Gia > max).Count();
            //cách 2:
            var dem = _lstSachs.Count(s => s.Gia < min || s.Gia > max);

            if(count == 0)
            {
                Console.WriteLine("Không có kết quả phù hợp!!");
            }
            else
            {
                Console.WriteLine($"Có tất cả {count} sách ngoài khoảng {min}-{max}");
                Console.WriteLine($"Có tất cả {dem} sách ngoài khoảng {min}-{max}");
            }
        }

        //         "16. Xuất danh sách 5 Sách mới được sản xuất\r\n" +
        public void Top5SachMoi()
        {
            //cách thuần
            //sắp xếp giảm dần -> top 5 thằng đầu tiên
            //nó đúng nếu count > 5
            //nó lỗi nếu count < 5
            Console.WriteLine("Cách 1: ");
            List<Sach> lstResult = _lstSachs.OrderByDescending(x => x.NamXuatBan).ToList();
            for (int i = 0; i < 5 && i < _lstSachs.Count; i++)
            {
                lstResult[i].InThongTin();
            }
            Console.WriteLine("Cách 2: ");
            //Toán tử này sẽ lấy N phần tử đầu tiên trong một tập dữ liệu
            var a = _lstSachs.OrderByDescending(x => x.NamXuatBan).Take(5).ToList();
            foreach (var item in a)
            {
                item.InThongTin();
            }
        }
    }
}
