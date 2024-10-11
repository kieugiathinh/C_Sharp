using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT12_40SGK
{
    internal class Program
    {
        //Hàm tính tổng từ 1 đến n
        static void Tong1_N(int n)
        {
            //Sử dụng công thức 
            int Tong = n * (n + 1) / 2;

            //Sử dụng vòng lặp for
            //for(int i = 1; i <= n; i++)
            //Tong += i;
            Console.WriteLine("Vậy tổng các số từ 1 đến {0} là: {1}", n, Tong);
        }
        
        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.Write("Nhập vào số nguyên dương N = ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Vui lòng nhập N là số nguyên dương (N>0)!");
            } while (n <= 0);

            Tong1_N(n);
            Console.ReadKey();
        }
    }
}
