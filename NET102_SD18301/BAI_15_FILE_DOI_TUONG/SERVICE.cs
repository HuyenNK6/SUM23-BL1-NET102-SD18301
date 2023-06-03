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
    }
}
