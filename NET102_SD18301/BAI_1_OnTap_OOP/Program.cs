using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_OnTap_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            Cho cho1 = new Cho();
            cho1.Ma = "CH1";
            cho1.Ten = "Titi";
            cho1.CanNang = 5;
            //cho1.GioiTinh = 2;
            cho1.Loai = "Poodle";
            cho1.InThongTin();
            cho1.TiengKeu();
        }
    }
}
