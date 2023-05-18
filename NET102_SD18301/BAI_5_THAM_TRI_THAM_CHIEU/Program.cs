using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_5_THAM_TRI_THAM_CHIEU
{
    internal class Program
    {
        #region Tham trị và Tham chiếu
        /*
         * Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu: 
            + Tham trị có nghĩa là truyền giá trị của biến. 
            Mọi xử lí tính toán trong phương thức khi kết thúc thì không làm thay đổi giá trị của biến tham số truyền vào
            + Tham chiếu có nghĩa là truyền trực tiếp địa chỉ ô nhớ của biến. 
            Chính vì thế mà mọi tính toán trong phương thức sẽ làm thay đổi giá trị của biến tham số truyền vào khi phương thức kết thúc
                Truyền tham chiếu chúng ta sử dụng từ khóa ref hoặc out
                   - Khi dùng ref biến phải được khởi tạo trước rồi mới truyền cho phương thức
                   - Khi dùng out biến không cần khởi tạo trước khi truyền vào phương thức. 
                     Nhưng bên trong phương thức bắt buộc phải gán giá trị cho biến
                   - Khi gọi và khi khai báo phương thức đều bắt buộc phải có kèm theo ref hoặc out trước tên biến muốn truyền.
         */
        #endregion
        
        static void HoanViThamTri(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"TRONG HoanViThamTri: a= {a}, b= {b}");
        }
        static void HoanViThamChieu(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void HoanViThamTri_Generic<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
            
        }
        static void HoanViThamChieu_Generic<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            Console.WriteLine($"Truoc HoanVi: a= {a}, b= {b}");

            HoanViThamTri(a, b);
            Console.WriteLine($"Sau HoanViThamTri: a= {a}, b= {b}");
            HoanViThamChieu(ref a, ref b);
            Console.WriteLine($"Sau HoanViThamChieu: a= {a}, b= {b}");

            string x = "Huyen";
            string y = "Xinh Gai";
            HoanViThamTri_Generic<string>(x, y);
            Console.WriteLine($"Sau HoanViThamTri_Generic: x= {x}, y= {y}");
            HoanViThamChieu_Generic<string>(ref x, ref y);
            Console.WriteLine($"Sau HoanViThamChieu_Generic: x= {x}, y= {y}");


        }
    }
}
