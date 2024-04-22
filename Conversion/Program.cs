using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversion
{
    class Program
    {
        //Bài 1: Viết chương trình C# để chuyển đổi một số trong hệ nhị phân thành một số trong hệ thập phân
        private static void BaiTap1()
        {
            int n1, n, p = 1;
            int dec = 0, i = 1, j, d;

            Console.Write("\n");
            Console.Write("Chuyen doi nhi phan thanh thap phan trong C#:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky trong he nhi phan: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;

                dec = dec + (d * p);
                i++;
            }
            Console.Write("\nSo trong he nhi phan: {0}\nSo thap phan tuong duong la: {1} \n\n", n1, dec);

            Console.ReadKey();
        }
        //Bài 2: Viết chương trình C# để chuyển đổi một số trong hệ nhị phân thành một số trong hệ thập phân bằng cách sử dụng hàm
        private static void BaiTap2()
        {
            int n1, n;
            double dec = 0, i = 0, d;

            Console.Write("\n");
            Console.Write("Chuyen doi nhi phan thanh thap phan trong C# (su dung ham):\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so trong he nhi phan: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            while (n != 0)
            {
                d = n % 10;
                dec = dec + d * Math.Pow(2, i); // su dung ham trong C#
                n = n / 10;
                i++;
            }
            Console.Write("\nSo trong he nhi phan: {0}\nSo thap phan tuong duong la: {1}\n\n", n1, dec);

            Console.ReadKey();
        }
        //Bài 3: Viết chương trình C# để chuyển đổi một số trong hệ thập phân thành số tương đương trong hệ bát phân (hệ Octal).
        private static void BaiTap3()
        {
            int n, i, j, ocno = 0, dn;

            Console.Write("\n");
            Console.Write("Chuyen doi thap phan thanh bat phan trong C#:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so thap phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            dn = n;
            i = 1;

            for (j = n; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i;
                i = i * 10;
                n = n / 8;
            }

            Console.Write("\nSo tuong duong trong he Octal cua so {0} la {1}.\n\n", dn, ocno);

            Console.ReadKey();
        }
        //Bài 4: Nhập một số trong hệ thập phân và chuyển đổi thành dạng nhị phân tương đương
        private static void BaiTap4()
        {
            int n, i, j, binno = 0, dn;
            Console.Write("\n");
            Console.Write("Chuyen doi thap phan thanh nhi phan trong C#:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so thap phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            dn = n;
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }

            Console.Write("\nSo trong he nhi phan tuong duong cua so {0} la {1}.\n\n", dn, binno);

            Console.ReadKey();
        }
        //Bài 5: Viết chương trình C# để chuyển đổi một số trong hệ bát phân (hệ Octal) thành số tương đương trong hệ thập phân
        private static void BaiTap5()
        {
            int n1, n5, p = 1, k, ch = 1;
            int dec = 0, i = 1, j, d;

            Console.Write("\n");
            Console.Write("Chuyen doi bat phan thanh thap phan trong C#:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so trong he bat phan (su dung cac so 0 - 7): ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n5 = n1;

            for (; n1 > 0; n1 = n1 / 10)
            {
                k = n1 % 10;
                if (k >= 8)
                {
                    ch = 0;
                }
            }

            switch (ch)
            {
                case 0:
                    Console.Write("\nSo vua nhap khong phai la so trong he bat phan. \n\n");
                    break;
                case 1:
                    n1 = n5;
                    for (j = n1; j > 0; j = j / 10)
                    {
                        d = j % 10;
                        if (i == 1)
                            p = p * 1;
                        else
                            p = p * 8;

                        dec = dec + (d * p);
                        i++;
                    }
                    Console.Write("\nSo trong he bat phan: {0}\nSo thap phan tuong duong la: {1} \n\n", n5, dec);
                    break;
            }
        }
        //Bài 6: Viết chương trình C# để chuyển đổi một số trong hệ nhị phân thành số tương đương trong hệ bát phân (hệ Octal)
        private static void BaiTap6()
        {
            int n1, n, p = 1;
            int dec = 0, i = 1, j, d;
            int ocno = 0;

            Console.Write("\n");
            Console.Write("Chuyen doi nhi phan thanh bat phan trong C#:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so nhi phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;

                dec = dec + (d * p);
                i++;
            }

            i = 1;

            for (j = dec; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i;
                i = i * 10;
                n = n / 8;
            }

            Console.Write("\nSo nhi phan: {0}\nSo tuong duong trong he bat phan la: {1} \n\n", n1, ocno);
            Console.ReadKey();
        }
        //Bài 7: Viết chương trình C# để chuyển đổi một số trong hệ bát phân (hệ Octal) thành số tương đương trong hệ nhị phân
        private static void BaiTap7()
        {
            int n1, n5, p = 1;
            int dec = 0, i = 1, j, d;
            int binno = 0;

            Console.Write("\n");
            Console.Write("Chuyen doi bat phan thanh nhi phan trong C#:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so trong he bat phan (su dung cac chu so 0 - 7): ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n5 = n1;

            for (j = n1; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 8;

                dec = dec + (d * p);
                i++;
            }

            /*------------------------------------------------------------------------------*/
            i = 1;

            for (j = dec; j > 0; j = j / 2)
            {
                binno = binno + (dec % 2) * i;
                i = i * 10;
                dec = dec / 2;
            }

            Console.Write("\nSo trong he bat phan: {0}\nSo tuong duong trong he nhi phan la: {1} \n\n", n5, binno);

            Console.ReadKey();
        }
        //Bài 8: Viết chương trình C# để chuyển đổi một số trong hệ thập phân thành số tương đương trong hệ thập lục phân (hệ Hexadecimal).
        private static void BaiTap8()
        {
            int decn, q, dn = 0, m, l;
            int tmp;
            int s;

            Console.Write("\n");
            Console.Write("Chuyen doi thap phan thanh thap luc phan trong C#:\n");
            Console.Write("--------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so thap phan: ");
            decn = Convert.ToInt32(Console.ReadLine());
            q = decn;
            for (l = q; l > 0; l = l / 16)
            {
                tmp = l % 16;
                if (tmp < 10)
                    tmp = tmp + 48;
                else
                    tmp = tmp + 55;
                dn = dn * 100 + tmp;
            }
            Console.Write("\nSo thap luc phan (so Hexa) tuong duong la: ");
            for (m = dn; m > 0; m = m / 100)
            {
                s = m % 100;
                Console.Write("{0}", (char)s);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
        }
    }
}
