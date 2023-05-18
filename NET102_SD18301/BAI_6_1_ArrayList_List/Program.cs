using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6_1_ArrayList_List
{
    internal class Program
    {
        static void Main(string[] args)
        { //1. Khởi tạo ArrayList
            ArrayList arrLstTuoi = new ArrayList();

            //2. Thêm phần tử vào arrLst
            arrLstTuoi.Add(10);
            arrLstTuoi.Add(5);
            arrLstTuoi.Add(18);
            arrLstTuoi.Add(32);
            arrLstTuoi.Add(24);
            /////
            arrLstTuoi.Add("HuyenNK6");
            arrLstTuoi.Add(true);

            //3. Truy xuất phần tử
            Console.WriteLine(arrLstTuoi[0]);
            Console.WriteLine(arrLstTuoi[1]);
            Console.WriteLine(arrLstTuoi[2]);
            //4. duyệt arrLst
            Console.WriteLine("Cach 1: for i");
            //for tab
            for (int i = 0; i < arrLstTuoi.Count; i++)
            {
                Console.WriteLine($"arrLstTuoi[{i}] = {arrLstTuoi[i]}");
            }
            Console.WriteLine("Cach 2: foreach");
            //fore tab
            foreach (var item in arrLstTuoi)
            {
                Console.WriteLine(item);
            }
            /////////////////////////////
            //1. khởi tạo list
            List<string> lstTen = new List<string>();
            //2. Thêm phần tử vào list
            lstTen.Add("Mai");
            lstTen.Add("Dao");
            lstTen.Add("Hoa");
            lstTen.Add("Tuyet");
            lstTen.Add("Nhung");
            //lstTen.Add(10);
            //lstTen.Add(false);
            //3. truy xuất phần tử
            Console.WriteLine(lstTen[1]);
            Console.WriteLine("count= " + lstTen.Count);
            //4. duyệt list
            Console.WriteLine("Cach 1: for i");
            //sắp xếp tăng dần
            lstTen.Sort();
            for (int i = 0; i < lstTen.Count; i++)
            {
                Console.WriteLine($"lstTen[{i}]= {lstTen[i]}");
            }
            //xóa phần tử tại vị trí i trong list
            lstTen.RemoveAt(1);
            //phải sort trước -> BinarySearch
            int viTri = lstTen.BinarySearch("Dao");
            Console.WriteLine("Tim thay Dao tai vi tri " + viTri);

            lstTen.Remove("Dao");

            Console.WriteLine("Cach 2: foreach");
            lstTen.Reverse();
            foreach (var item in lstTen)
            {
                Console.WriteLine(item);
            }

            lstTen.Clear();
            Console.WriteLine("count= " + lstTen.Count);
            if (lstTen.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!");
            }
        }
    }
}
