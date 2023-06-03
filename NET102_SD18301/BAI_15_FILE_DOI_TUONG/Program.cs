using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_15_FILE_DOI_TUONG
{
    /*
     1) Tạo Class Student gồm các thuộc tính: ID – string, Ten – string, Ns– int, Nganh - string inThongTin():void - (Đối với class Private các
        thuộc tính, Property, Constructor có tham số và không tham số) - (1 điểm)
     2) Tạo Class SERVICE sử dụng List<Student>, code các chức năng tại đây như (0.5 điểm)
     3) Program.cs Tạo Menu sử dụng SwitchCase và gán các chức năng bên Class SERVICE sang. Viết chương trình thực hiện việc quản lý như menu sau (Switch Case – Loop): (1.5 điểm)
        1. Nhập 1 danh sách đối tượng (1đ)
        2. Xuất danh sách đối tượng (1đ )
        3. Lưu File - Đọc File danh sách đối tượng(2 đ)
        4. Nhập ID không được phép nhập chữ bắt và bắt nhập lại nếu vi phạm (1 điểm)
        5. Có áp dụng được 2 Câu LINQ(2 điểm)
    */
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
            //Guid
            SERVICE service = new SERVICE();
            List<Student> lstStudent = new List<Student>()
            {
                new Student("PH1", "Hoang", 2004, "PTPM"),
                new Student("PH2", "Anh", 2000, "PTPM"),
                new Student("PH3", "Mai", 2006, "PTPM"),
                new Student("PH4", "Tuan", 2001, "PTPM"),
                new Student("PH5", "Long", 2002, "PTPM"),
            };
            //nếu file tồn tại
            string path = @"D:\FPT Polytechnic\FPL-4. SUM 2023\Block 1\4-SD18301-NET102\NET102_SD18301\SUM23-BL1-NET102-SD18301\NET102_SD18301\BAI_15_FILE_DOI_TUONG\FileStudent.txt";
           
           // string path = "Student.txt";
            //file mới được tạo rỗng
            File.WriteAllText(path, "");

            int chon;
            do
            {
                Console.WriteLine("----------MENU--------");
                Console.WriteLine("1. Nhập DS");
                Console.WriteLine("2. Xuất DS");
                Console.WriteLine("3. Ghi file");
                Console.WriteLine("4. Đọc file");
                Console.WriteLine("0. Thoát CT");
                Console.WriteLine("----------------------");
                Console.WriteLine("--Mời chọn: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        service.NhapDS(lstStudent);
                        break;
                    case 2:
                        service.XuatDS(lstStudent);
                        break;
                    case 3:
                        service.GhiFile(path, lstStudent);
                        break;
                    case 4:
                        //BTVN
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Moi nhap lai!!!");
                        break;
                }
            } while (chon!=0);
        }
    }
}
