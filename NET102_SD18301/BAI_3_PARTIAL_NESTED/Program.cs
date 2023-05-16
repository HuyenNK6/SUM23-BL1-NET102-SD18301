using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_PARTIAL_NESTED
{
    internal class Program
    {
        /* Vấn đề là ở chỗ, trước từ khóa class bạn gặp thêm từ khóa partial. 
         * Từ khóa này báo cho C# compiler rằng hai khai báo này thuộc về cùng một class Student. 
         * Chỉ là code được đặt trên hai file mã nguồn khác nhau. 
         * Khi dịch chương trình, C# compiler sẽ tự động ghép nối chúng lại thành một class duy nhất.*/
        /* Ngoài ra, khi sử dụng partial class cần lưu ý các vấn đề sau
             * Thứ nhất, các file mã nguồn của partial class phải nằm trong cùng một assembly (cùng trong một project)
             * Thứ hai, trong mỗi phần code của partial class, bạn không được khai báo các thành viên trùng nhau.
             * Thứ ba, mỗi phần của class bắt buộc phải có đủ hai từ khóa partial class.
         */
        static void Main(string[] args)
        {
            /*
            * Phần 1:  Sử dụng PartialClass
            * Khi sử dụng đối tượng ClassA hoàn toàn bình thường như các class đã được học chỉ khác nó được tách thành 2 file.
            */
            ClassA ca = new ClassA();
            ca.A = 5;
            ca.B = "FPT";
            ca.C = 2023;
            ca.D = "Poly";

            //Partial method chỉ có thể sử dụng bên trong partial class.
            //Không thể sử dụng partial method trong class thông thường.

            ca.Method1();
            //ca.Method2(); => vì Method2() là Partial method
            ca.Method3();


            /*
             * Phần 2: Sử dụng Class lồng nhau Nested
             ** Lớp Nested được khai báo, định nghĩa trong lớp Container, 
             * nếu phạm vi lớp public, thì bên ngoài sử dụng lớp con này 
             * bằng cách chỉ rõ Container.Nested
             */
            ClassNested.ClassC cc = new ClassNested.ClassC();
            cc.E = 2004;
            cc.Show();

        }
    }
}
