using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopStructure
{
    class Program
    {
        //Bài 1: Viết chương trình C# để tính tổng 10 số đầu tiên
        private static void BaiTap1()
        {
            int j, sum = 0;

            Console.Write("\n");
            Console.Write("Tinh tong day so trong C#:\n");
            Console.Write("-----------------------------");
            Console.Write("\n\n");

            Console.Write("10 so tu nhien dau tien la:\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\nTong cua 10 so tren la: {0}\n", sum);

            Console.ReadKey();
        }
        //Bài 2: Viết chương trình C# để hiển thị các số trong hệ thập lục phân có giá trị 0-255 (hệ thập phân) trong 16 hàng,
        //trong đó: hàng đầu sẽ gồm các số từ 0-15, hàng thứ hai sẽ gồm các số từ 16-31, ...
        private static void BaiTap2()
        {
            Console.Write("\n");
            Console.Write("Hien thi bang so Hex tu 0-255 (he thap phan) trong C#:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            for (int i = 0; i <= 255; i++)
            {
                if (i < 16)  // 0 la so dau tien trong hai so cua hang dau tien
                    Console.Write("0");

                Console.Write("{0} ",
                    Convert.ToString(i, 16));  // so trong he thap luc phan

                if (i % 16 == 15)    // nhay toi hang tiep theo
                    Console.WriteLine();
            }

            Console.ReadKey();
        }
        //Bài 3: Viết chương trình C# để in bảng cửu chương. Đây là bài tập C# cơ bản minh họa giúp bạn cách sử dụng vòng lặp DO...WHILE trong C#.
        private static void BaiTap3()
        {
            Console.Write("\n");
            Console.Write("In bang cuu chuong trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            int num, so_nhan;
            num = 2;

            do
            {
                so_nhan = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}",
                        num, so_nhan, num * so_nhan);
                    so_nhan++;
                }
                while (so_nhan <= 10);

                Console.WriteLine();
                num++;

            } while (num <= 9);

            Console.ReadKey();
        }
        //Bài 4: Nhập một số và kiểm tra xem đó có phải là số nguyên tố không và hiển thị thông báo phù hợp.
        private static void BaiTap4()
        {
            Console.Write("\n");
            Console.Write("Kiem tra so nguyen to trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            int number;
            int bien_dem = 0;

            Console.Write("Nhap mot so bat ky: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    bien_dem++;

            if (bien_dem == 2)
                Console.WriteLine("So da cho la so nguyen to.");
            else
                Console.WriteLine("So da cho khong phai la so nguyen to.");

            Console.ReadKey();
        }
        //Bài 5: Viết chương trình C# để tìm các số nguyên tố trong một dãy cho trước
        private static void BaiTap5()
        {
            int num, i, ctr, bat_dau, ket_thuc;

            Console.Write("\n\n");
            Console.Write("Tim so nguyen to trong C#:\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so bat dau cua day: ");
            bat_dau = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ket thuc cua day: ");
            ket_thuc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac so nguyen to trong day tu {0} toi {1} la: \n", bat_dau, ket_thuc);

            for (num = bat_dau; num <= ket_thuc; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");

            Console.ReadKey();
        }
        //Bài 6: Viết chương trình C# để nhập một số và sau đó in bảng nhân của số đó
        private static void BaiTap6()
        {
            int j, n;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de in bang nhan cua so bat ky:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }

            Console.ReadKey();
        }
        //Bài 7: Viết chương trình C# để hiển thị và tính tổng n số lẻ
        private static void BaiTap()
        {
            int i, n, sum = 0;
            Console.Write("\n");
            Console.Write("Hien thi va tinh tong n so le trong C#:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so cac so: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHien thi cac so le: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nTong {0} so le ban dau la: {1} \n", n, sum);

            Console.ReadKey();
        }
        //Bài 8: Viết chương trình C# để hiển thị và tính tổng n số chẵn
        private static void BaiTap8()
        {
            int i, n, sum = 0;

            Console.Write("\n");
            Console.Write("Hien thi va tinh tong n so chan trong C#:\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so cac so: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nCac so chan la: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i);
                sum += 2 * i;
            }
            Console.Write("\nTong {0} so chan dau tien la : {1} \n", n, sum);

            Console.ReadKey();
        }
        //Bài 9: Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác rồi sau đó vẽ tam giác sao với độ rộng đó
        private static void BaiTap9()
        {
            int i, j, so_hang;
            Console.Write("\n");
            Console.Write("Ve tam giac sao trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
        //Bài 10: Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số có số hàng đó
        private static void BaiTap10()
        {
            int i, j, so_hang;

            Console.Write("\n");
            Console.Write("Ve tam giac so trong C#:\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }

            Console.ReadKey();
        }
        //Bài 11: Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số có số hàng đó và các số được lặp lại trong mỗi hàng.
        private static void BaiTap11()
        {
            int i, j, so_hang;

            Console.Write("\n");
            Console.Write("Ve tam giac so trong C#:\n");
            Console.Write("------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", i);
                Console.Write("\n");
            }

            Console.ReadKey();
        }
        //Bài 12 : Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số có số hàng đó và các số trong tam giác được hiển thị theo thứ tự tăng dần.
        private static void BaiTap12()
        {
            int i, j, so_hang, k = 1;

            Console.Write("\n");
            Console.Write("Ve tam giac so trong C# - cac so trong tam giac co thu tu tang dan:\n");
            Console.Write("-------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", k++);
                Console.Write("\n");
            }

            Console.ReadKey();
        }
        //Bài 13: Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số cân có số hàng đó và các số trong tam giác được hiển thị theo thứ tự tăng dần.
        private static void BaiTap13()
        {
            int i, j, bien_dem, so_hang, k, t = 1;

            Console.Write("\n");
            Console.Write("Ve tam giac so can trong C# - cac so trong tam giac co thu tu tang dan:\n");
            Console.Write("-----------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            bien_dem = so_hang - 1;
            for (i = 1; i <= so_hang; i++)
            {
                //in khoản trắng
                for (k = bien_dem; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                bien_dem--;
            }

            Console.ReadKey();
        }
        //Bài 14: Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số cân có số hàng đó và các số được lặp lại trong mỗi hàng.
        private static void BaiTap14()
        {
            int i, j, bien_dem, so_hang, k;

            Console.Write("\n");
            Console.Write("Ve tam giac so trong C# - cac so duoc lap lai trong moi hang:\n");
            Console.Write("------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            bien_dem = so_hang - 1;
            for (i = 1; i <= so_hang; i++)
            {
                for (k = bien_dem; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", i);
                Console.Write("\n");
                bien_dem--;
            }

            Console.ReadKey();
        }
        //Bài 15: Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác sao và sau đó vẽ tam giác sao đều có số hàng đó.
        private static void BaiTap15()
        {
            int i, j, bien_dem, so_hang, k;

            Console.Write("\n");
            Console.Write("Ve tam giac sao deu trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            bien_dem = so_hang - 1;
            for (i = 1; i <= so_hang; i++)
            {
                for (k = bien_dem; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                bien_dem--;
            }

            Console.ReadKey();
        }
        //Bài 16: Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác sao và sau đó vẽ tam giác sao cân có số hàng đó (mỗi hàng có số sao là số lẻ).
        private static void BaiTap16()
        {
            int i, j, n;

            Console.Write("\n");
            Console.Write("Ve tam giac sao can trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
        //Bài 17: Bài tập C# này tương tự như bài tập vẽ tam giác sao trong C#. Hình kim cương (hay hình thoi) bằng dấu sao.
        private static void BaiTap17()
        {
            int i, j, r;

            Console.Write("\n");
            Console.Write("Ve hinh kim cuong bang dau sao trong C#:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang (mot nua cua hinh kim cuong): ");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            Console.ReadKey();
        }
        //Bài 18: Tìm giai thừa
        private static void BaiTap18()
        {
            int i, f = 1, num;

            Console.Write("\n");
            Console.Write("Tim giai thua trong C#:\n");
            Console.Write("------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("Giai thua cua {0} la: {1}\n", num, f);

            Console.ReadKey();
        }
        //Bài 19: Chương trình C# để tìm tổng dãy số: 1 - x2/2! + x4/4! - ... với giá trị x và số phần tử nhập từ bàn phím.
        private static void BaiTap19()
        {
            double x, sum, t, d;
            int i, n;

            Console.Write("\n");
            Console.Write("Tim tong day so trong C#:\n");
            Console.Write("------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap gia tri cua x: ");

            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 1; t = 1;
            for (i = 1; i < n; i++)
            {
                d = (2 * i) * (2 * i - 1);
                t = -t * x * x / d;
                sum = sum + t;
            }
            Console.Write("\nTong = {0}\nSo phan tu = {1}\nGia tri cua x = {2}\n", sum, n, x);

            Console.ReadKey();
        }
        //Bài 20: Chương trình C# để tìm tổng dãy số: 1/1 + 1/2 + 1/3 + 1/4 + ... với số phần tử nhập từ bàn phím.
        private static void BaiTap20()
        {
            int i, n;
            double s = 0.0;

            Console.Write("\n");
            Console.Write("Tinh tong day so trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write("1/{0} + ", i);
                }
                else
                {
                    Console.Write("1/{0}", i);
                }

                s += 1 / (float)i;
            }
            Console.Write("\n\nTong cua day {0} phan tu bang: {1} \n", n, s);
            Console.ReadKey();
        }
        //Bài 21: Viết chương trình C# để tính tổng dãy số 9 + 99 + 999 + ... với số phần tử nhập từ bàn phím.
        private static void BaiTap21()
        {
            int n, i, t = 9;
            int sum = 0;

            Console.Write("\n");
            Console.Write("Tinh tong day so trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += t;
                if (i < n)
                {
                    Console.Write("{0} + ", t);
                }
                else
                {
                    Console.Write("{0}", t);
                }

                t = t * 10 + 9;
            }
            Console.Write("\nTong cua day so tren = {0} \n", sum);
            Console.ReadKey();
        }
        //Bài 22: Yêu cầu bài tập C# này là nhập một số từ bàn phím, kiểm tra xem số đó có phải là số hoàn hảo hay không và đưa ra thông báo tương ứng.
        //Số hoàn hảo là số có tổng các ước số dương (ngoại trừ chính số đó) bằng chính số đó.
        private static void BaiTap22()
        {
            int n, i, sum;

            Console.Write("\n");
            Console.Write("Kiem tra so hoan hoa trong C#:\n");
            Console.Write("------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("Cac uoc so duong cua so da cho: ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nTong cua cac uoc so: {0}", sum);
            if (sum == n)
                Console.Write("\nSo da cho la so hoan hao.");
            else
                Console.Write("\nSo da cho khong phai la so hoan hao.");
            Console.Write("\n");
            Console.ReadKey();
        }
        //Bài 23: Viết chương trình C# để tìm số hoàn hảo trong một dãy cho trước. Số hoàn hảo là số có tổng các ước số dương (ngoại trừ chính số đó) bằng chính số đó
        private static void BaiTap23()
        {
            int n, i, sum;
            int mn, mx;

            Console.Write("\n");
            Console.Write("Tim so hoan hao trong C#:\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so bat dau cua day so: ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ket thuc cua day so: ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac so hoan hao trong day da cho la: ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
            Console.ReadKey();
        }
        //Bài 24: Viết chương trình C# để nhập một số và kiểm tra xem số đó có phải là số Armstrong không.
        //Số Armstrong là số bằng tổng lập phương các chữ số của số đó.
        private static void BaiTap24()
        {
            int num, r, sum = 0, temp;

            Console.Write("\n");
            Console.Write("Kiem tra so armstrong trong C#:\n");
            Console.Write("------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (temp = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum + (r * r * r);
            }
            if (sum == temp)
                Console.Write("So {0} la so Armstrong.\n", temp);
            else
                Console.Write("So {0} khong phai la so Armstrong.\n", temp);

            Console.ReadKey();
        }
        //Bài 25: Viết chương trình C# để tìm các số Armstrong trong một dãy số đã cho.
        //Số Armstrong là số bằng tổng lập phương các chữ số của số đó.
        private static void BaiTap25()
        {
            int num, r, sum, temp;
            int stno, enno;

            Console.Write("\n");
            Console.Write("Tim so Armstrong trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so bat dau cua day: ");
            stno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so ket thuc cua day: ");
            enno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cac so Armstrong trong day da cho la: ");
            for (num = stno; num <= enno; num++)
            {
                temp = num;
                sum = 0;

                while (temp != 0)
                {
                    r = temp % 10;
                    temp = temp / 10;
                    sum = sum + (r * r * r);
                }
                if (sum == num)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");

            Console.ReadKey();
        }
        //Bài 26: Viết chương trình C# để nhập số hàng và từ đó vẽ tam giác Pascal với số hàng đó.
        private static void BaiTap26()
        {
            int so_hang, c = 1, khoang_trang, i, j;

            Console.Write("\n");
            Console.Write("Ve tam giac Pascal trong C#:\n");
            Console.Write("---------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < so_hang; i++)
            {
                for (khoang_trang = 1; khoang_trang <= so_hang - i; khoang_trang++)
                    Console.Write("  ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write("{0}   ", c);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        //Bài 27: Viết chương trình C# để in n số đầu tiên trong dãy Fibonacci với n được nhập từ bàn phím.
        private static void BaiTap27()
        {
            int prv = 0, pre = 1, trm, i, n;

            Console.Write("\n");
            Console.Write("In day Fibonacci trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so phan tu can hien thi: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Day Fibonacci gom {0} phan tu la: \n", n);
            Console.Write("{0} {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write(" {0} ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
            Console.ReadKey();
        }
        //Bài 28: Viết chương trình C# để vẽ một tam giác số theo mẫu sau: Số bắt đầu và số kết thúc của mỗi hàng là số 1
        private static void BaiTap28()
        {
            int i, j, n;

            Console.Write("\n");
            Console.Write("Ve tam giac so trong C#:\n");
            Console.Write("-----------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                /* vong lap nay de in khoang trang */
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                /* Hien thi cac so theo thu tu tang dan tu dau hang cho den giua hang*/
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);

                /* Hien thi so theo thu tu giam dan tu giua hang cho den cuoi hang */
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);

                Console.Write("\n");
            }

            Console.ReadKey();
        }
        //Bài 29 : Viết chương trình C# để nhập một số bất kỳ và in số đó theo chiều đảo ngược
        private static void BaiTap29()
        {
            int num, r, sum = 0, t;

            Console.Write("\n");
            Console.Write("In so theo chieu dao nguoc trong C#:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; t != 0; t = t / 10)
            {
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("So theo chieu dao nguoc cua so da cho la: {0} \n", sum);

            Console.ReadKey();
        }
        //Bài 30: Số đối xứng, hay còn gọi là số Palindrome, là các số dù đọc theo chiều xuôi hay chiều ngược thì đều giống nhau, ví dụ: 121, 4224, ...
        private static void BaiTap30()
        {
            int num, r, sum = 0, t;

            Console.Write("\n");
            Console.Write("Kiem tra so doi xung trong C# | Kiem tra so palindrome trong C#:\n");
            Console.Write("-----------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
                Console.Write("So {0} la so doi xung (so palindrome).\n", t);
            else
                Console.Write("So {0} khong phai la so doi xung (so palindrome).\n", t);


            Console.ReadKey();
        }
        //Bài 31: Viết chương trình C# để vẽ tam giác chữ cái với số chữ cái (nhỏ hơn 26)
        private static void BaiTap31()
        {
            int i, j;
            char alph = 'A';
            int n;
            int ctr = 1;

            Console.Write("\n");
            Console.Write("Ve tam giac chu cai trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so chu cai (nho hon 26): ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 0; j <= (ctr / 2); j++)
                {
                    Console.Write("{0} ", alph++);
                }
                alph--;
                alph--;

                for (j = 0; j < (ctr / 2); j++)
                {
                    Console.Write("{0} ", alph--);
                }
                ctr = ctr + 2;
                alph = 'A';
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        //Bài 32: Viết chương trình C# để tìm ước số chung lớn nhất của hai số được nhập từ bàn phím
        private static void BaiTap32()
        {
            int i, n1, n2, j, uscln = 1;
            Console.Write("\n");
            Console.Write("Tim uoc so chung lon nhat trong C#:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            j = (n1 < n2) ? n1 : n2;
            for (i = 1; i <= j; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    uscln = i;
                }
            }
            Console.Write("\nUSCLN cua {0} va {1} la: {2}\n\n", n1, n2, uscln);

            Console.ReadKey();
        }
        //Bài 33: Viết chương trình C# để tìm bội số chung nhỏ nhất của hai số bất kỳ được nhập từ bàn phím bằng cách sử dụng ước số chung lớn nhất (USCLN) của hai số đó.
        private static void BaiTap33()
        {
            int i, n1, n2, j, hcf = 1, bscnn;
            Console.Write("\n");
            Console.Write("Tim boi so chung nho nhat trong C# (su dung USCLN):\n");
            Console.Write("--------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            j = (n1 < n2) ? n1 : n2;

            for (i = 1; i <= j; i++)
            {

                if (n1 % i == 0 && n2 % i == 0)
                {
                    hcf = i;
                }
            }
            /* chung ta biet rang: tich cua uoc so chung lon nhat va boi 
            so chung nho nhat thi bang tich cua hai so.*/
            bscnn = (n1 * n2) / hcf;

            Console.Write("\nBSCNN cua {0} va {1} la: {2}\n\n", n1, n2, bscnn);

            Console.ReadKey();
        }
        //Bài 34: Viết chương trình C# để tìm bội số chung nhỏ nhất của hai số bất kỳ được nhập từ bàn phím (không sử dụng USCLN).
        private static void BaiTap34()
        {
            int i, n1, n2, max, bscnn = 1;
            Console.Write("\n");
            Console.Write("Tim boi so chung nho nhat trong C# (khong su dung USCLN):\n");
            Console.Write("-------------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            max = (n1 > n2) ? n1 : n2;
            for (i = max; ; i += max)
            {
                if (i % n1 == 0 && i % n2 == 0)
                {
                    bscnn = i;
                    break;
                }
            }
            Console.Write("\nBSCNN cua {0} va {1} = {2}\n\n", n1, n2, bscnn);

            Console.ReadKey();
        }
        //Bài 35: Strong Number là số có tổng giai thừa của các chữ số bằng chính số ban đầu.
        private static void BaiTap35()
        {
            int i, n, n1, s1 = 0, j;
            int fact;

            Console.Write("\n");
            Console.Write("Kiem tra Strong Number trong C#:\n");
            Console.Write("------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so bat ky de kiem tra: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;

            for (j = n; j > 0; j = j / 10)
            {

                fact = 1;
                for (i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                s1 = s1 + fact;

            }

            if (s1 == n1)
            {
                Console.Write("\nSo {0} la Strong number.\n\n", n1);
            }
            else
            {
                Console.Write("\nSo {0} khong phai la Strong number.\n\n", n1);
            }

            Console.ReadKey();
        }
        //Bài 36: Viết chương trình C# để tìm Strong Number trong một dãy đã cho. Strong Number là số có tổng giai thừa của các chữ số bằng chính số ban đầu
        private static void BaiTap36()
        {
            int i, n1, s1 = 0, j, k, en, sn;
            int fact;

            Console.Write("\n");
            Console.Write("Tim Strong Number trong C#:\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so bat dau cua day: ");
            sn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ket thuc cua day: ");
            en = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nCac Strong Number la:\n");

            for (k = sn; k <= en; k++)
            {
                n1 = k;
                s1 = 0;

                for (j = k; j > 0; j = j / 10)
                {

                    fact = 1;
                    for (i = 1; i <= j % 10; i++)
                    {
                        fact = fact * i;
                    }
                    s1 = s1 + fact;
                }

                if (s1 == n1)

                    Console.Write("{0}  ", n1);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 37: Viết chương trình C# để nhập một số và kiểm tra xem số đó có thể biểu diễn bằng tổng của hai số nguyên tố không
        private static void BaiTap37()
        {
            int n, i, flg1 = 1, flg2 = 1, flg3 = 0, j;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de kiem tra xem mot so co the bieu dien bang\n");
            Console.Write("          tong cua hai so nguyen to khong:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so duong: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 3; i <= n / 2; i++)
            {
                /*---------- Kiem tra so nguyen to---------------*/
                flg1 = 1;
                flg2 = 1;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { flg1 = 0; j = i; }
                }
                for (j = 2; j < n - i; j++)
                {
                    if ((n - i) % j == 0)
                    { flg2 = 0; j = n - i; }
                }
                if (flg1 == 1 && flg2 == 1)
                {
                    Console.Write("{0} =  {1} + {2}  \n", n, i, n - i);
                    flg3 = 1;
                }
            }
            if (flg3 == 0)
            {
                Console.Write("\nSo {0} khong the bieu dien bang tong cua hai so nguyen to.\n\n", n);
            }

            Console.ReadKey();
        }
        //Bài 38: Viết chương trình C# để nhập một chuỗi bất kỳ, sau đó in chuỗi theo chiều đảo ngược
        private static void BaiTap38()
        {
            string str, str1 = "";
            int i, l;

            Console.Write("\n");
            Console.Write("In chuoi theo chieu dao nguoc trong C#:\n");
            Console.Write("-------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }

            Console.WriteLine("Chuoi dao nguoc cua chuoi ban dau la: {0}", str1);
            Console.Write("\n");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BaiTap15();
        }
    }
}
