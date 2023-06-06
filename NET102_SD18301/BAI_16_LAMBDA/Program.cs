using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_16_LAMBDA
{
    internal class Program
    {
        /*
       * Biểu thức lambda còn gọi là biểu thức (Anonymous), 
       * một biểu thức khai báo giống phương thức nhưng thiếu tên. 
       * Cú pháp để khai báo biểu thức lambda là sử dụng toán tử lambda => 
       * như sau:
        - Công thức 1:
            (tham_số) => biểu_thức;
        - Công thức 2:
            (tham_số) =>
                {
                   các câu lệnh
                   Sử dụng return nếu có giá trị trả về
                }            
       */
        #region VD1: Sử dụng Delegate vs Lambda
        public delegate int PhepTinh(int x, int y);
        public static int PhepCong(int a, int b)
        {
            return a + b;
        }
        public static int PhepTru(int a, int b) => a - b;
        public static void ViDu1()
        {
            int x = 4;
            int y = 5;
            PhepTinh pt1 = PhepCong;
            pt1(x, y);
            PhepTinh pt2 = PhepTru;
            pt2(x, y);
            //áp dụng lambda trực tiếp mà ko cần phải khai báo bên ngoài
            //-> có thể triển khai nhanh
            PhepTinh pt3 = (int a, int b) =>
            {
                return a / b; //4/5
            };
            Console.WriteLine(pt3(x,y));
            PhepTinh pt4 = (int a, int b) => a * b;
            Console.WriteLine(pt4(x,y));
        }
        #endregion

        #region VD2: duyệt mảng
        public static void ViDu2()
        {
            int[] arrNumbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("------------");
            foreach (var item in arrNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            //dùng anonymous func
            Array.ForEach(arrNumbers, delegate (int x) { Console.WriteLine(x); });
            Console.WriteLine("------------");
            //dùng lambda exp
            Array.ForEach(arrNumbers, x => Console.WriteLine(x));
        }
        #endregion
        static void Main(string[] args)
        {
            ViDu1();
            ViDu2();
        }
    }
}
