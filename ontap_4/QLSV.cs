using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap_4
{
    internal class QLSV
    {
        private List<Student> _lst;
        Student _student;
        private string input;
        public QLSV()
        {
            _lst = new List<Student>
            {
                new Student("A", "0917899", "PH23094", 1),
                new Student("B", "0987899", "PH23094", 2),
                new Student("C", "0987899", "PH23094", 1),
                new Student("D", "0987899", "PH23094", 3),
                new Student("T", "0987899", "PH23094", 1)
            };
        }

        public void add()
        {
            Console.Write("Mời bạn nhập số lượng muốn thêm:");
            input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(input); i++)
            {
                _student = new Student();
                Console.Write("Mời bạn nhập tên:");
                _student.Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập sdt:");
                _student.Sdt = Console.ReadLine();
                Console.Write("Mời bạn nhập msv:");
                _student.Msv = Console.ReadLine();
                string temp;
                do
                {
                    Console.WriteLine("Mời bạn nhập ngành:");
                    Console.WriteLine("1.Ứng dung phần mềm");
                    Console.WriteLine("2. Web");
                    Console.WriteLine("3.Mobile");
                    Console.WriteLine("Bạn học ngành nào:");
                    temp = Console.ReadLine();
                    switch (temp)
                    {
                        case "1":
                            _student.Nganh = 1;
                            break;
                        case "2":
                            _student.Nganh = 2;

                            break;
                        case "3":
                            _student.Nganh = 3;

                            break;
                        default:
                            Console.WriteLine("Không có ngành học này, vui lòng chon lại!");
                            break;
                    }
                } while (!(temp == "1" || temp == "2" || temp == "3"));
                _lst.Add(_student);
            }
        }
        public void edit()
        {
            int temp = getIndexById();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }

            Console.WriteLine("Các thông tin cần sửa");
            Console.WriteLine("1. Tên");
            Console.WriteLine("2. Số điện thoại");
            Console.WriteLine("3. Ngành");
            Console.Write("Bạn muốn sửa thông tin nào:");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Write("Mời bạn nhập tên mới:");
                    _lst[temp].Ten = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Mời bạn nhập số điẹn thoại mới:");
                    _lst[temp].Sdt = Console.ReadLine();
                    break;
                case "3":
                    string tempInput;
                    do
                    {
                        Console.WriteLine("Mời bạn nhập ngành:");
                        Console.WriteLine("1.Ứng dung phần mềm");
                        Console.WriteLine("2. Web");
                        Console.WriteLine("3.Mobile");
                        Console.Write("Bạn học ngành nào:");
                        tempInput = Console.ReadLine();

                        switch (tempInput)
                        {
                            case "1":
                                _lst[temp].Nganh = 1;
                                break;
                            case "2":
                                _lst[temp].Nganh = 2;

                                break;
                            case "3":
                                _lst[temp].Nganh = 3;

                                break;
                            default:
                                Console.WriteLine("Không có ngành học này, vui lòng chon lại!");
                                break;
                        }
                    } while (!(tempInput == "1" || tempInput == "2" || tempInput == "3"));
                    break;
                default:
                    Console.WriteLine("Không có thông tin bạn muốn sửa");
                    break;
            }
        }
        public void delete()
        {
            int temp = getIndexById();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            _lst.RemoveAt(temp);
            Console.WriteLine("Xóa thành công!");
        }
        public void find()
        {
            int temp = getIndexById();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            _lst[temp].inRaManHinh();
        }
        public void filter()
        {
            Console.WriteLine("Lọc theo nhà mạng nào");
            Console.WriteLine("1. Viettel");
            Console.WriteLine("2. Vina");
            Console.Write("Mời bạn chọn chúc năng:");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    foreach (var x in _lst.Where(c =>c.Sdt.StartsWith("098")))
                    {
                        x.inRaManHinh();
                    }
                    break;
                case "2":
                    foreach (var x in  _lst)
                    {
                        if (x.Sdt.StartsWith("091"))
                        {
                            x.inRaManHinh();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        public void print()
        {
            foreach (var x in _lst)
            {
                x.inRaManHinh();
            }
        }

        public int getIndexById()
        {
            Console.Write("Mời bạn nhập mã:");
            input = Console.ReadLine();
            for (int i = 0; i < _lst.Count; i++)
            {
                if (_lst[i].Msv == input)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
