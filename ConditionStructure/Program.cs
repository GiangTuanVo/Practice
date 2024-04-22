using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionStructure
{
    class Program
    {
        //Bài 1: Nhập hai số và kiểm tra hai số có bằng nhau không
        private static void BaiTap1()
        {
            int int1, int2;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# kiem tra hai so co bang nhau khong:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap so thu nhat: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} va {1} la bang nhau.\n", int1, int2);
            else
                Console.WriteLine("{0} va {1} la khong bang nhau.\n", int1, int2);

            Console.ReadKey();
        }
        //Bài 2: Nhập một số bất kỳ từ bàn phím và kiểm tra xem đó là số chẵn hay số lẻ và in ra thông báo tương ứng
        private static void BaiTap2()
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Kiem tra chan le trong C#:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} la so chan.\n", num1);
            else
                Console.WriteLine("{0} la so le.\n", num1);

            Console.ReadKey();
        }
        //Bài 3: Nhập một số, kiểm tra xem số đó là số âm hay số dương và in ra thông báo tương ứng
        private static void BaiTap3()
        {
            int num;
            Console.Write("\n\n");
            Console.Write("Kiem tra am duong trong C#:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so nguyen bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)

                Console.WriteLine("{0} la so duong.\n", num);
            else
                Console.WriteLine("{0} la so am. \n", num);

            Console.ReadKey();
        }
        //Bài 4: Nhập một số, kiểm tra xem năm đó có phải là năm nhuận hay không  và in ra thông báo tương ứng
        private static void BaiTap4()
        {
            int chk_year;
            Console.Write("\n\n");
            Console.Write("Kiem tra nam nhuan trong C#:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot nam bat ky de kiem tra: ");
            chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} la nam nhuan.\n", chk_year);
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} khong phai la nam nhuan.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} la nam nhuan.\n", chk_year);
            else
                Console.WriteLine("{0} khong phai la nam nhuan.\n", chk_year);

            Console.ReadKey();
        }
        //Bài 5: Nhập tuổi của một người, kiểm tra xem người đó có đủ tuổi bầu cử không, và sau đó in thông báo tương ứng. (Độ tuổi bầu cử là >= 18)
        private static void BaiTap5()
        {
            int tuoi_bau_cu;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# de kiem tra tuoi bau cu:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap tuoi cua cu tri bat ky: ");
            tuoi_bau_cu = Convert.ToInt32(Console.ReadLine());
            if (tuoi_bau_cu < 18)
            {
                Console.Write("Xin loi!!! Ban chua du tuoi de tham gia bau cu.\n");
                Console.Write("Ban co the tham gia bau cu sau {0} nam nua.\n\n", 18 - tuoi_bau_cu);
            }
            else
                Console.Write("Chuc mung!!! Ban du tuoi de lam cu tri.\n\n");

            Console.ReadKey();
        }
        //Bài 6: Nhập một số m, kiểm tra xem số đó là lớn hơn, nhỏ hơn hoặc bằng 0 và in ra giá trị tương ứng của một số n là 1, -1 hoặc 0
        private static void BaiTap()
        {
            int m, n;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# de hien thi gia tri cua n\ntuong ung voi moi gia tri cua m:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap gia tri cua m: ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m != 0)
                if (m > 0)
                    n = 1;
                else
                    n = -1;
            else
                n = 0;
            Console.Write("Gia tri cua m = {0} \n", m);
            Console.Write("Gia tri tuong ung cua n = {0} \n\n", n);

            Console.ReadKey();
        }
        //Bài 7: Nhập chiều cao của một người, kiểm tra và phân loại chiều cao của người đó: lùn, cao trung bình, cao, cao bất thường
        private static void BaiTap7()
        {
            float chieu_cao;
            Console.Write("\n");
            Console.Write("Chuong trinh C# de kiem tra va phan loai chieu cao:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap chieu cao cua mot nguoi (don vi cm): ");
            chieu_cao = Convert.ToInt32(Console.ReadLine());

            if (chieu_cao < 150.0)
                Console.Write("Phan loai: nguoi lun \n\n");
            else if ((chieu_cao >= 150.0) && (chieu_cao <= 165.0))
                Console.Write("Phan loai: do cao trung binh \n\n");
            else if ((chieu_cao >= 165.0) && (chieu_cao <= 195.0))
                Console.Write("Phan loai: cao \n\n");
            else
                Console.Write("Phan loai: chieu cao bat thuong\n\n");

            Console.ReadKey();
        }
        //Bài 8: Tìm số lớn nhất trong 3 số đã nhập từ bàn phím.
        private static void BaiTap8()
        {
            int num1, num2, num3;
            Console.Write("\n");
            Console.Write("Chuong trinh C# de tim so lon nhat trong 3 so:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so thu nhat: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("So thu nhat la so lon nhat trong ba so. \n\n");
                }
                else
                {
                    Console.Write("So thu ba la so lon nhat trong ba so. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("So thu hai la so lon nhat trong ba so.\n\n");
            else
                Console.Write("So thu ba la so lon nhat trong ba so. \n\n");

            Console.ReadKey();
        }
        //Bài 9 : Nhập tọa độ (x, y) của một điểm và thông báo điểm đó ở góc phần tư nào trong Hệ tọa độ
        private static void BaiTap9()
        {
            int x, y;

            Console.Write("\n\n");
            Console.Write("Chuong trinh C# tim goc phan tu tuong ung voi toa do da cho:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap hoanh do: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap tung do: ");
            y = Convert.ToInt32(Console.ReadLine());


            if (x > 0 && y > 0)
                Console.Write("Diem co toa do ({0} {1}) nam tren goc phan tu thu I.\n\n", x, y);
            else if (x < 0 && y > 0)
                Console.Write("Diem co toa do ({0} {1}) nam tren goc phan tu thu II.\n\n", x, y);
            else if (x < 0 && y < 0)
                Console.Write("Diem co toa do ({0} {1}) nam tren goc phan tu thu III.\n\n", x, y);
            else if (x > 0 && y < 0)
                Console.Write("Diem co toa do ({0} {1}) nam tren goc phan tu thu IV.\n\n", x, y);
            else if (x == 0 && y == 0)
                Console.Write("Diem co toa do ({0} {1}) la tam cua He toa do.\n\n", x, y);

            Console.ReadKey();
        }
        //Bài 10: Nhập điểm thi ba môn Toán, Lý, Hóa của một thí sinh, kiểm tra theo tiêu chí đã cho, sau đó thông báo thí sinh có trúng tuyển hay không.
        private static void BaiTap10()
        {
            float p, c, m;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de xet tuyen Dai hoc:\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Tieu chi xet tuyen:\n");
            Console.Write("Diem Toan >= 6.5\n");
            Console.Write("va diem Ly >= 5.5\n");
            Console.Write("va diem Hoa >= 5.0\n");
            Console.Write("va tong diem ba mon >= 18.0\n");
            Console.Write("hoac tong diem Toan va Ly >= 14.0\n");
            Console.Write("-------------------------------------\n");


            Console.Write("Nhap diem Ly: ");
            p = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem Hoa: ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap diem Toan: ");
            m = Convert.ToSingle(Console.ReadLine());
            Console.Write("Tong diem ba mon: {0}\n", m + p + c);
            Console.Write("Tong diem Toan va Ly: {0}\n", m + p);

            if (m >= 6.5)
                if (p >= 5.5)
                    if (c >= 5.0)
                        if ((m + p + c) >= 18.0 || (m + p) >= 14.0)
                            Console.Write("Chuc mung ban da trung tuyen.\n");
                        else
                            Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");
                    else
                        Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");
                else
                    Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");
            else
                Console.Write("Rat tiec vi ban da khong trung tuyen.\n\n");

            Console.ReadKey();
        }
        //Bài 11: Giải phương trình bậc hai
        private static void BaiTap11()
        {
            int a, b, c;

            double d, x1, x2;
            Console.Write("\n");
            Console.Write("Giai phuong trinh bac hai trong C#:\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap gia tri cua a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua c: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Phuong trinh co mot nghiem duy nhat.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Nghiem duy nhat cua phuong trinh la = {0}\n", x1);
            }
            else if (d > 0)
            {
                Console.Write("Phuong trinh co hai nghiem thuc phan biet\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("Nghiem thu nhat: x1 = {0}\n", x1);
                Console.Write("Nghiem thu nhat: x2 = {0}\n", x2);
            }
            else
                Console.Write("Phuong trinh vo nghiem (hay khong co nghiem thuc nao)\n\n");

            Console.ReadKey();

        }
        //Bài 12: Nhập một nhiệt độ và in thông báo tương ứng
        private static void BaiTap12()
        {
            int tmp;
            Console.Write("\n\n");
            Console.Write("Chuong trinh C# hien thi thong bao tuong ung voi nhiet do vua nhap:\n");
            Console.Write("------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap nhiet do ngoai troi: ");
            tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp < 0)
                Console.Write("Thoi tiet gia ret.\n");
            else if (tmp < 10)
                Console.Write("Thoi tiet rat lanh.\n");
            else if (tmp < 20)
                Console.Write("Thoi tiet lanh.\n");
            else if (tmp < 30)
                Console.Write("Thoi tiet binh thuong.\n");
            else if (tmp < 40)
                Console.Write("Thoi tiet nong.\n");
            else
                Console.Write("Thoi tiet rat nong.\n");

            Console.ReadKey();
        }
        //Bài 13: Nhập ba cạnh của một tam giác và kiểm tra xem tam giác đó là tam giác đều, tam giác cân hay tam giác lệch
        private static void BaiTap13()
        {
            int canha, canhb, canhc;
            Console.Write("\n");
            Console.Write("Kiem tra tam giac deu, can, lech trong C#:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap canh a: ");
            canha = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh b: ");
            canhb = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap canh c: ");
            canhc = Convert.ToInt32(Console.ReadLine());

            if (canha == canhb && canhb == canhc)
            {
                Console.Write("Day la tam giac deu.\n");
            }
            else if (canha == canhb || canha == canhc || canhb == canhc)
            {
                Console.Write("Day la tam giac can.\n");
            }
            else
            {
                Console.Write("Day la tam giac lech.\n");
            }

            Console.ReadKey();
        }
        //Bài 14: Nhập 3 số dương bất kỳ và sau đó kiểm tra xem 3 số này có phải là 3 góc của tam giác không
        private static void BaiTap14()
        {
            int goca, gocb, gocc, sum; //khai bao ba goc    
            Console.Write("\n");
            Console.Write("Kiem tra tam giac trong C#:\n");
            Console.Write("--------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so do goc a: ");
            goca = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so do goc b: ");
            gocb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so do goc c: ");
            gocc = Convert.ToInt32(Console.ReadLine());

            /* Tinh tong ba goc nay */
            sum = goca + gocb + gocc;

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (sum == 180)
            {
                Console.Write("Day la ba goc cua tam giac.\n");
            }
            else
            {
                Console.Write("Day khong phai la ba goc cua tam giac.\n");
            }

            Console.ReadKey();
        }
        //Bài 15: Nhập một chữ cái và kiểm tra xem đó là nguyên âm hay phụ âm
        private static void BaiTap15()
        {
            char ch;
            Console.Write("\n");
            Console.Write("Kiem tra nguyen am, phu am trong C#:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot chu cai: ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'i':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'o':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'u':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                case 'e':
                    Console.WriteLine("Chu cai vua nhap la nguyen am.");
                    break;
                default:
                    Console.WriteLine("Chu cai vua nhap khong phai la nguyen am.");
                    break;
            }

            Console.ReadKey();
        }
        //Bài 16: Nhập chi phí và doanh thu từ đó kết luận là lợi nhuận hay thua lỗ và với bao nhiêu
        private static void BaiTap16()
        {
            int chi_phi, doanh_thu, loi_nhuan;

            Console.Write("\n\n");
            Console.Write("Kiem tra loi nhuan hoac thua lo trong C#:\n");
            Console.Write("-----------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap chi phi: ");
            chi_phi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia ban: ");
            doanh_thu = Convert.ToInt32(Console.ReadLine());

            if (doanh_thu > chi_phi)
            {
                loi_nhuan = doanh_thu - chi_phi;
                Console.Write("\nBan thu duoc loi nhuan: {0}\n", loi_nhuan);
            }
            else if (chi_phi > doanh_thu)
            {
                loi_nhuan = chi_phi - doanh_thu;
                Console.Write("\nBan thua lo: {0}\n", loi_nhuan);
            }
            else
            {
                Console.Write("\nBan khong thu duoc loi nhuan nhung cung khong thua lo.\n");
            }

            Console.ReadKey();
        }
        //Bài 17 : Nhập hạng học lực (ví dụ: A, B, C, ...) của một sinh viên và từ đó hiển thị thông báo tương ứng với
        //E: Xuất sắc, V: Rất giỏi, G: Giỏi, A: Trung bình, F: Trượt
        private static void BaiTap17()
        {
            string notes;
            char grd;
            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap hang hoc luc va in thong bao tuong ung\n");
            Console.Write("--------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap hang hoc luc: ");
            grd = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grd)
            {
                case 'E':
                    notes = "  Xuat sac";
                    break;
                case 'V':
                    notes = "  Rat gioi";
                    break;
                case 'G':
                    notes = "  Gioi ";
                    break;
                case 'A':
                    notes = "  Trung binh";
                    break;
                case 'F':
                    notes = "  Truot";
                    break;
                default:
                    notes = "Ban da nhap hang hoc luc khong dung. Xin thu lai!!!";
                    break;
            }
            Console.Write("Hoc luc cua ban la: {0}\n", notes);

            Console.ReadKey();
        }
        //Bài 18: Nhập một số và hiển thị ngày trong tuần tương ứng
        private static void BaiTap18()
        {
            int dayno;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap mot so va hien thi ngay trong tuan tuong ung:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so bat ky (1-7): ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:
                    Console.Write("Thu hai \n");
                    break;
                case 2:
                    Console.Write("Thu ba \n");
                    break;
                case 3:
                    Console.Write("Thu tu \n");
                    break;
                case 4:
                    Console.Write("Thu nam \n");
                    break;
                case 5:
                    Console.Write("Thu sau \n");
                    break;
                case 6:
                    Console.Write("Thu bay \n");
                    break;
                case 7:
                    Console.Write("Chu nhat \n");
                    break;
                default:
                    Console.Write("Ban da nhap so khong hop le. Xin ban nhap lai!!!\n");
                    break;
            }

            Console.ReadKey();
        }
        //Bài 19: Nhập số và hiển thị số bằng chữ tương ứng
        private static void BaiTap19()
        {
            int cdigit;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap so va hien thi so bang chu tuong ung:\n");
            Console.Write("-------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky (0-9): ");
            cdigit = Convert.ToInt32(Console.ReadLine());

            switch (cdigit)
            {
                case 0:
                    Console.Write("So khong\n");
                    break;

                case 1:
                    Console.Write("So mot\n");
                    break;
                case 2:
                    Console.Write("So hai\n");
                    break;
                case 3:
                    Console.Write("So ba\n");
                    break;
                case 4:
                    Console.Write("So bon\n");
                    break;
                case 5:
                    Console.Write("So nam\n");
                    break;
                case 6:
                    Console.Write("So sau\n");
                    break;
                case 7:
                    Console.Write("So bay\n");
                    break;
                case 8:
                    Console.Write("So tam\n");
                    break;
                case 9:
                    Console.Write("So chin\n");
                    break;
                default:
                    Console.Write("Ban da nhap so khong hop le. Xin nhap lai!!!\n");
                    break;
            }

            Console.ReadKey();
        }
        //Bài 20: Nhập một tháng bất kỳ trong năm và sau đó hiển thị số ngày trong tháng đó.
        private static void BaiTap20()
        {
            int monno;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de nhap thang va hien thi so ngay tuong ung:\n");
            Console.Write("--------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap thang trong nam: ");
            monno = Convert.ToInt32(Console.ReadLine());
            switch (monno)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Thang co 31 ngay. \n");
                    break;
                case 2:
                    Console.Write("Thang Hai co 28 ngay. \n");
                    Console.Write("Trong nam nhuan: thang Hai co 29 ngay.\n");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("Thang co 30 ngay. \n");
                    break;
                default:
                    Console.Write("Du lieu khong hop le. Xin ban thu lai!!!\n");
                    break;
            }

            Console.ReadKey();
        }
        //Bài 21: Chương trình hiển thị một menu có các lựa chọn để tính diện tích các hình tròn, hình chữ nhật, hình tam giác tương ứng với dữ liệu đã nhập
        private static void BaiTap21()
        {
            int lua_chon, r, l, w, b, h;
            double dien_tich = 0;

            Console.Write("\n");
            Console.Write("Chuong trinh C# duoi dang mot menu co cac lua chon de tinh dien tich:\n");
            Console.Write("--------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Lua chon 1: tinh dien tich hinh tron\n");
            Console.Write("Lua chon 2: tinh dien tich hinh chu nhat\n");
            Console.Write("Lua chon 3: tinh dien tich hinh tam giac\n");
            Console.Write("Nhap lua chon cua ban: ");
            lua_chon = Convert.ToInt32(Console.ReadLine());

            switch (lua_chon)
            {
                case 1:
                    Console.Write("Nhap ban kinh hinh trong: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("Nhap chieu dai HCN: ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu rong HCN: ");
                    w = Convert.ToInt32(Console.ReadLine());
                    dien_tich = l * w;
                    break;
                case 3:
                    Console.Write("Nhap canh huyen tam giac:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu cao tam giac:");
                    h = Convert.ToInt32(Console.ReadLine());
                    dien_tich = 0.5 * b * h;
                    break;
            }
            Console.Write("Dien tich hinh la: {0}\n", dien_tich);

            Console.ReadKey();
        }
        //Bài 22 : Chương trình C# hiển thị menu có các lựa chọn để thực hiện các phép toán cơ bản (+, -. *, /) hai
        private static void BaiTap22()
        {
            int num1, num2, opt;

            Console.Write("\n");
            Console.Write("Chuong trinh C# de hien thi menu co cac lua chon\nde thuc hien cac phep toan co ban:\n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so nguyen thu nhat: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDuoi day la cac lua chon:\n");
            Console.Write("1 - Phep cong.\n2 - Phep tru.\n3 - Phep nhan.\n4 - Phep chia.\n5 - Thoat.\n");
            Console.Write("\nNhap lua chon cua ban: ");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Write("Tong hai so {0} va {1} la: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("Hieu cua {0} va {1} la: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("Tich cua {0} va {1} la: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("Neu so thu hai = 0 --> Khong thuc hien duoc phep chia cho so 0.\n");
                    }
                    else
                    {
                        Console.Write("Thuong cua {0} va {1} la: {2}\n", num1, num2, num1 / num2);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Nhap tuy chon hop le\n");
                    break;
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BaiTap22();
        }
    }
}
