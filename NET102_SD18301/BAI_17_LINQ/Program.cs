using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_17_LINQ
{
    internal class Program
    {
        #region LINQ là gì
        /*
       *  LINQ: Language Integrated Query
       *  Định nghĩa:  ngôn ngữ truy vấn tích hợp -
       *  nó tích hợp cú pháp truy vấn (gần giống các câu lệnh SQL) 
       *  vào bên trong ngôn ngữ lập trình C#, cho nó khả năng truy cập
       *  các nguồn dữ liệu khác nhau (SQL Db, XML, List ...) 
       *  với cùng cú pháp.
       * Ưu điểm:
       * ➢Ưu điểm lớn nhất của Linq đó chính là sự mạch lạc trong code, xậy dựng nhanh, ít gây lỗi
         ➢Linq cung cấp nhiều phương thức trong truy vấn dữ liệu, nếu cùng một chức năng, khi sử dụng truy vẫn thuần có thể phải code nhiều gấp 2, 3 lần khi sử dụng linq (tùy ứng dụng)
         ➢Cách tiếp cận khai báo giúp truy vấn dễ hiểu và gọn hơn
       * Nhược điểm:
       *➢Tốc độ chậm nếu viết linq không khéo
          Linq query syntax:
                              from object in datasource
                              where condition
                              select object
          from: Từ nguồn dữ liệu mà truy vấn sẽ thực hiện
          in: bên trong nguồn giá trị nào
          datasource: tập giá trị nguồn
          where: lọc dữ liệu theo điều kiện condition
          select object: Lấy ra kết quả có thể là giá trị hoặc tập giá trị
          Ngoài ra chúng ta cũng thấy việc áp dụng lambda cơ bản với những câu lọc dữ liệu ngắn sẽ đơn giản nhưng khi join vào nhiều datasource sẽ không dễ đọc với người chưa có kinh nghiệm
       */
        #endregion
        //Data source
        static string[] arrName = { "Hoang", "Hoa", "Luc", "Long", "Tuan", "Nam", "Tung" };
        static List<int> arrNumber = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
        #region VD1: LINQ QUERY
        static void ViDu1()
        {
            Console.WriteLine("-----StartWith-----");
            foreach (var item in arrName)
            {
                if (item.StartsWith("T"))
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("--------------------");
            //Linq query
            var list= from obj in arrName
                      where obj.StartsWith("T")
                      select obj;
            //query execute
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arrName.ToList().Where(n => n.StartsWith("T")))
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region VD2: Aggregate Function
        /* Aggregate Function được dùng trong các trường hợp tính toán 
          * một giá trị tổng hợp từ một tập các giá trị
          * Một số phương thức thông dụng: Min, Max, Sum, Count, Aggregate…
          */
        static void ViDu2()
        {
            int min = arrNumber.Min();
            Console.WriteLine("min= "+ min);

            var sum = (from num in arrNumber
                       where num > 5
                       select num).Sum();
            Console.WriteLine("Sum= "+ sum);
            var agg = arrNumber.Aggregate((a, b) => a * b);//1*2*3*4*5*6.....
            Console.WriteLine("agg= "+ agg);
            var concat = arrName.Aggregate((a, b) => a + "-" + b);
            Console.WriteLine("concat= "+ concat);
        }
        #endregion

        static List<Movie> lstMovies = new List<Movie>()
        {
            new Movie(Guid.NewGuid(), "Big Mouse", "Hanh dong", 2022,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "The Little Mermaid", "Lang man", 2020,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "Doreamon", "Hoat hinh", 2018,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "Fast & Furious", "Hanh dong", 2015,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "OnePice", "Kinh di", 2022,new List<string>(){"Huyen","Duc","Hung"}),
        };
        #region  VD3: Sorting Operator in LINQ
        /*
         * Sorting Operators in LINQ dùng thay đổi thứ tự tăng dần hoặc giảm dần 
         * các phần tử trong tập hơp theo một hoặc nhiều tiêu chí
         */
        static void ViDu3()
        {
            var sortName = lstMovies.OrderBy(s => s.Name);
            foreach (var item in sortName)
            {
                item.InThongTin();
            }
            //Linq Query
            //......
        }
        #endregion  
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //ViDu1();
            //ViDu2();
            ViDu3();
        }
    }
}
