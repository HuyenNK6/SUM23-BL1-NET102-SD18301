using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_GENERIC
{
    internal class FpolyList<T>
    {
        private T[] arrs; //Mảng chưa xác định kiểu dữ liệu
        public FpolyList()
        {
            arrs = new T[0];
        }
        public FpolyList(T[] arrs)
        {
            this.arrs = arrs;
        }

        public T[] Arrs { get => arrs; set => arrs = value; }

        public void Show()
        {
            Console.WriteLine(string.Join(" ", arrs));
        }
        public void Add(T item)
        {
            // Bước 1: Tạo 1 mảng mới dài hơn mảng cũ 1 vị trí
            T[] newArrs = new T[arrs.Length + 1];
            // Bước 2: Gán giá trị của mảng cũ cho mảng mới
            //arrs.CopyTo(newArrs, 0);
            for (int i = 0; i < arrs.Length; i++)
            {
                newArrs[i] = arrs[i];
            }
            // Bước 3: Thêm giá trị mới vào cuối của mảng mới
            newArrs[newArrs.Length - 1] = item;
            // Bước 4: Gán lại giá trị mảng mới newArrs cho mảng cũ arrs
            arrs = newArrs;
        }
        public void RemoveAt(int index)
        {
            // Bước 1: Tạo 1 mảng mới ngắn hơn mảng cũ 1 vị trí
            T[] newArrs = new T[arrs.Length - 1];
            // Bước 2: Gán giá trị của mảng cũ cho mảng mới ngoại trừ
            // vị trí cần xóa
            int j = 0;
            for (int i = 0; i < arrs.Length; i++)
            {
                if (i == index) continue;
                newArrs[j] = arrs[i];
                j++;
            }
            // Bước 3: Gán lại giá trị newdata cho data
            arrs = newArrs;
        }
    }
}
