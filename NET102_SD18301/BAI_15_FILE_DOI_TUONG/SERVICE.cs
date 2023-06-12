using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_15_FILE_DOI_TUONG
{
    internal class SERVICE
    {
        public void NhapDS(List<Student> lstStudent)
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo
                Student st = new Student();
                //2. nhập tt
                Console.WriteLine("Nhập id: ");
                st.Id = Console.ReadLine();
                Console.WriteLine("Nhập tên: ");
                st.Ten = Console.ReadLine();
                Console.WriteLine("Nhập năm sinh: ");
                st.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập ngành: ");
                st.Nganh = Console.ReadLine();
                //3. thêm đối tượng vào ds
                lstStudent.Add(st);
                //4. hỏi tiếp tục
                Console.WriteLine("Co tiep tuc ko (co/ko)? ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));
        }
        public void XuatDS(List<Student> lstStudent)
        {
            if(lstStudent.Count == 0)
            {
                Console.WriteLine("Danh sách trống!!");
                return;
            }
            foreach (var item in lstStudent)
            {
                item.InThongTin();
            }
        }

        public void GhiFile(string path, List<Student> lstStudent)
        {
            if (File.Exists(path))
            {
                foreach (var item in lstStudent)
                {
                    //tạo ra 1 dòng để lưu thông tin của 1 item trong lstStudent
                    string line = item.ObjToString();
                    //thêm tiếp dòng mới này vào file
                    File.AppendAllText(path, line);
                }
                Console.WriteLine("Ghi file thành công!!!");
            }
            else
            {
                Console.WriteLine("File ko tồn tại!!!");
            }
        }
    
        //chỉ cần truyền tham số là path
        //sau khi đọc -> trả về cả 1 list student đầy đủ & chính xác
        public List<Student> DocFile(string path)
        {
            List<Student> lstStudent = new List<Student>();
            //đọc tất cả các dòng trong file txt
            string[] lines = File.ReadAllLines(path);
            //duyệt từng dòng line
            foreach (var line in lines)
            {
                if(line.Trim().Length == 0)
                {
                    continue;//bỏ qua vòng hiện tại -> vòng sau
                }
                else
                {
                    //cắt dòng line thành nhiều chuỗi con
                    //ngăn cách nhau bởi dấu |
                    string[] attributes = line.Split('|');
                    //test thử
                    //for (int i = 0; i < attributes.Length; i++)
                    //{
                    //    Console.WriteLine($"att[{i}]= {attributes[i]}");
                    //}
                    //mỗi dòng line là 1 student
                    Student st = new Student();
                    st.Id = attributes[0].Trim();
                    st.Ten = attributes[1].Trim();
                    st.NamSinh = Convert.ToInt32(attributes[2].Trim());
                    st.Nganh = attributes[3].Trim();
                    //thêm đối tượng vào danh sách
                    lstStudent.Add(st);
                }
            }
            return lstStudent;
        }
    
        public void SapXep()
        {

        }
        public int Count()
        {
            return 0;
        }
    }
}
