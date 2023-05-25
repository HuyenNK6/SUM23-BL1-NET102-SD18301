using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8_NULLABLE
{
    internal class Program
    {
        #region Nullable
        /*
        * 1. Từ khóa null
        *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, 
        *    có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).
             + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), 
             không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...

         *2. Sử dụng nullable
         *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ...
         *    như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, 
         *    có thể sử dụng như đối tượng ...==> thì khai báo nó có khả năng nullable, 
         *    khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, 
         *    cách làm như sau:
         *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
	Nullable rất tiện dụng khi lập trình các truy vấn cơ sở dữ liệu, lập trình web ... 
	 * 3. Toán tử Null Coalescing 
		- trong C# được ký hiệu là "??"
		- Trong lệnh: result = x ?? y;
		Toán tử Null Coalescing được gán cho giá trị của "x" cho "result" nếu "x" khác null,
		và ngược lại, nếu "x" là null thì nó sẽ gán giá trị của "y" cho "result".
		Biến "result" cũng có thể có Null, vì vậy nó biến này sẽ được định nghĩa là Nullable
         */
        #endregion
        static void Main(string[] args)
        {
            string s = null;
            List<int> lst = null;
            //int a = null;
            //cách 1:
            int? a = null;
            double? b = null;
            //cách 2:
            Nullable<int> c = null;
            Nullable<double> d = null;
            Console.WriteLine("d= "+ d);
            //cần phải gán giá trị
            Nullable<int> e;
            //Console.WriteLine("e= "+ e);
           
            if (d.HasValue)
            {
                Console.WriteLine("d= " + d.Value);
            }
            else
            {
                Console.WriteLine("Empty Value!!");
            }
            Console.WriteLine("default d= "+d.GetValueOrDefault());
            Nullable<bool> f = null;
            Console.WriteLine("default f= " + f.GetValueOrDefault());

            int? x = null;
            int y = 2023;
            //result = x nếu x khác null
            //result = y nếu x bằng null
            int result = x ?? y;
            Console.WriteLine("result = "+ result);
        }
    }
}
