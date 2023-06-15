using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAI_9_DELEGATE
{
    internal class Program
    {
        #region Phần 1: Delegate
        /*
         *  ❑ Delegate là một đối tượng chứa tham chiếu đến phương thức cần thực thi.
            ❑ Một delegate có thể trỏ tới một hoặc nhiều phương thức
            ❑ Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi

            ❑ Để liên kết một delegate với một phương thức cụ thể
            thì phương thức và delegate phải giống nhau ở kiểu trả về và kiểu tham số
            ❑ Cú pháp:
                <access_modifier> delegate <return_type> <delegate name> (<parameters>)
            ❑ Sử dụng delegate
                ❖Khai báo delegate
                ❖Thực hiện delegate tham chiếu tới phương thức
                ❖Tạo thể hiện của delegate
                ❖Gọi phương thức thông qua thể hiện delegate
         */
        #endregion

        #region Phần 2: C# Multicast Delegates
        /*
           ❖Có thể tham chiếu đến nhiều phương thức tại cùng một thời điểm
           ❖Kiểu tra về của multicast delegate phải là kiểu void
           ❖Dùng toán tử “+” để thêm phương thức vào delegate
         */
        #endregion

        #region Phần 3: Delegate Callback
        /*
         * Callback là khi 1 hàm sử dụng 1 hàm khác như 1 tham số truyền vào
         * Với C# thì điều này không thể thực hiện được vì 1 hàm không phải là 1 kiểu dữ liệu
         * Để thực hiện được Callback thì ta dùng delegate để tham chiếu tới hàm
         * mà ta muốn thực hiện Callback
         */
        #endregion

        #region Khác: Regex
        /*
         * REGEX hoặc Regular Expression trong C#
         * Biểu thức chính quy, 
         * là một cấu trúc rất mạnh để mô tả một chuỗi theo cách thống nhất chung.

        Regular Expression bao gồm tập hợp các ký tự, toán tử hay ký hiệu toán học
        nhằm biểu thị một chuỗi theo cấu trúc chung mà mọi người học theo. */
        /* 
         * 1. Các lớp ký tự Regex
            Regex	Mô tả
            [...]	trả về một ký tự phù hợp
            [abc]	a, b, hoặc c
            [^abc]	Bất kỳ ký tự nào ngoại trừ a, b, hoặc c
            [a-zA-Z]	ký tự chữ từ a tới z hoặc A tới Z
            [0-9]	ký tự số 0 tới 9
         */
        /* 2. Số lượng ký tự trong Regex
         * Regex	Mô tả	Pattern	Ví dụ
         *  X   X xảy ra một lần
            X?	X xảy ra một hoặc không lần	hellos?	hello, hellos, helloss
            X+	X xảy ra một hoặc nhiều lần	Version \w-\w+	Version A-b1_1
            X*	X xảy ra không hoặc nhiều lần	A*B*C*	AAACC
            X{n}	X chỉ xảy ra n lần	\d{4}	2018, 20189, 201
            X{n,}	X xảy ra n hoặc nhiều lần	\d{4,}	2018, 20189, 201
            X{y,z}	X xảy ra ít nhất y lần nhưng nhỏ hơn z lần	\d{2,3}	2018, 201
         */

        /*3. Ký tự đặc biệt trong Regex
         * Regex	Mô tả
            .	Bất kỳ ký tự nào
            ^	Có 2 cách sử dụng.
                1. Đánh dấu bắt đầu của một dòng, một chuỗi.
                2. Nếuu sử dụng trong dấu [...] thì nó có nghĩa là phủ định.
                    [0-9] [^0-9]
            $	Đánh dấu Kết thúc của một dòng
            \d	Bất kỳ chữ số nào, viết tắt của [0-9]
            \D	Bất kỳ ký tự nào không phải chữ số, viết tắt của [^0-9]
            \s	Bất kỳ ký tự trống nào (như dấu cách, tab, xuống dòng, ...), viết tắt của [\t\n\x0B\f\r]
            \S	Bất kỳ ký tự trống nào không phải ký tự trống, viết tắt của [^\s]
            \w	Bất kỳ ký tự chữ nào (chữ cái và chữ số và dấu gạch dưới), 
                viết tắt của [a-zA-Z_0-9]
            \W	Bất kỳ ký tự nào không phải chữ cái và chữ sốvà dấu gạch dưới, 
                viết tắt của [^\w]
            \b	Ranh giới của một từ
            \B	Không phải ranh giới của một từ
         */
        #endregion

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
        public delegate void InThongTin(string s);
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

        public delegate int TinhTien(int n);

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

        public delegate void DelCallBackShow(string s);

        public static void ShowMesHappy(string s)
        {
            Console.WriteLine("Thông báo tin vui " + s);
        }
        public static void ShowMesSad(string s)
        {
            Console.WriteLine("Thông báo tin buồn " + s);
        }
        public static void CallBackMes(DelCallBackShow callBack)
        {
            Console.WriteLine("Mời nhập thông báo: ");
            string input = Console.ReadLine();
            callBack(input);
        }

        #endregion

        #region Demo: Delegate Callback - bool
        public delegate bool Check <T>(T s);
        //kiểm tra chuỗi có đúng định dạng là số int hay ko?
        public static bool CheckSo(string s)
        {
            //return Regex.IsMatch(s, @"^[a-zA-Z0-9_]+@fpt.edu.vn$");
            return Regex.IsMatch(s, @"^[0-9]+$");
            //return Regex.IsMatch(s, @"^[\d]+$");
        }
        
        public static int NhapSo(Check<string> check)
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
        public static string NhapEmail(Check check)
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
            InThongTin show = InLoiToTinh;
            //triển khai delegate
            show("Beiu");

            show = InLoiChiaTay;
            show("Beiu");
            Console.WriteLine("--------Tính tiền---------");
            TinhTien tien = TinhHocPhi;
            Console.WriteLine("Học phí= " + tien(7));
            tien = TinhHocLai;
            Console.WriteLine("Học lại= " + tien(3));
            #endregion

            #region Multicast Delegate
            Console.WriteLine("---------Multicast Delegate-----");
            InThongTin thongTin = InLoiToTinh;
            thongTin += InLoiChiaTay; //thêm 
            thongTin += InLoiChiaTay; //thêm 
            thongTin += InLoiChiaTay; //thêm 
            thongTin -= InLoiChiaTay; //bớt
            thongTin("Lan");
            #endregion

            #region Callback - void
            Console.WriteLine("-------------Call back------");
            //tạo delegate
            DelCallBackShow mesHappy = ShowMesHappy;
            //callback
            CallBackMes(mesHappy);

            DelCallBackShow mesSad = ShowMesSad;
            CallBackMes(mesSad);
            #endregion

            #region Callback- bool
            Check check = CheckSo;
            int tuoi = NhapSo(check);
            Console.WriteLine("Tuổi= " + tuoi);

            Check check2 = CheckEmail;
            string email = NhapEmail(check2);
            Console.WriteLine("Email:  "+ email);

            #endregion
        }
    }
}
/*BTVN
 * tạo các phương thức NhapSDT, NhapEmail với kiểu trả về phù hợp
 * Có sử dụng Callback Delegate
 * 
 * SĐT: có 10 số: số 0 đầu tiên và 9 số tiếp theo
 * Regex.IsMatch(s, @"^[0][0-9]{9}$");
 * Regex.IsMatch(s, @"^[0][\d]{9}$");
 * 
 * Email: đuôi @fpt.edu.vn
 * Regex.IsMatch(s, @"^[a-zA-Z0-9_]+@fpt\.edu\.vn$");
 * 
 * 
 */