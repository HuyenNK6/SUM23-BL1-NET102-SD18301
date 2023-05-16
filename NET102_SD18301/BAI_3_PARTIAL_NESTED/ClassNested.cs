using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_PARTIAL_NESTED
{
    internal class ClassNested
    {
        /*
         * Trong C# nó cho phép bạn khai báo một lớp (class), giao diện (interface), cấu trúc (struct)
         * trong thân một lớp khác - chúng được gọi là kiểu lồng nhau (Nested Type)
         */
        public class ClassC
        {
            private int e;

            public ClassC()
            {

            }

            public ClassC(int e)
            {
                this.e = e;
            }

            public int E { get => e; set => e = value; }
            public void Show()
            {
                Console.WriteLine(e);
            }
        }
    }
}
