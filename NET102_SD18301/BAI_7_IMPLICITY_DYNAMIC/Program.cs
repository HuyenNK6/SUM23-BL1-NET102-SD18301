using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7_IMPLICITY_DYNAMIC
{
    #region Var & Dynamic
    /*
    * Phần 1: Implicitly
    *          1.1 Implicitly (KIỀU NGẦM ĐỊNH):
    *             - Khai báo biến kiểu ngầm định (khai báo không tường minh) là biến được khai báo mà không cần phải chỉ ra kiểu dữ liệu
                  - Kiểu dữ liệu của biến sẽ được xác định bởi trình biên dịch dựa vào biểu thức được gán khi khai báo biến
                  - Sử dụng từ khóa “var” khi khai báo và cần khởi tạo giá trị
               1.2 Công thức:
                   var varialble_name = value;
               1.3 Hạn chế:
                  + Không thể sử dụng từ khóa var bên ngoài phạm vi của một method
                  + Không thể khởi tạo giá trị là null.
                  + Biến phải được khởi tạo giá trị khi nó được khai báo 
                  + Var không cho phép thay đổi kiểu dữ liệu sau khi nó đã được gán
                  + Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo
                    không được là một đối tượng hay tập hợp các giá trị.
                    Nhưng nó có thể sử dụng toán tử new bởi một đối
                    tượng hoặc tập hợp các giá trị.

     Phần 2: Dynamic
             - Kiểu động - khai báo với từ khóa dynamic, 
                thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy 
                (khác với kiểu ngầm định var kiểu xác định ngay thời điểm biên dịch)
             - Dynamic cho phép kiểu dữ liệu thay đổi sau khi nó đã được gán cho ban đầu
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //PHẦN 1: Implicity
            var a = 1;
            var b = "poly";
            var c = true;
            //var d;//Biến phải được khởi tạo giá trị khi nó được khai báo
            a = 10;
            //a = "ha noi";//Var không cho phép thay đổi kiểu dữ liệu sau khi nó đã được gán
           // var e = { 1, 2, 3 };
            var f = new int[] { 1, 2, 3 };

            //PHẦN 2: Dynamic
            dynamic x = 100;
            dynamic y = "viet nam";
            dynamic z;
            x = 200;
            x = "Ninh binh";

            method2(2023, "FPT");
        }
        //ctrl K C/U: comment code
        ////Implicitly Không thể khai báo kiểu var làm tham số truyền vào
        //static void method1(var a, var b)
        //{
        //    Console.WriteLine(a + "- "+ b);
        //} 
        ////Thời điểm biên dịch không biết các biến temp có thuộc tính abc hay không nhưng nó vẫn biên dịch
        static void method2(dynamic a, dynamic b)
        {
            Console.WriteLine(a + "- " + b);
        }
    }
}
/*
 * BTVN:
 * Tự tạo 1 lớp List riêng của bạn
 *  internal class MyList<T>
    {
        private T[] arrs;
        ....
        public void Show(){}
        public void Add(T item){}
        public void RemoveAt(int index){}
    }
 */