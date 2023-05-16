using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_PARTIAL_NESTED
{
    //internal class ClassA
    internal partial class ClassA
    {
        private int a;
        private string b;

        public ClassA()
        {

        }

        public ClassA(int a, string b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public void Method1()
        {
            Console.WriteLine("Day la method 1");
        }
        /*
       * Phương thức partial khai báo, không có body code
       * Bạn có thể dùng từ khóa partial trong khai báo các phương thức, 
       * tuy nhiên mục đích chỉ để chia làm 2 nơi, Một nơi làm khai báo và một nơi triển khai.
       */
         partial void Method2();

    }
}
