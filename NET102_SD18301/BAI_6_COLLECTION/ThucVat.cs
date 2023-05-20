using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6_COLLECTION
{
    internal class ThucVat
    {
        private int id;
        private string ten;
        private int tuoi;

        public ThucVat()
        {

        }

        public ThucVat(int id, string ten, int tuoi)
        {
            this.id = id;
            this.ten = ten;
            this.tuoi = tuoi;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public void Show()
        {
            Console.WriteLine($"{id}| {ten}| {tuoi}");
        }
    }
}
