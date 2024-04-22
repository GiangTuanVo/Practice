using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    class Program
    {
        //Bài 1: Nhập 3 chữ cái và hiển thị theo chiều ngược lại trong C#.
        private static void BaiTap1()
        {
            char letter, letter1, letter2;

            Console.Write("Nhap chu cai thu nhat: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap chu cai thu hai: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap chu cai thu ba: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Hien thi 3 chu cai theo chieu nguoc lai: ");
            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);

            Console.ReadKey();

        }
        //Bài 2: Chương trình vẽ tam giác số
        private static void BaiTap2()
        {
            Console.Write("Nhap mot so bat ky: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap do rong cua tam giac: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }

            Console.ReadKey();
        }
        //Bài 3: Kiểm tra tên đăng nhập và mật khẩu trong C#
        private static void BaiTap3()
        {
            string user, password;
            Console.Write("Kiem tra ten dang nhap va mat khau:\n");
            Console.Write("Gia tri mac dinh la: user va password\n");
            Console.Write("---------------------------------\n");
            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();

                Console.Write("Mat khau: ");
                password = Console.ReadLine();
            }
            while (user != "user" && password != "password");

            Console.WriteLine("Ten dang nhap va mat khau đúng!");

            Console.ReadKey();

        }
        //Bài 4: Chương trình C# để kiểm tra tên đăng nhập và mật khẩu, và nếu nhập tên và mật khẩu sai quá 3 lần thì in thông báo lỗi
        private static void BaiTap4()
        {
            string user, pass;
            int count = 0;
            Console.Write("Kiem tra ten dang nhap va mat khau:\n");
            Console.Write("Gia tri mac dinh la: user va password\n");
            Console.Write("---------------------------------\n");
            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();

                Console.Write("Mat khau: ");
                pass = Console.ReadLine();

                count++;
            }
            while (((user != "user") || (pass != "password"))
                && (count != 3));

            if (count == 3)
                Console.Write("Dang nhap that bai!");
            else
                Console.Write("Mat khau chinh xac. Ban da dang nhap thanh cong!");

            Console.ReadKey();
        }
        //Bài 5: Chương trình để nhập hai số và nhập một phép toán. Tương ứng với phép toán đã nhập bạn thực hiện phép tính trên hai số và in kết quả ra màn hình
        private static void BaiTap5()
        {
            int x, y;
            char phepToan;

            Console.Write("Nhap so dau tien: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phep toan: ");
            phepToan = Convert.ToChar(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (phepToan == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (phepToan == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((phepToan == 'x') || (phepToan == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (phepToan == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Ban da nhap sai phep toan!!!");

            Console.ReadKey();
        }
        //Bài 6: Tìm chu vi và diện tích hình tròn trong C#
        private static void BaiTap6()
        {
            double r, chu_vi, dien_tich;
            double PI = Math.PI;
            Console.Write("Nhap ban kinh duong tron: ");
            r = Convert.ToDouble(Console.ReadLine());
            chu_vi = 2 * PI * r;
            Console.WriteLine("\nChu vi duong tron la: {0}", chu_vi);
            dien_tich = PI * r * r;
            Console.WriteLine("Dien tich duong tron la: {0}", dien_tich);
            Console.Read();

            Console.ReadKey();
        }
        //Bài 7: Chương trình C# để tìm giá trị cụ thể của một hàm số với dãy giá trị của biến
        //Ví dụ: tìm giá trị của hàm số x = y2 - 2y + 1 với y thuộc đoạn[-5, 5].
        private static void BaiTap7()
        {
            int x, y;

            Console.WriteLine("x = y² - 2y +1");
            Console.WriteLine();

            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine("y = {0} ; x=({0})² - 2*({0}) +1 = {1}", y, x);
            }
            Console.ReadKey();
        }
        //Bài 8: Tìm vận tốc (m/s, km/h, mile/h) với quãng đường và thời gian nhập từ bàn phím trong C#
        private static void BaiTap8()
        {
            float quang_duong;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Nhap quang duong (don vi met): ");
            quang_duong = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap thoi gian - so gio: ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap thoi gian - so phut: ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap thoi gian - so giay: ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = quang_duong / timeSec;
            kph = (quang_duong / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Van toc la {0} m/s", mps);
            Console.WriteLine("Van toc la {0} km/h", kph);
            Console.WriteLine("Van toc la {0} mile/h", mph);

            Console.ReadKey();
        }
        //Bài 9: Tìm diện tích và thể tích hình cầu trong C#
        private static void BaiTap9()
        {
            double r;
            double pi = Math.PI;

            Console.Write("Nhap ban kinh hinh cau: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.Write("\nDien tich hinh cau la: ");
            Console.WriteLine(4 * pi * (r * r));

            Console.Write("\nThe tich hinh cau la: ");
            Console.WriteLine(4 / 3 * pi * (r * r * r));

            Console.ReadKey();

        }
        //Bài 10 : Chương trình C# để kiểm tra một chữ cái thường nhập từ bàn phím là nguyên âm, chữ số hay ký tự khác
        private static void BaiTap10()
        {
            char symbol;

            Console.Write("Nhap mot ky tu bat ky: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("Ky tu vua nhap la nguyen am.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("Ky tu vua nhap la chu so.");
            else
                Console.Write("Ky tu vua nhap khong phai nguyen am va chu so.");

            Console.ReadKey();
        }
        //Bài 11: Kiểm tra chẵn lẻ trong C#, nhập hai số từ bàn phím, trả về true nếu cả hai số cùng chẵn, nếu không thì trả về false.
        private static void BaiTap11()
        {
            int n1, n2;
            bool bothEven;
            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven = ((n1 % 2 == 0)
                && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ?
              "Ca hai so deu la so chan" :
              "Hai so khong phai deu la so chan");

            Console.ReadKey();

        }
        //Bài 12: Chương trình C# để chuyển đổi thập phân thành nhị phân
        private static void BaiTap12()
        {
            string answer;
            string result;

            Console.Write("Nhap mot so bat ky trong he thap phan: ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("So trong he nhi phan tuong ung la: {0}", result);

            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BaiTap12();
        }
    }
}
