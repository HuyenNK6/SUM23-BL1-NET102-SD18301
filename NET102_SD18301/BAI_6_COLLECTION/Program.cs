using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6_COLLECTION
{
    internal class Program
    {
        #region Phần 1: COLLECTION LÀ GÌ?
        /*
         * - Collection là lớp hỗ trợ lưu trữ, quản lý và thao tác với các đối tượng linh hoạt.
           - Có thể lưu trữ một tập hợp đối tượng thuộc nhiều kiểu khác nhau.
           - Hỗ trợ rất nhiều phương thức để thao tác với tập hợp như: tìm kiếm, sắp xếp, đảo ngược, . . .
           - Là một mảng có kích thước động:
               + Không cần khai báo kích thước khi khởi tạo.
               + Có thể tăng giảm số lượng phần tử trong mảng một cách linh hoạt

         *   Collections Là các class được tạo ra giúp chúng ta trong việc lưu trữ
             và quản lý dữ liệu. Collection có thể chứa được mọi kiểu dữ liệu
             - Collection được chia ra 2 loại 
                + Non-Generic Collection (ArrayList, Hashtable, SortedList,...)
                + Generic Collection (List, HashSet, Dictionary,...)
         */
        #endregion

        #region Phần 2: Các  Collection thông dụng C#

        /*
         * 1. ArrayList:  Lớp cho phép lưu trữ và quản lý các phần tử giống mảng. 
              Tuy nhiên, không giống như trong mảng, ta có thể thêm hoặc xoá phần tử một cách linh hoạt và có thể tự điều chỉnh kích cỡ một cách tự động.
         * 2. HashTable: Lớp lưu trữ dữ liệu dưới dạng cặp Key – Value. 
              Khi đó ta sẽ truy xuất các phần tử trong danh sách này thông qua Key 
              (thay vì thông qua chỉ số phần tử như mảng bình thường).
         * 3. BitArray: Lớp cho phép lưu trữ và quản lý một danh sách các bit. 
              Giống mảng các phần tử kiểu bool với true biểu thị cho bit 1 và false biểu thị cho bit 0. 
              Ngoài ra BitArray còn hỗ trợ một số phương thức cho việc tính toán trên bit. 
         * 4. SortedList: Là sự kêt hợp của ArrayList và HashTable. 
              Tức là dữ liệu sẽ lưu dưới dạng Key – Value. 
              Ta có thể truy xuất các phần tử trong danh sách thông qua Key hoặc thông qua chỉ số phần tử. 
              Đặc biệt là các phần tử trong danh sách này luôn được sắp xếp theo giá trị của Key.

         *************
         * 5. List: List là 1 Generic Collections đưa ra như một sự thay thế ArrayList 
              vì thế về khái niệm cũng như sử dụng nó hoàn toàn giống với ArrayList. 
         * 6. HashSet: là tập hợp danh sách không cho phép trùng giá trị. 
              HashSet<T> khác với các collection khác là nó cung cấp cơ chế đơn giản nhất để lưu các giá trị, 
              nó không chỉ mục thứ tự và các phần tử không sắp xếp theo thứ tự nào.
         * 7. Dictionary: là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value. 
              Dictionary chính là sự thay thế cho Collections Hashtable. 
              Cho nên về khái niệm hay sử dụng thì Dictionary đều sẽ giống Hashtable.
              - Hashtable là non-generic chứa đối tượng kiểu Object, khi truy xuất thông tin thì cần phải ép kiểu trở lại. 
              - Dictionary thường được sử dụng phổ biến hơn Hashtable. 
                (Giữa Hashtable và Dictionary<> giống như câu chuyện của ArrayList và List<>)
         * 8. LinkedList: là một tập hợp của các phần tử trong đó mỗi phần tử được liên kết (link) với phần tử trước (và sau nó)
            - Các phần tử của linked list cũng được gọi là các node.
            - Mỗi node bao gồm hai phần: phần dữ liệu, và phần tham chiếu
                + Phần dữ liệu để lưu trữ dữ liệu (giống như phần tử của mảng). 
                + Phần tham chiếu chứa địa chỉ (ô nhớ) của node khác
         *************
         * 9. Stack:  Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc LIFO (Last In First Out).
              C# includes both, generic and non-generic Stack.
         * 10. Queue:   Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc FIFO (First In First Out).
              C# includes both, generic and non-generic Queue

         */

        #endregion

        #region Phần 3: HashTable  
        /*
         * - Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
         * - Vì Key và Value đều là kiểu object nên ta có thể lưu trữ được mọi kiểu dữ liệu
            từ những kiểu cơ sở đến kiểu phức tạp (class).

           Một số thuộc tính và phương thức hỗ trợ sẵn trong Hashtable: 
                - Count:  Trả về 1 số nguyên là số phần tử hiện có trong Hashtable.           
                - Keys:  Trả về 1 danh sách chứa các Key trong Hashtable.           
                - Values:  Trả về 1 danh sách chứa các Value trong Hashtable.
                - Add(object Key, object Value):  Thêm 1 cặp Key - Value vào Hashtable.

                - Clear():  Xoá tất cả các phần tử trong Hashtable.           
                - Clone():  Tạo 1 bản sao từ Hashtable hiện tại.           
                - ContainsKey(object Key): Kiểm tra đối tượng Key có tồn tại trong Hashtable hay không.           
                - ContainsValue(object Value):  Kiểm tra đối tượng Value có tồn tại trong Hashtable hay không.           
                - CopyTo(Array array, int Index):  Thực hiện sao chép tất cả phần tử trong Hashtable sang mảng một chiều array từ vị trí Index của array. Lưu ý: array phải là mảng các object hoặc mảng các DictionaryEntry.           
                - Remove(object Key):  Xoá đối tượng có Key xuất hiện đầu tiên trong Hashtable.
         */
        #endregion
        static void Main(string[] args)
        {
            //DemoHashSet();
            //DemoLinkedList();
            //DemoHashTable();
            DemoDictionary();
        }

        static void DemoHashSet()
        {
           // HashSet set1 = new HashSet();
            HashSet<string> set = new HashSet<string>();
            set.Add("FPT");
            set.Add("FPT");
            set.Add("FPT");
            set.Add("FPT");
            set.Add("POLY");
            set.Add("POLY");
            Console.WriteLine(set.Count);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
        static void DemoLinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(9);
            list.AddLast(4);
            list.AddFirst(3);
            list.AddLast(8);

            var node = list.First;
            list.AddAfter(node, 10);

            var node2 = list.AddLast(15);
            list.AddBefore(node2, 20);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("value 1= "+ list.Last.Previous.Value);
            Console.WriteLine("value 2= "+ list.First.Next.Value);
        }
        static void DemoHashTable()
        {
            //1. khởi tạo
            Hashtable tableDV= new Hashtable();
            //Ngoài ra cũng có thể khởi tạo 1 Hashtable chứa các phần tử được sao chép từ một Hashtable khác:
            Hashtable tableAnimal = new Hashtable(tableDV);
            //2. add
            //Thêm giá trị vào Hashtable
            //Khi thêm mới một phần tử vào Hastable thì danh sách sẽ tự sắp xếp theo thuật toán Hashtable để tìm kiếm nhanh hơn,
            //chứ không thêm vào cuối như ArrayList
            tableDV.Add("dog", "cho");
            tableDV.Add("cat", "meo");
            tableDV.Add("pig", "lon");
            tableDV.Add("bird", "chim");

            Console.WriteLine("cat= "+tableDV["cat"]);

            foreach (DictionaryEntry item in tableDV)
            {
                Console.WriteLine(item.Key + " - "+ item.Value);
            }
            ////////////
            Console.WriteLine("==========================");
            //khởi tạo table thực vật
            Hashtable tableTV= new Hashtable();
            //thêm vào table
            tableTV.Add(1, new ThucVat(11, "Co", 2));
            tableTV.Add(2, new ThucVat(22, "Cay", 5));
            tableTV.Add(3, new ThucVat(33, "Hoa", 1));
            tableTV.Add(4, new ThucVat(44, "La", 2));
            tableTV.Add("5", new ThucVat(44, "La", 2));
            //duyệt
            /* 
            * In các phần tử trong Hashtable.
            * Vì mỗi phần tử là 1 DictionaryEntry nên ta chỉ định kiểu dữ liệu cho item là DictionaryEntry luôn.
            * Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
            */
            foreach (DictionaryEntry item in tableTV)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
                ThucVat tv = (ThucVat) item.Value;
                tv.Show();
            }
            foreach (ThucVat tv in tableTV.Values)
            {
                tv.Show();
            }
        }
        static void DemoDictionary()
        {
            //Dictionary dic = new Dictionary();
            Dictionary<int,ThucVat> dic = new Dictionary<int, ThucVat>();
            dic.Add(1, new ThucVat(11, "Co", 2));
            dic.Add(2, new ThucVat(22, "Cay", 5));
            dic.Add(3, new ThucVat(33, "Hoa", 1));
            dic.Add(4, new ThucVat(44, "La", 2));
            //dic.Add("5", new ThucVat(44, "La", 2));
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
                ThucVat tv = item.Value;
                tv.Show();
            }
        }
    }
}
