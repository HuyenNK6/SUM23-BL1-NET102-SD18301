using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_EXCEPTION
{
    internal class Program
    {
        #region EXCEPTION - Xử lý ngoại lệ
        /*
         * ❑ Exception là các vấn đề phát sinh trong quá trình thực hiện chương trình như: không đọc được tập tin, kiểu dữ liệu sai…
           ❑ Các exception được sinh ra bởi .NET framework CLR hoặc lập trình viên
           ❑ Xử lý ngoại lệ trong C# được xây dựng chủ yếu trên bốn từ khoá try, catch, finally và throw
             try
             {   
                //Các câu lệnh có thể xảy ra lỗi
             }
             catch (Exception a)
             {
                 //Phần code để xử lý lỗi hoặc đơn giản chỉ là show ra lỗi
             }
             finally
             {
                 //Một khối finally được sử dụng để thực thi một tập hợp lệnh đã cho, dù có hay không một exception đươc ném hoặc không được ném.
             }
            * Một số Exception class thường gặp:
                - Exception [Lớp cơ bản của mọi ngoại lệ.]          
                - SystemException [Lớp cơ bản của mọi ngoại lệ phát ra tại thời điểm chạy của chương trình.]           
                - IndexOutOfRangeException [Được ném ra tại thời điểm chạy khi truy cập vào một phần tử của mảng với chỉ số không đúng.]           
                - NullReferenceException [Ném ra tại thời điểm chạy khi một đối tượng null được tham chiếu.]
                - AccessViolationException [Ném ra tại thời điểm chạy khi tham chiếu vào vùng bộ nhớ không hợp lệ.]
                - InvalidOperationException [Ném ra bởi phương thức khi ở trạng thái không hợp lệ.]           
                - ArgumentException [Lớp cơ bản cho các ngoại lệ liên quan tới đối số (Argument).]
                - ArgumentNullException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức mà không cho phép thông số null truyền vào.]
                - ArgumentOutOfRangeException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức khi một đối số không thuộc phạm vi cho phép truyền vào nó.]
                - ExternalException [Lớp cơ bản cho các ngoại lệ xảy ra hoặc đến từ môi trường bên ngoài.]
                - COMException [Lớp này mở rộng từ ExternalException, ngoại lệ đóng gói thông tin COM.]
                - SEHException [Lớp này mở rộng từ ExternalException, nó tóm lược các ngoại lệ từ Win32.]

            *  Một số lớp Exception tiền định nghĩa được kế thừa từ lớp Sytem.SystemException trong C#:

                Lớp Exception	                        Mô tả
            - System.IO.IOException	                Xử lý các I/O error.
            - System.IndexOutOfRangeException	    Xử lý các lỗi được tạo khi một phương thức tham chiếu tới một chỉ mục bên ngoài dãy mảng.
            - System.ArrayTypeMismatchException	    Xử lý các lỗi được tạo khi kiểu là không phù hợp với kiểu mảng.
            - System.NullReferenceException	        Xử lý các lỗi được tạo từ việc tham chiếu một đối tượng null.
            - System.DivideByZeroException	        Xử lý các lỗi được tạo khi chia cho số 0.
            - System.InvalidCastException	        Xử lý lỗi được tạo trong khi ép kiểu.
            - System.OutOfMemoryException	        Xử lý lỗi được tạo từ việc thiếu bộ nhớ rỗi.
            - System.StackOverflowException	        Xử lý lỗi được tạo từ việc tràn ngăn xếp (stack).
         
         */
        #endregion
        #region VD1: Lỗi được tạo khi chia cho số 0
        public static void ViDu1()
        {
            int a = 6;
            int b = 0;
            int c = a / b;
            Console.WriteLine(c);
        }
        #endregion
        #region VD2: lỗi khi tham chiếu tới một index bên ngoài dãy mảng
        public static void ViDu2()
        {
            int[] arrTuoi = new int[5];
            arrTuoi[5] = 14;
        }
        #endregion

        #region VD3: Sử dụng Try-Catch
        //sẽ giúp chương trình tiếp tục thực thi mà ko bị kết thúc đột ngột (crash)
        public static void ViDu3()
        {

            //try tab tab
            try
            {
                int[] arrTuoi = new int[5];
                arrTuoi[5] = 14;
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi rồi !!!");
                Console.WriteLine(e.Message); // thông tin về lỗi
                // Console.WriteLine(e.StackTrace); //truy vết đến vị trí lỗi 
                //Console.WriteLine(e.GetType().Name) ; // thông tin lỗi của lớp
            }
        }
        #endregion

        #region VD4: Try-catch lỗi nhập
        public static void ViDu4()
        {
            try
            {
                Console.WriteLine("Nhập số bất kỳ: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("n= " + n);
            }
            catch (Exception e)
            {
                //tự định nghĩa ra 1 exception
                //cách 1:
                // Exception ex = new Exception("Khong hop le");
                //throw ex; //ném ra ngoại lệ
                //cách 2:
                //throw new Exception("Khong hop le");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //dù có ngoại lệ hay ko -> finally cũng sẽ dc chạy
                Console.WriteLine("The End!!!");
            }
        }

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // ViDu1();
            // ViDu2();
            //ViDu3();
            ViDu4();
        }
    }
}
