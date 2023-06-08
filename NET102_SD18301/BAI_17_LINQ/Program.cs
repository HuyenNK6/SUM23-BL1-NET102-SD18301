using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        static List<int> lstNumber = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //sửa tên => tổ hợp phím Ctrl R (2 lần) hoặc click chuột chọn Rename
        static List<Movie> lstMovies = new List<Movie>()
        {
            new Movie(Guid.NewGuid(), "Big Mouse", "Hanh dong", 2022,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "The Little Mermaid", "Lang man", 2020,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "Doreamon", "Hoat hinh", 2018,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "Fast & Furious", "Hanh dong", 2015,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "OnePice", "Kinh di", 2022,new List<string>(){"Huyen","Duc","Hung"}),
            new Movie(Guid.NewGuid(), "OnePice", "Tam ly", 2022,new List<string>(){"Huyen","Duc","Hung"}),
        };

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
            var list = from obj in arrName
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
            int min = lstNumber.Min();
            Console.WriteLine("min= " + min);

            var sum = (from num in lstNumber
                       where num > 5
                       select num).Sum();
            Console.WriteLine("Sum= " + sum);
            var agg = lstNumber.Aggregate((a, b) => a * b);//1*2*3*4*5*6.....
            Console.WriteLine("agg= " + agg);
            var concat = arrName.Aggregate((a, b) => a + "-" + b);
            Console.WriteLine("concat= " + concat);

            //Đếm tất cả phim có thể loại là phim Hành động
            //cách 1:
            //String.Compare(str1, str2, <bool ignoreCase>)
            //true -> ko phân biệt , false-> có phân biệt 
            var countHD = lstMovies.Where(
                             x => String.Compare(x.Type, "Hanh dong", true) == 0).Count();
            Console.WriteLine("1. Số lượng phim hành động : "+ countHD);
            //cách 2: 
            var countTheLoai = lstMovies.Count(m => m.Type.Equals("Hanh dong"));
            Console.WriteLine("2. Số lượng phim hành động : " + countTheLoai);

            //Tìm ra năm sản xuất mới nhất
            //In ra các bộ phim mới nhất
            //List<Movie> lstSortNewest = lstMovies.OrderByDescending(x => x.Year).ToList();
            //int newYear = lstSortNewest[0].Year;
            //var newYearFilm = lstMovies.Where(x => x.Year == newYear);
            //foreach (var item in newYearFilm)
            //{
            //    item.InThongTin();
            //}
            Console.WriteLine("---Phim mới nhất------------");
            var yearNewest = lstMovies.Max(m => m.Year);
            var movieNewest = lstMovies.Where(m => m.Year == yearNewest);
            foreach (var item in movieNewest)
            {
                item.InThongTin();
            }

        }
        #endregion

        #region  VD3: Sorting Operator in LINQ
        /*
         * Sorting Operators in LINQ dùng thay đổi thứ tự tăng dần hoặc giảm dần 
         * các phần tử trong tập hơp theo một hoặc nhiều tiêu chí
         */
        static void ViDu3()
        {
            //sử dụng OrderBy
            Console.WriteLine("---------Sắp xếp theo tên----------");
            var sortName = lstMovies.OrderBy(s => s.Name);
            //lstMovies[0].Id = Guid.Parse(Console.ReadLine());
            foreach (var item in sortName)
            {
                item.InThongTin();

            }
            //Linq Query
            Console.WriteLine("---------Sắp xếp theo thể loại----------");
            var sortType = from m in lstMovies
                           orderby m.Type descending
                           select m;
            //Type: thuộc tính của phim
            //ascending: tăng dần - descending: giảm dần
            foreach (var item in sortType)
            {
                item.InThongTin();
            }
            Console.WriteLine("---------Sắp xếp theo năm -> sau đó là thể loại----------");
            var sortYear_Type = lstMovies.OrderBy(a => a.Year).ThenByDescending(a => a.Type);
            foreach (var item in sortYear_Type)
            {
                item.InThongTin();
            }
        }
        #endregion

        #region VD4: Partition Operator
        /*
         * Take Partition Operator: 
         * Toán tử này sẽ lấy N phần tử đầu tiên trong một tập dữ liệu
         * 
         * TakeWhile Partition Operator:
         * Phương thức mở rộng TakeWhile trong LINQ 
         * trả về các phần tử từ phần tử đầu tiên cho đến khi một phần tử không thỏa mãn điều kiện. 
         * Nếu chính phần tử đầu tiên không thỏa mãn điều kiện thì trả về một danh sách trống.
         */
        static void ViDu4()
        {
            Console.WriteLine("-----Take---------");
            var takeMovie = lstMovies.Take(3);
            foreach (var item in takeMovie)
            {
                item.InThongTin();
            }
            Console.WriteLine("------Take while------");
            var takeWhileYear = lstMovies.TakeWhile(x => x.Year == 2022);
            foreach (var item in takeWhileYear)
            {
                item.InThongTin();
            }
            //skip - skip while
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //ViDu1();
            //ViDu2();
            //ViDu3();
            ViDu4();
        }
    }
}
