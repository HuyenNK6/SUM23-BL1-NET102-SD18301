using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_GENERIC
{
    internal class Program
    {
        #region Generic
        /* 
         * Generic trong C# cho phép định nghĩa một phương thức,một lớp 
           mà không cần chỉ ra đối số kiểu dữ liệu là gì.
           Tuỳ vào kiểu dữ liệu mà người dùng truyền vào thì nó sẽ hoạt động theo kiểu dữ liệu đó
            - Generic cũng là một kiểu dữ liệu trong C# như int, string, bool,… 
                nhưng nó là một kiểu dữ liệu “tự do”, tùy vào mục đích sử dụng mà nó có thể đại diện 
                cho tất cả các kiểu dữ liệu còn lại.
            - Có thể định nghĩa lớp, interface, phương thức, delegate như là kiểu generic
            - Generic được đánh dấu bởi <>
                vd <T> thì T được xem là 1 kiểu dữ liệu

         * Ưu điểm: là có thể sử dụng 1 kiểu dữ liệu chung cho nhiều lớp,
           phương thức khác mà có cấu trúc code tương tự nhau trong khi chỉ cần viết 1 lần

         * Nhược điểm: của Generic là khi các kiểu dữ liệu khác nhau có các tương 
           tác hay cách sử dụng khác nhau thì áp dụng Generic sẽ có thể gây ra lỗi chương trình
         */
        #endregion
        //phương thức generic
        static void HienThi<T> (T temp)
        {
            Console.WriteLine($"Giá trị truyền vào là {temp}");
        }
        static void HienThi<T> (T a, T b)
        {
            Console.WriteLine($"Giá trị truyền vào là {a}, {b}");
        }
        static void HienThi<T, K> (T a, K b)
        {
            Console.WriteLine($"Giá trị truyền vào là {a}, {b}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            HienThi<int> (5);
            //HienThi (5);
            HienThi<string>("fpt", "fpoly");
            // HienThi<string>("fpt", 2023);
            HienThi <string, int>("fpt", 2023);
            //HienThi <string, int>( 2023, "fpt");
            ////////////////////////
            MyClass<double> mc = new MyClass<double>();
            mc.Variable = 8.4;
            mc.Show();
            double result = mc.Show();


        }
    }
}
