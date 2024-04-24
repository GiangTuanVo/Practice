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
        //Bài 5: Viết chương trình C# để nhập các phần tử vào trong mảng, sau đó tìm số phần tử giống nhau trong mảng đó và in kết quả trên màn hình.
        private static void BaiTap5()
        {
            int[] arr1 = new int[100];
            int i, j, n, bien_dem = 0; //day la bien dem


            Console.Write("\nTim so phan tu giong nhau trong mot mang trong C#:\n");
            Console.Write("---------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Tim kiem cac phan tu giong nhau*/
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    /*Tang bien dem bien_dem khi tim thay phan tu giong nhau.*/
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                        break;
                    }
                }
            }

            Console.Write("\nSo phan tu giong nhau trong mang la: {0}\n\n", bien_dem);

            Console.ReadKey();
        }
        //Bài 6: Viết chương trình C# để nhập các phần tử vào trong một mảng, sau đó in các phần tử là duy nhất trong mảng trên màn
        //hình hiển thị (các phần tử là duy nhất nếu không có phần tử khác giống nó).
        private static void BaiTap6()
        {
            int n, bien_dem = 0;
            int[] arr1 = new int[100];
            int i, j, k;

            Console.Write("\nIn cac phan tu duy nhat cua mang trong C#:\n");
            Console.Write("------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*kiem ta cac phan tu giong nhau*/
            Console.Write("\nCac phan tu duy nhat duoc tim thay trong mang la: \n");
            for (i = 0; i < n; i++)
            {
                bien_dem = 0;

                /*kiem tra cac phan tu giong nhau truoc vi tri hien tai va tang bien_dem them 1 neu tim thay.*/
                for (j = 0; j < i - 1; j++)
                {
                    /*tang bien dem khi tim thay phan tu giong nhau.*/
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                    }
                }
                /*kiem tra cac phan tu giong nhau sau vi tri hien tai va tang bien_dem them 1 neu tim thay.*/
                for (k = i + 1; k < n; k++)
                {
                    /*tang bien dem khi tim thay phan tu giong nhau.*/
                    if (arr1[i] == arr1[k])
                    {
                        bien_dem++;
                    }
                }
                /*In gia tri cua vi tri hien tai trong mang - la gia tri duy nhat khi con tro van chua gia tri ban dau cua no.*/
                if (bien_dem == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 7: Viết chương trình C# để trộn (ghép) hai mảng có cùng kích cỡ và sau đó sắp xếp các phần tử của mảng trộn này theo thứ tự tăng dần.
        private static void BaiTap7()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[200];
            int s1, s2, s3;
            int i, j, k;


            Console.Write("\nTron (ghep) hai mang trong C#.\n");
            Console.Write("-------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang arr1: ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang arr1:\n", s1);
            for (i = 0; i < s1; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Nhap so phan tu can luu giu trong mang arr2: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang arr2:\n", s2);
            for (i = 0; i < s2; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* kich co cua mang tron = tong kich co cua mang arr1 va mang arr2 */
            s3 = s1 + s2;

            /*chen cac phan tu cua hai mang arr1 va arr2 vao mang thu ba */
            for (i = 0; i < s1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < s2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }
            /* sap xep theo thu tu tang dan*/
            for (i = 0; i < s3; i++)
            {
                for (k = 0; k < s3 - 1; k++)
                {

                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }
            /*in mang arr3*/
            Console.Write("\nMang tron da duoc sap xep theo thu tu tang dan:\n");
            for (i = 0; i < s3; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 8: Viết chương trình C# để đếm số lần xuất hiện của từng phần tử trong mảng và in kết quả trên màn hình
        private static void BaiTap8()
        {
            int[] arr1 = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, bien_dem;


            Console.Write("\nDem so lan xuat hien cua tung phan tu trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                bien_dem = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = bien_dem;
                }
            }
            Console.Write("\nTan suat xuat hien cua tung phan tu trong mang la: \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("Phan tu {0} xuat hien {1} lan\n", arr1[i], fr1[i]);
                }
            }

            Console.ReadKey();
        }
        //Bài 9: Viết chương trình C# để nhập một mảng, sau đó tìm phần tử lớn nhất và phần tử nhỏ nhất và in kết quả trên màn hình.
        private static void BaiTap9()
        {
            int[] arr1 = new int[100];
            int i, mx, mn, n;


            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);

            Console.ReadKey();
        }
        //Bài 10: Viết chương trình C# để nhập một mảng số nguyên và sau đó chia mảng này thành hai mảng: một mảng chẵn và một mảng lẻ rồi in kết quả trên màn hình.
        private static void BaiTap10()
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10]; // mang chua cac phan tu chan
            int[] arr3 = new int[10]; // mang chua cac phan tu le
            int i, j = 0, k = 0, n;


            Console.Write("\nChia mang thanh mang chan, mang le trong C#:\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nCac phan tu chan la: \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nCac phan tu le la:\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 11: Viết chương trình C# để nhập một mảng, sau đó sắp xếp mảng theo thứ tự tăng dần và in mảng đã sắp xếp trên màn hình.
        private static void BaiTap11()
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp; // tmp duoc su dung lam bien tam (bien trung gian)


            Console.Write("\nSap xep mang theo thu tu tang dan trong C#:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 12: Viết chương trình C# để nhập một mảng, sau đó sắp xếp mảng theo thứ tự giảm dần và in mảng đã sắp xếp trên màn hình.
        private static void BaiTap12()
        {
            int[] arr1 = new int[10];

            int n, i, j, tmp; //tmp la bien tam (bien trung gian)


            Console.Write("\nSap xep mang theo thu tu giam dan trong C#:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        //cach trao doi gia tri
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 13: Viết chương trình C# để nhập một mảng (đã sắp xếp theo thứ tự tăng dần), sau đó chèn thêm phần tử mới vào trong mảng rồi in mảng trên màn hình
        private static void BaiTap13()
        {
            int[] arr1 = new int[10];
            int i, n, p = 0, phan_tu_moi;
            Console.Write("\nChen phan tu vao mang trong C#:\n");
            Console.Write("--------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhap gia tri phan tu can chen: ");
            phan_tu_moi = Convert.ToInt32(Console.ReadLine());
            Console.Write("In mang truoc khi chen:\n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
            /* xac dinh vi tri de chen phan tu moi.*/
            for (i = 0; i < n; i++)
                if (phan_tu_moi < arr1[i])
                {
                    p = i;
                    break;
                }
            /* di chuyen vi tri tat ca phan tu ben canh phai cua mang */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            /* chen phan tu moi vao vi tri thich hop */
            arr1[p] = phan_tu_moi;

            Console.Write("\n\nSau khi chen, mang co cac phan tu:\n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n");

            Console.ReadKey();
        }
        //Bài 14: Viết chương trình C# để nhập một mảng (mảng này không có thứ tự), sau đó chèn thêm phần tử mới vào trong mảng rồi in mảng trên màn hình.
        private static void BaiTap14()
        {
            int[] arr1 = new int[10];
            int i, n, p, x;

            Console.Write("\nChen phan tu vao mang trong C#: \n");
            Console.Write("--------------------------------\n");
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Nhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri can chen phan tu moi nay: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("In mang ban dau:\n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
            /* di chuyen vi tri cac phan tu ben phai cua mang */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            /* chen gia tri vao vi tri da cho */
            arr1[p - 1] = x;


            Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 15: Viết chương trình C# để nhập một mảng sắp xếp theo thứ tự tăng dần, sau đó xóa phần tử tại vị trí nào đó rồi in mảng kết quả trên màn hình.
        private static void BaiTap15()
        {
            int i, pos, n; //pos la vi tri can xoa
            int[] arr1 = new int[50];


            Console.Write("\nXoa phan tu trong mang C#:\n");
            Console.Write("---------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());
            /* xac dinh vi tri cua i trong mang*/
            i = 0;
            while (i != pos - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 16: Viết chương trình C# để nhập một mảng, sau đó tìm phần tử lớn thứ hai rồi in kết quả trên màn hình.
        private static void BaiTap16()
        {
            int n, i, j = 0, lon_nhat, lon_thu_hai;
            int[] arr1 = new int[50];

            Console.Write("\nTim phan tu lon thu hai trong mang C#:\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* truoc het, chung ta tim vi tri cua phan tu lon nhat trong mang */
            lon_nhat = 0;

            for (i = 0; i < n; i++)
            {
                if (lon_nhat < arr1[i])
                {
                    lon_nhat = arr1[i];
                    j = i;
                }
            }
            /* bo qua phan tu lon nhat nay va tim phan tu lon thu hai */
            lon_thu_hai = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* bo qua phan tu lon nhat */
                    i--;
                }
                else
                {
                    if (lon_thu_hai < arr1[i])
                    {
                        lon_thu_hai = arr1[i];
                    }
                }
            }

            Console.Write("Phan tu lon thu hai trong mang la:  {0} \n\n", lon_thu_hai);

            Console.ReadKey();
        }
        //Bài 17: Viết chương trình C# để nhập một mảng, sau đó tìm phần tử nhỏ thứ hai rồi in kết quả trên màn hình.
        private static void BaiTap17()
        {
            int n, i, j = 0, nho_nhat, nho_thu_hai;
            int[] arr1 = new int[50];

            Console.Write("\nTim phan tu nho thu hai trong mang C#:\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang (nen nhap gia tri nho hon 99999):\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* tim vi tri cua phan tu nho nhat */
            nho_nhat = 0;
            for (i = 0; i < n; i++)
            {
                if (nho_nhat > arr1[i])
                {
                    nho_nhat = arr1[i];
                    j = i;
                }
            }

            /* bo qua phan tu nho nhat va tim phan tu nho thu hai */
            nho_thu_hai = 99999; //gan mot gia tri ban dau
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* bo qua phan tu nho nhat */
                    i--;
                }
                else
                {
                    if (nho_thu_hai > arr1[i])
                    {
                        nho_thu_hai = arr1[i];
                    }
                }
            }

            Console.Write("Phan tu nho thu hai trong mang la:  {0} \n\n", nho_thu_hai);       

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BaiTap4();
        }
    }
}
