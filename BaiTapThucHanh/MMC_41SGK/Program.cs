using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMC_41SGK
{
    internal class Program
    {
        //Nhập mảng
        static void NhapMang(int n, int[] a)
        {
            Console.WriteLine("Nhập mảng: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        //Xuất mảng
        static void XuatMang(int n, int[] a)
        {
            Console.Write("Mảng vừa nhập là:");
            for (int i = 0; i < n; i++)
                Console.Write(" {0}", a[i]);
        }

        //16_Tìm phần tử nhỏ nhất và lớn nhất trong mảng
        static void PTNN_LN(int n, int[] a)
        {
            for (int i = 0; i < n; i++)
                Array.Sort(a); //Sắp xếp mảng từ bé đến lớn: a[0] bé nhất, a[n-1] lớn nhất

            //Console.Write("\n\nMảng vừa sắp xếp là:");
            //for (int i = 0; i < n; i++)
            //    Console.Write(" {0}", a[i]);

            Console.WriteLine("\n\nPhần tử bé nhất trong MMC là: {0}", a[0]);
            Console.WriteLine("Phần tử lớn nhất trong MMC là: {0}", a[n-1]);
        }

        //17_Kiểm tra trong mảng vừa nhập có số dương hay không
        static void KT_PTDuong(int n, int[] a)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (a[i] > 0)
                    count++;

            if (count > 0)
                Console.WriteLine("Mảng vừa nhập có số dương!");
            else
                Console.WriteLine("Mảng vừa nhập không có số dương");
        }

        //18_Tính tổng các phần tử dương trong mảng
        static void Tong_SoDuong(int n, int[] a)
        {
            int Tong = 0;
            for (int i = 0; i < n; i++)
                if (a[i] > 0)
                    Tong += a[i];

            Console.WriteLine("Tổng các phần tử dương trong mảng là: {0}", Tong);       
        }

        //19_Đếm số phần tử dương, phần tử âm, phần tử 0 trong mảng
        static void Dem_DuongAm0(int n, int[] a)
        {
            int countduong = 0, countam = 0, count0 = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                    countduong++;
                if(a[i] == 0)
                    count0++;
                if(a[i] < 0)
                    countam++;
            }    

            Console.WriteLine("Số phần tử dương trong mảng là: {0}", countduong);
            Console.WriteLine("Số phần tử 0 trong mảng là: {0}", count0);
            Console.WriteLine("Số phần tử âm trong mảng là: {0}", countam);
        }

        //20_Tính tổng các phần tử âm trong mảng
        static void Tong_SoAm(int n, int[] a)
        {
            int Tong = 0;
            for (int i = 0; i < n; i++)
                if (a[i] < 0)
                    Tong += a[i];

            Console.WriteLine("Tổng các phần tử âm trong mảng là: {0}", Tong);
        }

        //21_Tính tổng các phần tử chẵn trong mảng
        static void Tong_SoChan(int n, int[] a)
        {
            int Tong = 0;
            for (int i = 0; i < n; i++)
                if (a[i] %2 == 0)
                    Tong += a[i];

            Console.WriteLine("Tổng các phần tử chẵn trong mảng là: {0}", Tong);
        }

        //22_Kiểm tra trong mảng có phần tử âm hay không
        static void KT_PTAm(int n, int[] a)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (a[i] < 0)
                    count++;

            if (count > 0)
                Console.WriteLine("Mảng vừa nhập có số âm!");
            else
                Console.WriteLine("Mảng vừa nhập không có số âm");
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.Write("Nhập vào số phần tử trong MMC: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Vui lòng nhập số phần tử trong MMC là số dương!");
            }while (n <= 0);

            //Khai báo mảng
            int[] a = new int[n];

            NhapMang(n, a);
            XuatMang(n, a);
            PTNN_LN(n, a); //Câu 16
            KT_PTDuong(n, a); //Câu 17
            Tong_SoDuong(n, a); //Câu 18
            Dem_DuongAm0(n, a); //Câu 19
            Tong_SoAm(n, a); //Câu 20
            Tong_SoChan(n, a); //Câu 21 
            KT_PTAm(n, a); //Câu 22

            Console.ReadKey();
        }
    }
}
