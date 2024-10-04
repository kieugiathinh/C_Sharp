using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2Chieu
{
    internal class Program
    {
        //Hàm nhập 
        static void NhapMang(int m, int n, int[,] a)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}][{1}] = ", i, j);
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //Hàm xuất
        static void XuatMang(int m, int n, int[,] a)
        {
            Console.WriteLine("Mảng 2 chiều vừa nhập là: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0}", a[i, j]);
                }    
                Console.WriteLine();
            }        
        }

        //Tổng các phần tử trong mảng 2 chiều
        static void Tong(int m, int n, int[,] a)
        {
            int Sum = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    Sum += a[i, j];

            Console.WriteLine("Tổng các phần tử trong mảng 2 chiều là: {0}", Sum);
        }

        //Tìm max, min trong mảng 2 chiều
        static void Max_Min(int m, int n, int[,] a)
        {
            int max = a[0, 0];
            int min = a[0, 0];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(max < a[i, j])
                        max = a[i, j];
                    if(min > a[i, j])
                        min = a[i, j];
                }
            }
            Console.WriteLine("Phần tử lớn nhất trong mảng là: {0}", max);
            Console.WriteLine("Phần tử nhỏ nhất trong mảng là: {0}", min);
        }

        //Tính tổng các phần tử trên đường chéo chính
        static void Tong_DCC(int m, int n, int[,] a)
        {
            int Sum = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (i == j)
                        Sum += a[i, j];
            Console.WriteLine("Tổng các phần tử trên đường chéo chính là: {0}", Sum);
        }

        //Đếm số lượng phần tử chẵn trong mảng 2 chiều
        static void Dem_PTChan(int m, int n, int[,] a)
        {
            int count = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, j] %2 == 0)
                        count++;
            Console.WriteLine("Số phần tử chẳn trong mảng là: {0}", count);
        }

        //Sắp xếp mảng 2 chiều theo thứ tự tăng dần
        static void SapXep(int m, int n, int[,] a)
        {
            //Muốn sử dụng hàm Sort thì phải chuyển tử mảng 2 chiều về mảng 1 chiều
            //Rồi sử dụng hàm Sort
        }

        //Tổng các phần tử trên đường chéo phụ
        static void Tong_DCP(int m, int n, int[,] a)
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
                Sum += a[i, n - i - 1];
            Console.WriteLine("Tổng các phần tử trên đường chéo phụ là: {0}", Sum);
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int m, n;
            do
            {
                Console.Write("Nhập vào số dòng của mảng: ");
                m = int.Parse(Console.ReadLine());

                if (m <= 0)
                    Console.WriteLine("Vui lòng nhập số dòng của M2C là 1 số dương!");
            } while (m <= 0);
            
            do
            {
                Console.Write("Nhập vào số cột của mảng: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Vui lòng nhập số cột của M2C là 1 số dương!");
            } while (n <= 0);

            //Khai báo M2C
            int[,] a = new int[m, n];

            NhapMang(m, n, a);
            XuatMang(m, n, a);
            Tong(m, n, a);
            Max_Min(m, n, a);
            Tong_DCC(m, n, a);
            Dem_PTChan(m, n, a);   
            SapXep(m, n, a);
            Tong_DCP(m, n, a);
            
            Console.ReadKey();
        }
    }
}
