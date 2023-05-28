using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12_ANONYMOUS
{
    internal class Program
    {

        #region ANONYMOUS TYPED
        /*
         * Phần 1:  Định nghĩa:
             * ❑Kiểu ẩn danh (Anonymous Type) cung cấp một cách thuận tiện để đóng gói (encapsulate) 
             * một tập các thuộc tính chỉ đọc (read-only properties) vào một đối tượng 
             * mà không cần phải xác định rõ ràng loại (type) của nó ngay lúc viết code
             * ❑Cho phép tạo type mới (user-defined) mà không cần xác định tên của nó
               ❑Tạo các type ẩn danh này bằng cách sử dụng toán tử new

           Phần 2: ANONYMOUS METHOD
            ❑Phương thức vô danh (anonymous method) là một phương thức:
               ❖Không cần khai báo tên phương thức khi định nghĩa phương thức
               ❖Có thể khai báo trực tiếp ở chỗ cần dùng, không cần định nghĩa trước
               ❖Đươc dùng như tham số của delegate

            ❑Một số giới hạn Anonymous methods
                ❖Không khai báo được các lệnh goto, break or continue bên trong phương thức
                ❖Không truy cập được các tham số ref hoặc out bên ngoài
                ❖Phải được dùng kết hợp với delegate
         */
        #endregion
        //khai báo delegate
        public delegate void DelegateMethod(int i);
        //=> Action <int> 
        public static void Method1(int temp)
        {
            Console.WriteLine("Gia tri= " + temp);
        }
        static void Main(string[] args)
        {
            #region Phần 1: Khai báo Anonymous
            var student = new
            {
                id = "ph123",
                name = "mai anh",
                score = 9,
                subject = "Csharp"
            };
            Console.WriteLine($"{student.id} | {student.name}| " +
                              $"{student.score} | {student.subject}");
            method(student, student.name);
            #endregion

            #region Phần 2: Khai báo Anonymous lồng nhau
            var studentUDPM = new
            {
                id = "ph123",
                name = "mai anh",
                score = 9,
                subject = "Csharp",
                address = new
                {
                    xa = "Thach Hoa",
                    huyen = "Thach That",
                    thanhPho = "Ha Noi",
                    nuoc = "Viet Nam"
                }
            };
            Console.WriteLine($"{studentUDPM.id} | {studentUDPM.name}| " +
                              $"{studentUDPM.score} | {studentUDPM.subject}| " +
                              $"{studentUDPM.address.thanhPho} ");
            #endregion

            #region Phần 3: Phương thức Anonymous
            //DelegateMethod dg = Method1;
            //DelegateMethod dg = delegate (int temp)
            Action<int> dg = delegate (int temp)
            {
                Console.WriteLine("Day la phuong thuc an danh");
                Console.WriteLine("Gia tri= " + temp);
            };
            dg(2023); //gọi đến phương thức ẩn danh

            #endregion
        }

        static void method(dynamic x, dynamic y)
        {
            Console.WriteLine(x.id + "- " + y);
            //tại thời điểm biên dịch
            //-> ko biết các biến x,y có thuộc tính gì? kiểu dữ liệu gì
            // nhưng nó vẫn biên dịch
        }
    }
}
//Kết hợp Anonymous methods và delegate truyền tham số cho hàm