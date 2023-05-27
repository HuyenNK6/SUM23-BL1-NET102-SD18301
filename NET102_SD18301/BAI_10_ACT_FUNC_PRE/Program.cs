using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAI_10_ACT_FUNC_PRE
{
    internal class Program
    {
        #region Phần 4: Delegate đặc biệt

        /*
         * Một số loại Delegate đặc biệt (Dựng sẵn)
         * Thay vì chúng ta phải khai báo định nghĩa trước delegate thì chúng ta sẽ sử dụng 3 kiểu dưới đây khai báo cho nhanh.
          Action, Predicate, Func (Viết tắt là APF là cho nhanh) trong C#
         * Có 3 loại cơ bản
         * 1. Action: Tương đương với một delegate mà kiểu trả về là void
              Action<T p1, T p2, ...> trong đó T là kiểu dữ liệu bất kì
              p1, p2 là các tham số. 
         * 2. Predicate: Tuong đương với 1 delegate mà trả về bool, 
              Pre thường được sử dụng làm Callback khi cần kiểm tra
              Predicate<T p>: Predicate chỉ có thể truyền vào bởi 1 tham số
         * 3. Func: Tương đương với 1 delegate có kiểu trả về bất kì
              Func<T p1, T p2,... T return> với p1, p2 là các tham số, T return là kiểu trả về
         * Các delegate có thể được dùng trực tiếp mà không cần khai báo mới
         */
        #endregion

        #region Demo: Delegate - void
       // public delegate void InThongTin(string s); //=> ACTION<string>
        //Delegate InThongTin-> trỏ tới các phương thức có kiểu void và tham số là string

        public static void InLoiToTinh(string s)
        {
            Console.WriteLine("Em có iu anh ko " + s + "?? ");
        }
        public static void InLoiChiaTay(string s)
        {
            Console.WriteLine("Mình dừng lại thôi " + s + "nhé!!!");
        }

        #endregion

        #region Demo: Delegate - int

      //  public delegate int TinhTien(int n); //FUNC <int, int>

        public static int TinhHocPhi(int soKy)
        {
            return soKy * 8200;
        }
        public static int TinhHocLai(int soMon)
        {
            return soMon * 672;
        }

        #endregion

        #region Demo: Delegate Callback- void

       // public delegate void DelCallBackShow(string s);//ACTION<string>

        public static void ShowMesHappy(string s)
        {
            Console.WriteLine("Thông báo tin vui " + s);
        }
        public static void ShowMesSad(string s)
        {
            Console.WriteLine("Thông báo tin buồn " + s);
        }
        public static void CallBackMes(Action<string> callBack)
        {
            Console.WriteLine("Mời nhập thông báo: ");
            string input = Console.ReadLine();
            callBack(input);
        }

        #endregion

        #region Demo: Delegate Callback - bool
        //public delegate bool Check(string s); //PREDICATE<string>
        //kiểm tra chuỗi có đúng định dạng là số int hay ko?
        public static bool CheckSo(string s)
        {
            //return Regex.IsMatch(s, @"^[a-zA-Z0-9_]+@fpt.edu.vn$");
            return Regex.IsMatch(s, @"^[0-9]+$");
            //return Regex.IsMatch(s, @"^[\d]+$");
        }

        public static int NhapSo(Predicate<string> check)
        {
            string input;
            do
            {
                Console.WriteLine("Nhập số: ");
                input = Console.ReadLine();
                if (!check(input))
                {
                    Console.WriteLine("Mời nhập lại!!!!");
                }
            } while (!check(input));
            return Convert.ToInt32(input);
        }
        public static bool CheckEmail(string s)
        {
            return Regex.IsMatch(s, @"^[a-zA-Z0-9_]+@fpt.edu.vn$");
        }
        public static string NhapEmail(Predicate<string> check)
        {
            string input;
            do
            {
                Console.WriteLine("Nhập email: ");
                input = Console.ReadLine();
                if (!check(input))
                {
                    Console.WriteLine("Mời nhập lại!!!!");
                }
            } while (!check(input));
            return input;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region Delegate
            //InLoiToTinh("Huyen");

            //trỏ tới phương thức
            // InThongTin show = InLoiToTinh;
            Action<string> show = InLoiToTinh;
            //triển khai delegate
            show("Beiu");

            show = InLoiChiaTay;
            show("Beiu");
            Console.WriteLine("--------Tính tiền---------");
            //TinhTien tien = TinhHocPhi;
            //int 1: tham số truyền vào ,  int 2: kiểu trả về của phương thức
            Func<int, int> tien = TinhHocPhi;
            Console.WriteLine("Học phí= " + tien(7));
            tien = TinhHocLai;
            Console.WriteLine("Học lại= " + tien(3));
            #endregion

            #region Multicast Delegate
            Console.WriteLine("---------Multicast Delegate-----");
            Action<string> thongTin = InLoiToTinh;
            thongTin += InLoiChiaTay; //thêm 
            thongTin += InLoiChiaTay; //thêm 
            thongTin += InLoiChiaTay; //thêm 
            thongTin -= InLoiChiaTay; //bớt
            thongTin("Lan");
            #endregion

            #region Callback - void
            Console.WriteLine("-------------Call back------");
            //tạo delegate
            // DelCallBackShow mesHappy = ShowMesHappy;
            Action<string> mesHappy = ShowMesHappy;
            //callback
            CallBackMes(mesHappy);

            Action<string> mesSad = ShowMesSad;
            CallBackMes(mesSad);
            #endregion

            #region Callback- bool
            //Check check = CheckSo;
            Predicate<string> check = CheckSo;
            int tuoi = NhapSo(check);
            Console.WriteLine("Tuổi= " + tuoi);

            Predicate<string> check2 = CheckEmail;
            string email = NhapEmail(check2);
            Console.WriteLine("Email:  " + email);

            #endregion
        }
    }
}
