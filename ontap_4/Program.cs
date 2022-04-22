using System;
using System.Text;

namespace ontap_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.GetEncoding("UTF-8");
            QLSV ql = new QLSV();
            do
            {
                Console.WriteLine("Quản lí sinh viên");
                Console.WriteLine("1. Thêm");
                Console.WriteLine("2. Sửa");
                Console.WriteLine("3. Xóa");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Xuất");
                Console.WriteLine("6. Lọc");
                Console.Write("Mời bạn chọn chức năng:");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ql.add();
                        break;
                    case "2":
                        ql.edit();
                        break;
                    case "3":
                        ql.delete();
                        break;
                    case "4":
                        ql.find();
                        break;
                    case "5":
                        ql.print();
                        break;
                    case "6":
                        ql.filter();
                        break;

                    default:
                        Console.WriteLine("Không có chức năng này!");
                        break;
                }
            } while (true);
        }
    }
}
