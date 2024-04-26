using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayTwoWay
{
    class Program
    {
        //Bài 1: Viết chương trình C# để nhập một mảng hai chiều có kích cỡ 3x3, sau đó in các phần tử mảng hai chiều này trên màn hình.
        private static void BaiTap1()
        {
            int i, j;
            int[,] arr1 = new int[3, 3];

            Console.Write("\nDoc va in mang hai chieu trong C#:\n");
            Console.Write("-----------------------------------\n");


            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap cac phan tu vao trong mang hai chieu:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nIn mang hai chieu: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 2: Viết chương trình C# để cộng hai ma trận và sau đó in ma trận kết quả trên màn hình
        private static void BaiTap2()
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] ma_tran_tong = new int[50, 50];

            Console.Write("\nCong hai ma tran trong C#:\n");
            Console.Write("----------------------------\n");
            Console.Write("Nhap kich co cua hai ma tran vuong (nho hon 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Nhap cac phan tu vao trong mang da chieu*/
            Console.Write("Nhap cac phan tu vao trong ma tran dau tien:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Nhap cac phan tu vao trong ma tran thu hai:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nIn ma tran thu nhat:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            Console.Write("\nIn ma tran thu hai:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }
            /* cong hai ma tran */
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    ma_tran_tong[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nMa tran tong cua hai ma tran tren la: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", ma_tran_tong[i, j]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 3: Viết chương trình C# để trừ ma trận và sau đó in ma trận kết quả trên màn hình
        private static void BaiTap3()
        {
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] ma_tran_hieu = new int[50, 50];

            Console.Write("\nTru ma tran trong C#:\n");
            Console.Write("------------------------------\n");
            Console.Write("Nhap kich co cua hai ma tran (nho hon 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Nhap cac phan tu vao trong mang hai chieu*/
            Console.Write("Nhap cac phan tu vao trong ma tran thu nhat:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Nhap cac phan tu vao trong ma tran thu hai:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nIn ma tran thu nhat:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            Console.Write("\nIn ma tran thu hai:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }
            /* tru ma tran */
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    ma_tran_hieu[i, j] = arr1[i, j] - arr2[i, j];
            Console.Write("\nMa tran hieu cua hai ma tran tren la: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", ma_tran_hieu[i, j]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BaiTap2();
        }
    }
}
