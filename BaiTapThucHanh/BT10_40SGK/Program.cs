using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10_40SGK
{
    internal class Program
    {
        //Hàm tìm ước
        static void TatCaUoc(int n)
        {
            Console.Write("Tất cả các ước của {0} là: ", n);

            for (int i = 1; i <= n; i++)
            {
                if(n %i == 0)
                    Console.Write(" {0}", i);
            }
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
                    Console.WriteLine("Nhập sai. Vui lòng nhập vào số dương (N > 0)!");
            } while (n <= 0);

            TatCaUoc(n);
            Console.ReadKey();
        }
    }
}
