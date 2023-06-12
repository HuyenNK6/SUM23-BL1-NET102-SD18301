using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            _lstSachs.Add(new Sach(100004,"Rùa và thỏ", "Truyện",2010,50000));
            _lstSachs.Add(new Sach(100005,"Vũ trụ", "Khoa học", 2023,80000));
            _lstSachs.Add(new Sach(100005,"Đắc nhân tâm", "Self-help", 2022,100000));
        }
        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo
                Sach s = new Sach();
                //2. nhập tt
                Console.Write("Nhập id: ");
                s.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập tên: ");
                s.Ten = Console.ReadLine();  
                Console.Write("Nhập thể loại: ");
                s.TheLoai = Console.ReadLine();
                Console.Write("Nhập năm xuất bản: ");
                s.NamXuatBan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập giá sách: ");
                s.Gia = Convert.ToDouble(Console.ReadLine());
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

    }
}
