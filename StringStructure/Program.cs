using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringStructure
{
    class Program
    {
        //Bài 1: Nhập một chuỗi từ bàn phím, rồi sau đó in chuỗi trên màn hình.
        private static void BaiTap1()
        {
            string str; /* Khai bao mot chuoi */
            Console.Write("\nNhap va in chuoi trong C#:\n");
            Console.Write("-----------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();
            Console.Write("Ban vua nhap chuoi: {0}\n", str);
            Console.ReadKey();

        }
        //Bài 2: Viết chương trình C# để tìm độ dài của một chuỗi mà không sử dụng hàm trong thư viện
        private static void BaiTap2()
        {
            string str; /* Khai bao mot chuoi */
            int l = 0;

            Console.Write("\nTim do dai chuoi trong C#:\n");
            Console.Write("---------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;
            }
            Console.Write("Do dai chuoi la: {0}\n\n", l);
            Console.ReadKey();

        }
        //Bài 3 : Chương trình C# để chia chuỗi thành các ký tự riêng lẻ
        private static void BaiTap3()
        {
            string str; /* Khai bao mot chuoi */
            int l = 0;

            Console.Write("\nChia chuoi thanh cac ky tu rieng le trong C#:\n");
            Console.Write("-----------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();
            Console.Write("In tung ky tu trong chuoi ban dau: ");
            while (l <= str.Length - 1)
            {
                Console.Write("{0} ", str[l]);
                l++;
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
        //Bài 4: Chương trình C# để in các ký tự riêng lẻ của chuỗi theo chiều đảo ngược
        private static void BaiTap4()
        {
            string str; /* Khai bao mot chuoi */
            int l = 0;

            Console.Write("\nIn cac ky tu rieng le cua chuoi theo chieu dao nguoc trong C#:\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.Write("In cac ky tu theo chieu dao nguoc: \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 5: Chương trình C# để đếm số từ có trong một chuỗi
        private static void BaiTap5()
        {
            string str; /* Khai bao mot chuoi */
            int bien_dem, l;

            Console.Write("\nDem so tu trong mot chuoi trong C#:\n");
            Console.Write("-------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            l = 0;
            bien_dem = 1;

            /* lap toi phan cuoi cua chuoi */
            while (l <= str.Length - 1)
            {
                /* kiem tra xem ky tu hien tai co phai la khoang trang 
                 * hay la ky tu new line hay ky tu tab */
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    bien_dem++;
                }

                l++;
            }

            Console.Write("Tong so tu co trong chuoi tren la: {0}\n", bien_dem);

            Console.ReadKey();
        }
        //Bài 6: Viết chương trình C# để so sánh hai chuỗi để xem hai chuỗi này có bằng nhau không
        private static void BaiTap6()
        {
            string str1, str2; //khai bao hai chuoi
            int flg = 0;
            int i = 0, l1, l2, yn = 0;

            Console.Write("\nSo sanh hai chuoi trong C#:\n");
            Console.Write("----------------------------------\n");
            Console.Write("Nhap chuoi thu nhat: ");
            str1 = Console.ReadLine();

            Console.Write("Nhap chuoi thu hai: ");
            str2 = Console.ReadLine();

            l1 = str1.Length;
            l2 = str2.Length;
            /*so sanh xem hai chuoi co do dai bang nhau khong*/
            if (l1 == l2)
            {
                for (i = 0; i < l1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        yn = 1;
                        i = l1;
                    }
                }
            }
            /*khoi tao bien flg khi hai chuoi co do dai la bang, ngan hon, hay dai hon*/
            if (l1 == l2)
                flg = 0;
            else if (l1 > l2)
                flg = 1;
            else if (l1 < l2)
                flg = -1;
            /*hien thi thong bao tuong ung khi hai chuoi co do dai la bang, ngan hon, hay dai hon*/
            if (flg == 0)
            {
                if (yn == 0)
                    Console.Write("\nHai chuoi co do dai bang nhau \nva hai chuoi cung giong nhau.\n\n");
                else
                    Console.Write("\nHai chuoi co do dai bang nhau \nnhung hai chuoi la khong giong nhau.\n\n");
            }
            else if (flg == -1)
            {
                Console.Write("\nChuoi thu nhat ngan hon chuoi thu hai.\n\n");
            }
            else
            {
                Console.Write("\nChuoi thu nhat dai hon chuoi thu hai.\n\n");
            }

            Console.ReadKey();
        }
        //Bài 7: Chương trình C# để đếm số chữ cái, số chữ số, số ký tự đặc biệt trong một chuỗi
        private static void BaiTap7()
        {
            string str; //khai bao chuoi
            int chu_cai, chu_so, ky_tu_dac_biet, i, l;
            chu_cai = chu_so = ky_tu_dac_biet = i = 0;

            Console.Write("\nDem so chu cai, so chu so, so ky tu dac biet cua chuoi trong C#:\n");
            Console.Write("--------------------------------------------------------------------\n");
            Console.Write("Nhap chuoi: ");
            str = Console.ReadLine();
            l = str.Length;

            /* kiem tra tung ky tu trong chuoi*/

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    chu_cai++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    chu_so++;
                }
                else
                {
                    ky_tu_dac_biet++;
                }

                i++;
            }
            Console.Write("So chu cai trong chuoi la: {0}\n", chu_cai);
            Console.Write("So chu so trong chuoi la: {0}\n", chu_so);
            Console.Write("So ky tu dac biet trong chuoi la: {0}\n\n", ky_tu_dac_biet);

            Console.ReadKey();
        }
        //Bài 8: Viết chương trình sao chép từ chuỗi này sang chuỗi khác trong C#
        private static void BaiTap8()
        {
            string str1; //khai bao mot chuoi
            int i, l;

            Console.Write("\nSao chep chuoi trong C#:\n");
            Console.Write("------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();

            l = str1.Length;
            string[] str2 = new string[l]; //khai bao mot chuoi khac

            /* sao chep tung ky tu tu chuoi str1 sang chuoi str2*/
            i = 0;
            while (i < l)
            {
                string tmp = str1[i].ToString();
                str2[i] = tmp;
                i++;
            }
            Console.Write("\nIn chuoi ban dau: {0}\n", str1);
            Console.Write("In chuoi sao: {0}\n", string.Join("", str2));
            Console.Write("So ky tu da duoc sao chep: {0}\n\n", i);

            Console.ReadKey();
        }
        //Bài 9: Chương trình C# để đếm số phụ âm, nguyên âm trong chuỗi
        private static void BaiTap9()
        {
            string str; //khai bao mot chuoi
            int i, len, nguyen_am, phu_am;

            Console.Write("\nDem so nguyen am, phu am trong chuoi C#:\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            nguyen_am = 0;
            phu_am = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {
                    nguyen_am++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    phu_am++;
                }
            }
            Console.Write("\nSo nguyen am co trong chuoi la: {0}\n", nguyen_am);
            Console.Write("So phu am co trong chuoi la: {0}\n\n", phu_am);

            Console.ReadKey();
        }
        //Bài 10: Tìm ký tự xuất hiện nhiều nhất trong chuỗi C#
        private static void BaiTap10()
        {
            string str; //khai bao mot chuoi
            int[] tan_suat = new int[255];
            int i = 0, max, l;
            int ascii;

            Console.Write("\nTim ky tu xuat hien nhieu nhat trong chuoi C#:\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();
            l = str.Length;

            for (i = 0; i < 255; i++)  //thiet lap tan suat xuat hien cua tat ca ky tu ve 0  
            {
                tan_suat[i] = 0;
            }
            /* Doc tan suat cua moi ky tu */
            i = 0;
            while (i < l)
            {
                ascii = (int)str[i];
                tan_suat[ascii] += 1;

                i++;
            }

            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (tan_suat[i] > tan_suat[max])
                        max = i;
                }
            }
            Console.Write("Ky tu xuat hien nhieu nhat '{0}' va xuat hien {1} lan.\n\n", (char)max, tan_suat[max]);

            Console.ReadKey();
        }
        //Bài 11: Chương trình C# để sắp xếp mảng các ký tự trong chuỗi theo thứ tự tăng dần sắp xếp các chuỗi trong C#
        private static void BaiTap11()
        {
            string str; //khai bao mot chuoi
            char[] arr1;
            char ch;
            int i, j, l;
            Console.Write("\nSap xep mang ky tu cua chuoi theo thu tu tang dan trong C#:\n");
            Console.Write("------------------------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();
            l = str.Length;
            arr1 = str.ToCharArray(0, l);

            for (i = 1; i < l; i++)
            {
                for (j = 0; j < l - i; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
                }
            }    

            Console.Write("Sau khi sap xep, chuoi co dang: \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine("\n");

            Console.ReadKey();
        }
        //Bài 12: Viết chương trình C# để nhập 3 chuỗi từ bàn phím, sắp xếp các chuỗi rồi in kết quả trên màn hình
        private static void BaiTap12()
        {
            string[] arr1;
            string temp;
            int n, i, j, l;

            Console.Write("\nSap xep chuoi trong C# - su dung Bubble Sort:\n");
            Console.Write("-----------------------------------------------------\n");
            Console.Write("Nhap so chuoi can sap xep: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Nhap {0} chuoi tu ban phim:\n", n);
            for (i = 0; i < n; i++)
            {
                arr1[i] = Console.ReadLine();
            }
            l = arr1.Length;

            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l - 1; j++)
                {
                    if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                    {
                        //cach thuc trao doi gia tri
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            Console.Write("\nIn thu tu cac chuoi sau khi da sap xep: \n");
            for (i = 0; i < l; i++)
            {
                Console.WriteLine(arr1[i] + " ");
            }

            Console.ReadKey();
        }
        //Bài 13: Chương trình C# để lấy chuỗi con từ một chuỗi đã cho
        private static void BaiTap13()
        {
            string str; //khai bao mot chuoi
            char[] arr1;
            int pos, l, ln, c = 0;

            Console.Write("\nLay chuoi con trong C#:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();
            ln = str.Length;
            arr1 = str.ToCharArray(0, ln);

            Console.Write("Nhap vi tri bat dau de lay chuoi con: ");
            pos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap do dai cua chuoi con: ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Chuoi con thu duoc tu chuoi ban dau la: ");
            while (c < l)
            {
                Console.Write(arr1[pos + c - 1]);
                c++;
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 14: Kiểm tra chuỗi con trong C#
        private static void BaiTap14()
        {
            string str1, str2; //Khai bao hai chuoi
            bool m;

            Console.Write("\nKiem tra chuoi con trong C#:\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();

            Console.Write("Nhap chuoi con de kiem tra: ");
            str2 = Console.ReadLine();
            m = str1.Contains(str2); // ham nay tra ve gia tri boolean  
            if (m) // kiem tra true, false 
                Console.Write("Chuoi con co mat trong chuoi ban dau.\n\n");
            else
                Console.Write("Chuoi con khong co mat trong chuoi ban dau. \n\n");

            Console.ReadKey();
        }
        //Bài 15: Chương trình C# để chuyển chữ hoa thành chữ thường và ngược lại
        private static void BaiTap15()
        {
            string str1; //Khai bao hai chuoi
            char[] arr1;
            int l, i;
            l = 0;
            char ch;
            Console.Write("\nChuyen chu hoa thanh chu thuong va nguoc lai trong C#:\n");
            Console.Write("--------------------------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l); // chuyen chuoi thanh mang ky tu.  

            Console.Write("\nSau khi chuyen doi, chuoi co dang: ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // kiem tra ky tu thuong  
                    Console.Write(Char.ToUpper(ch)); // chuyen doi chu thuong thanh chu hoa.  
                else
                    Console.Write(Char.ToLower(ch)); // chuyen doi chu hoa thanh chu thuong.  
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
        //Bài 16: Kiểm tra username và password trong C#
        private static void BaiTap16()
        {
            string username, password; //khai bao hai chuoi
            int ctr = 0;
            Console.Write("\nKiem tra username va password trong C#:\n");
            Console.Write("Mac dinh username va password la: vietjack va 1234\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Nhap username: ");
                username = Console.ReadLine();

                Console.Write("Nhap password: ");
                password = Console.ReadLine();

                if (username != "csharpbasic" || password != "1234")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "vietjack" || password != "1234") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nBan da nhap sai username va password qua 3 lan. Xin hay thu lai!\n\n");
            else
                Console.Write("\nBan da nhap mat khau dung!\n\n");

            Console.ReadKey();
        }
        //Bài 17: Chương trình C# để tìm kiếm vị trí chuỗi con trong chuỗi đã cho và in kết quả ra màn hình
        private static void BaiTap17()
        {
            string str1; //khai bao chuoi
            string chuoi_con; //khai bao chuoi con can tim kiem
            Console.Write("\nTim vi tri chuoi con trong C#:\n");
            Console.Write("---------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();

            Console.Write("Nhap chuoi con can tim kiem: ");
            chuoi_con = Console.ReadLine();
            int vi_tri = str1.IndexOf(chuoi_con);
            if (vi_tri < 0)
                Console.WriteLine("Khong tim thay chuoi con trong chuoi da cho!\n");
            else
                Console.WriteLine("Tim thay chuoi con '{0}' trong chuoi '{1}' tai vi tri {2}",
                                  chuoi_con, str1, vi_tri);

            Console.ReadKey();
        }
        //Bài 18: Viết chương trình C# để kiểm tra xem ký tự vừa nhập có phải là chữ cái không, sau đó kiểm tra xem đó là chữ hoa hay chữ thường rồi in thông báo tương ứng trên màn hình.
        private static void BaiTap18()
        {
            Console.Write("\nKiem tra co phai la chu cai, sau do kiem tra chu hoa chu thuong trong C#\n");
            Console.Write("------------------------------------------------------------------------\n");
            Console.Write("Nhap mot ky tu: ");
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nKy tu vua nhap la chu hoa.\n");
                }
                else
                {
                    Console.WriteLine("\nKy tu vua nhap la chu thuong.\n");
                }
            }
            else
            {
                Console.WriteLine("\nKy tu vua nhap khong phai la chu cai.\n");
            }

            Console.ReadKey();
        }
        //Bài 19: Chương trình C# để đếm số lần xuất hiện của chuỗi con trong một chuỗi
        private static void BaiTap19()
        {
            string str1; //khai bao chuoi ban dau
            string chuoi_con; //khai bao chuoi con can tim
            int strt = 0;
            int cnt = -1;
            int idx = -1;

            Console.Write("\nDem so lan xuat hien cua chuoi con trong C#:\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap chuoi ban dau: ");
            str1 = Console.ReadLine();
            Console.Write("Nhap chuoi con can tim: ");
            chuoi_con = Console.ReadLine();


            while (strt != -1)
            {
                strt = str1.IndexOf(chuoi_con, idx + 1);
                cnt += 1;
                idx = strt;
            }
            Console.Write("Chuoi con '{0}' xuat hien " + cnt + " lan.\n", chuoi_con);
            Console.ReadKey();
        }
        //Bài 20: Viết chương trình C# để chèn chuỗi con trước vị trí xuất hiện lần đầu của chuỗi con khác trong một chuỗi ban đầu
        private static void BaiTap20()
        {
            string str1; //khai bao chuoi ban dau
            string chuoi_vi_tri; //khai bao chuoi can tim
            string chuoi_de_chen; //khai bao chuoi de chen
            int i;
            Console.Write("\nChuong trinh C# de chen chuoi con truoc vi tri xuat hien lan dau \ncua chuoi con khac trong mot chuoi ban dau:\n");
            Console.Write("--------------------------------------------------------------\n");

            Console.Write("Nhap chuoi ban dau: ");
            str1 = Console.ReadLine();
            Console.Write("Nhap chuoi de tim kiem vi tri: ");
            chuoi_vi_tri = Console.ReadLine();
            Console.Write("Nhap chuoi de chen: ");
            chuoi_de_chen = Console.ReadLine();
            i = str1.IndexOf(chuoi_vi_tri);  // xac dinh vi tri xuat hien dau tien cua chuoi_vi_tri  
            chuoi_de_chen = " " + chuoi_de_chen.Trim() + " "; //them khoang trang
            str1 = str1.Insert(i, chuoi_de_chen);
            Console.Write("Chuoi ket qua: {0}\n\n", str1);

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BaiTap11();

        }
    }
}
