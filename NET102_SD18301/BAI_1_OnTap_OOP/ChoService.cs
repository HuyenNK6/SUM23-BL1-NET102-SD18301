using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_OnTap_OOP
{
    internal class ChoService
    {
        List<Cho> _lstChos;
        Cho _cho;
        string _input;
        //ctor tab
        public ChoService()
        {
            _lstChos = new List<Cho>();
            FakeData();
        }
        public void FakeData()
        {
            _lstChos.Add(new Cho("Ch1", "Titi", 5, 1, "Poodle"));
            _lstChos.Add(new Cho("Ch2", "Nana", 8, 2, "Poodle"));
            _lstChos.Add(new Cho("Ch3", "Lala", 3, 2, "Poodle"));
            _lstChos.Add(new Cho("Ch4", "Lulu", 12, 1, "Poodle"));
            _lstChos.Add(new Cho("Ch5", "Susu", 10, 1, "Poodle"));
        }

        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo đối tượng
                _cho = new Cho();
                //2. nhập thông tin 
                Console.WriteLine("Nhập mã: ");
                _cho.Ma = Console.ReadLine();
                Console.WriteLine("Nhập tên: ");
                _cho.Ten = Console.ReadLine();
                Console.WriteLine("Nhập cân nặng: ");
                _cho.CanNang = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhập giới tính (1-đực 2-cái): ");
                _cho.GioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập loại: ");
                _cho.Loai = Console.ReadLine();
                //3. thêm đối tượng vào danh sách
                _lstChos.Add(_cho);
                //4. hỏi có tiếp tục ko? 
                Console.WriteLine("Có muốn tiếp tục ko (co/ko)? ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));
        }
        #region Cách 2: phần nhập
        //public Cho CreateNew() => trả về cả 1 đối tượng
        //public void Add() -> sử dụng CreateNew()
        public string GetValueInput(string msg)
        {
            Console.WriteLine($"Mời nhập {msg}");
            return Console.ReadLine();
        }
        public Cho CreateNew()
        {

            //1. khởi tạo đối tượng
            _cho = new Cho();
            //2. nhập thông tin 
            _cho.Ma = GetValueInput("mã");
            _cho.Ten = GetValueInput("tên");
            _cho.CanNang = Convert.ToDouble(GetValueInput("cân nặng"));
            _cho.GioiTinh = Convert.ToInt32(GetValueInput("giới tính (1-đực 2-cái)"));
            _cho.Loai = GetValueInput("loại");
            return _cho;
        }
        public void Add()
        {
            _cho = CreateNew();
            _lstChos.Add(_cho);
            Console.WriteLine("Có muốn tiếp tục ko (co/ko)? ");
            string tiepTuc = Console.ReadLine();
            if (tiepTuc.Equals("co"))
            {
                Add();
            }
        }
        #endregion
        public void XuatDS()
        {
            if (_lstChos.Count == 0)
            {
                Console.WriteLine("Danh sách trống!!!");
                return;
            }
            foreach (var item in _lstChos)
            {
                item.InThongTin();
            }
        }
        //trả về vị trí của con chó cần tìm theo mã
        public int GetIndex(string msg)
        {
            Console.WriteLine($"Nhap {msg}");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstChos.Count; i++)
            {
                if (_lstChos[i].Ma.Equals(_input))
                {
                    return i;
                }
            }
            return -1; //nếu ko tìm thấy
        }
        public void TimKiem()
        {
            int viTri = GetIndex("mã con chó");
            if (viTri == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            Console.WriteLine("Đã tìm thấy:");
            _lstChos[viTri].InThongTin();
        }
        #region: Cách 1: liệt kê
        public void LietKe()
        {
            bool check = false;
            for (int i = 0; i < _lstChos.Count; i++)
            {
                if (_lstChos[i].GioiTinh == 2)
                {
                    _lstChos[i].InThongTin();
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine("Không có gì cả!!");
            }
        }
        #endregion
        #region: Cách 2: trả về cả 1 danh sách trước => sau đó mới in
        public List<Cho> LietKeChoCai()
        {
            List<Cho> listCai = new List<Cho>();
            foreach (var item in _lstChos)
            {
                if (item.GioiTinh == 2)
                {
                    listCai.Add(item);
                }
            }
            return listCai;
        }
        public void InChoCai()
        {
            List<Cho> listCai = LietKeChoCai();
            if (listCai.Count == 0)
            {
                Console.WriteLine("Không có chó cái");
                return;
            }
            foreach (var item in listCai)
            {
                item.InThongTin();
            }
        }
        #endregion
        public void Sua()
        {

        }
        public void SapXep()
        {
            _lstChos = _lstChos.OrderBy(x => x.CanNang).ToList();
            XuatDS();
        }
        public void Xoa()
        {

        }

    }
}
