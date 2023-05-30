using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_FILE
{
    internal class Program
    {
        #region Phần 1: THAO TÁC VỚI TẬP TIN VÀ THƯ MỤC
        /*
         * 1. SYSTEM.IO NAMESPACE
         *      + ❑System.IO Namespace có các lớp khác nhau được sử dụng để thực hiện nhiều hoạt động với các tập tin, chẳng hạn như việc tạo và xóa các tập tin, đọc hoặc viết vào một tập tin, đóng một tập tin.
                + ❑Một tập tin là một tập hợp các dữ liệu được lưu trữ trong một đĩa với một tên cụ thể và một đường dẫn thư mục. Khi một tập tin được mở để đọc hoặc viết, nó sẽ trở thành một luồng tin.
           2.System.IO namespace có nhiều lớp đa dạng mà được sử dụng để thực hiện các hoạt động khác nhau với File, như tạo và xóa file, đọc và ghi một File, đóng một File, …    
                + Bảng sau hiển thị một số lớp non-abstract được sử dụng phổ biến trong System.IO namespace trong C#:
                       - BinaryReader	Đọc dữ liệu gốc (primitive data) từ một binary stream
                       - BinaryWriter	Ghi dữ liệu gốc trong định dạng nhị phân
                       - BufferedStream	Một nơi lưu giữ tạm thời cho một stream
                       - Directory	Giúp ích trong việc thao tác một cấu trúc thư mục
                       - DirectoryInfo	Được sử dụng để thực hiện các hoạt động trên các thư mục
                       - DriveInfo	Cung cấp thông tin cho các Drive
                       - File	Giúp ích trong việc thao tác các File
                       - FileInfo	Được sử dụng để thực hiện các hoạt động trên các File
                       - FileStream	Được sử dụng để đọc và ghi bất kỳ vị trí nào trong một File
                       - MemoryStream	Được sử dụng để truy cập ngẫu nhiên tới stream được lưu giữ trong bộ nhớ
                       - Path	Thực hiện các hoạt động trên thông tin path
                       - StreamReader	Được sử dụng để đọc các ký tự từ một stream
                       - StreamWriter	Được sử dụng để ghi các ký tự tới một stream
                       - StringReader	Được sử dụng để đọc từ một string buffer
                       - StringWriter	Được sử dụng để ghi vào một string buffer  
         */
        #endregion

        #region Demo DirectoryInfo
        static void DemoDirectoryInfo()
        {
            //DirectoryInfo  chứa các phương thức để tạo, xóa,..
            //trên các thư mục và thư mục con bên trong

            //1. Tạo thư mục
            //using System.IO;
            DirectoryInfo di = new DirectoryInfo(@"D:\lienminh\huyenthoai");
            //nếu chưa tồn tại thì sẽ tạo mới
            if (!di.Exists)
            {
                di.Create();
            }
            Console.WriteLine("-------Directory Information------");
            Console.WriteLine($"Fullname = {di.FullName}");
            Console.WriteLine($"Name = {di.Name}");
            Console.WriteLine($"Parent= {di.Parent}");
            Console.WriteLine($"Root= {di.Root}");
            Console.WriteLine($"Attributes= {di.Attributes}");
            Console.WriteLine($"CreationTime= {di.CreationTime}");

            //2. tạo thư mục con
            di.CreateSubdirectory("tuong");
            di.CreateSubdirectory(@"tuong\skill");

            //3. xóa thư mục
            Console.WriteLine("Are u sure to delete??");
            string dele = Console.ReadLine();
            if (dele.Equals("yes"))
            {
                Directory.Delete(di.FullName, true);
                Console.WriteLine("Delete successfully!!");
            }

        }
        #endregion

        #region Demo FileReadWrite
        static void DemoFileReadWrite()
        {
            //lấy đường dẫn của file txt
            string path = @"D:\FPT Polytechnic\FPL-4. SUM 2023\Block 1\4-SD18301-NET102\NET102_SD18301\SUM23-BL1-NET102-SD18301\NET102_SD18301\BAI_14_FILE\FreeFire.txt";
            //string result = File.ReadAllText(path);

            //tạo nội dung
            string content = "Sống dai là huyền thoại \nLửa chùa là rác";
            //ghi nội dung vào file txt
            File.WriteAllText(path, content);
            //tạo biến result để hứng kết quả từ việc đọc file
            string result = File.ReadAllText(path);
            //in dữ liệu
            Console.WriteLine(result);

            //cách 2: đọc theo từng dòng
            string[] lines= File.ReadAllLines(path);
            Console.WriteLine(lines[1]);
            Console.WriteLine(string.Join("\n++", lines));

            //Nếu file chưa tồn tại -> tạo 1 file trong thư mục bin
            string noiDung = "72 phép thần thông";
            File.WriteAllText("BiKip.txt", noiDung);
            
            string noiDung2 = "7749 phép thần thông";
            File.WriteAllText("BiKip.txt", noiDung2);
            
            string noiDung3 = "\n4953 phép thần thông\n";
            File.AppendAllText("BiKip.txt", noiDung3);

            string ketQua = File.ReadAllText("BiKip.txt");
            Console.WriteLine(ketQua);

            //////
            Console.WriteLine("------------------");
            string[] contents = { "Đấm", "Đá", "Đập", "Múc" };
            File.AppendAllLines("BiKip.txt", contents);
            string ketQua2 = File.ReadAllText("BiKip.txt");
            Console.WriteLine(ketQua2);
        }

        #endregion



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            DemoDirectoryInfo();
            //DemoFileReadWrite();

        }
    }
}
