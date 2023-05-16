using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_PARTIAL_NESTED
{
    /*Partial Class trong C# là một tính năng giúp
    chúng ta chia một class thành hai hay nhiều
    phần hay file khác nhau
    */
    //internal class ClassB

    partial class ClassA
    {
        //vẫn là ClassA nhưng dc tạo trên file ClassB
        private int c;
        private string d;

        public int C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }

        partial void Method2()
        {
            Console.WriteLine("Day la method 2");
        }
        public void Method3()
        {
            Console.WriteLine("Day la method 3");
        }
    }
}
