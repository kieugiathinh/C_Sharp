using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT15_41SGK
{
    internal class Program
    {
        //Hàm tính tổng dãy số
        static void TongDaySo(int n)
        {
            double Tong = 0;

            for (int i = 1; i <= n; i++)
            {
                Tong += Math.Pow(i, i);
            }
            Console.WriteLine("Tổng dãy số là: {0}", Tong);    
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

            TongDaySo(n);
            Console.ReadKey();
        }
    }
}
