using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_15_FILE_DOI_TUONG
{//ID – string, Ten – string, Ns– int, Nganh -string
    internal class Student
    {
        private string id;
        private string ten;
        private int namSinh;
        private string nganh;
        public Student()
        {

        }

        public Student(string id, string ten, int namSinh, string nganh)
        {
            this.id = id;
            this.ten = ten;
            this.namSinh = namSinh;
            this.nganh = nganh;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string Nganh { get => nganh; set => nganh = value; }
    
        public void InThongTin()
        {
            Console.WriteLine($"{id}|{ten}|{namSinh}|{nganh}");
        }
        //trả về 1 chuỗi thông tin của đối tượng
        public string ObjToString()
        {
            return $"{id}|{ten}|{namSinh}|{nganh}\n";
        }
    }
}
