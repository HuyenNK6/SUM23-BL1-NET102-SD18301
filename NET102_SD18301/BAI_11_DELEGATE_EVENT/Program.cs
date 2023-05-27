using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BAI_11_DELEGATE_EVENT
{
    #region DELEGATE EVENT

    /*
     * ❑Sự kiện (Event) là các hành động, ví dụ như nhấn phím, click, di chuyển chuột...
       ❑Trong C#, Event là một đối tượng đặc biệt của  Delegate, 
        nó là nơi chứa các phương thức, các phương thức này sẽ được thực thi khi sự kiện xảy ra
       ❑Đặc điểm của event:
           ❖Được khai báo trong các lớp hoặc interface
           ❖Được khai báo là abstract hoặc sealed, virtual
           ❖Được thực thi thông qua delegate
       ❑Tạo và sử dụng event
           ❖Đinh nghĩa delegate cho event
           ❖Tạo event thông qua delegate
           ❖Đăng ký để lắng nghe và xử lý event
           ❖Kích hoạt event
    ❑Event phải được ủy thác từ đối tượng cha của đối tượng chứa event . 
    Bằng cách += hàm Delegate tương ứng vào event của đối tượng
    (Tương tự có thể loại bỏ bằng cách -=).
     */
    #endregion
    internal class Program
    {
        // ❖Đinh nghĩa delegate cho event
        public delegate void EventHandlerUpdateID(int id);
        class Student
        {
            //❖Tạo event thông qua delegate
            public event EventHandlerUpdateID UpdateID;//Mặc định là null

            private int id;
            private string name;
            private int age;
            private double score;

            public int Id
            {
                get => id;
                set
                {
                    id = value;
                    if(UpdateID != null)
                    {
                        UpdateID(id);
                    }
                    /*
                     * Kiểm tra để gọi ra sự kiện mong muốn mỗi khi tác động vào thuộc tính
                     * Sẽ gọi event UpdateID
                     * Nhưng nếu như UpdateID chưa từng được ủy thác thì khi gọi sẽ bị null exception. 
                     * Nên mình sẽ kiểm tra UpdateID có null hay không? 
                     * Nếu khác null thì sẽ gọi event như hàm và truyền param tương ứng vào là ID.
                     */
                }
            }
            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public double Score { get => score; set => score = value; }
        }
        static void Main(string[] args)
        {
            Student st = new Student();
            /*
             *  ❑Event phải được ủy thác từ đối tượng cha của đối tượng chứa event . 
            Bằng cách += hàm Delegate tương ứng vào event của đối tượng
            (Tương tự có thể loại bỏ bằng cách -=).
             */
            //Khi += => tạo tia chớp St_UpdateID
            st.UpdateID += St_UpdateID;
            st.Id = 1;

        }

        private static void St_UpdateID(int id)
        {
            Console.WriteLine("Loading..........");
            Thread.Sleep(2000);
            Console.WriteLine("Đã thay đổi id = "+ id);
        }
    }
}
//tạo event để kiểm tra điểm score khi update 
//=> đưa ra thông báo thay đổi
//=> kiểm tra điểm <5 -> "tạch", ngược lại "qua"
