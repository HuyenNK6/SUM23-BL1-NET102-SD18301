using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_GENERIC
{
    /*
      *  Lớp Generic
      *  - Trước thì chúng ta làm việc với các kiểu dữ liệu tường minh 
      *  nay khi học được Generic chúng ta chỉ quan tâm T cũng là 1 dạng kiểu dữ liệu 
      *  - Khi truyền kiểu dữ liệu cho T thì nó sẽ thay thế toàn bộ các chỗ gọi đến T thành các kiểu dữ liệu......
      *  - Giúp định nghĩa một thao tác dữ liệu với kiểu dữ liệu chung nhất nhìn hạn chế viết code và tái sử dụng.
    */
    internal class MyClass<T>
    {
        private T variable;

        public MyClass()
        {
        }
        public MyClass(T variable)
        {
            this.variable = variable;
        }
        public T Variable { get => variable; set => variable = value; }
    
        public T Show()
        {
            Console.WriteLine(variable);
            return variable;
        }
    }
}
