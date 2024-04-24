using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayOneWay
{
    class Program
    {
        //Bài 1:Viết chương trình C# để khai báo một mảng, sau đó lưu giữ các phần tử vào mảng rồi in các phần tử mảng này trên màn hình
        private static void BaiTap1()
        {
            int[] arr = new int[10];
            int i;
            Console.Write("\nDoc va in cac phan mang trong C#:\n");
            Console.Write("----------------------------------\n");

            Console.Write("Nhap 10 phan tu mang:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Phan tu - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nIn cac phan tu mang: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");

            Console.ReadKey();
        }
        //Bài 2: Viết chương trình C# để nhập các phần tử mảng, sau đó in các phần tử mảng theo chiều đảo ngược.
        private static void BaiTap2()
        {
            int i, n;
            int[] a = new int[100];

            Console.Write("\nIn mang theo chieu dao nguoc trong C#:\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Nhap {0} phan tu vao trong mang: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nCac phan tu duoc luu giu trong mang la: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            Console.Write("\n\nIn mang theo chieu dao nguoc: \n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 3: Viết chương trình C# để nhập các phần tử mảng, sau đó tìm tổng các phần tử của mảng và hiển thị kết quả trên màn hình.
        private static void BaiTap3()
        {
            int[] a = new int[100];
            int i, n, sum = 0;


            Console.Write("\nTim tong cac phan tu mang trong C#:\n");
            Console.Write("------------------------------------\n");

            Console.Write("Nhap so phan tu can luu tru vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Tong cac phan tu trong mang la: {0}\n\n", sum);

            Console.ReadKey();
        }
        //Bài 4: Viết chương trình C# để sao chép các phần tử của mảng này sang mảng khác.
        private static void BaiTap4()
        {
            int[] arr1 = new int[100]; //day la mang ban dau
            int[] arr2 = new int[100]; //day la mang sao
            int i, n;

            Console.Write("\nSao chep mang trong C#:\n");
            Console.Write("------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* sao chep cac phan tu trong mang arr1 vao trong mang arr2.*/
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            /* in cac phan tu trong mang arr1  */
            Console.Write("\nCac phan tu trong mang ban dau la:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            /* in cac phan tu trong mang arr2. */
            Console.Write("\n\nCac phan tu trong mang sao la:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BaiTap4();
        }
    }
}
