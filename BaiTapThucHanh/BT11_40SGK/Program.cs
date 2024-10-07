using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT11_40SGK
{
    internal class Program
    {
        //Hàm UCLN
        static void UCLN(int a, int b)
        {
            Console.Write("Các ước chung của {0} và {1} là: ", a, b);

            int Max = 1;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.Write(" {0}", i);

                    Max = i;
                    if (Max < i)
                        Max = i;
                }    
            }
            Console.WriteLine("\nUCLN của {0} và {1} là: {2}", a, b, Max);
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a, b;
            do
            {
                Console.Write("Nhập vào số nguyên dương a = ");
                a = int.Parse(Console.ReadLine());

                if (a <= 0)
                    Console.WriteLine("Vui lòng nhập vào số nguyên dương!");
            } while(a <= 0);

            do
            {
                Console.Write("Nhập vào số nguyên dương b = ");
                b = int.Parse(Console.ReadLine());

                if (b <= 0)
                    Console.WriteLine("Vui lòng nhập vào số nguyên dương!");
            } while (b <= 0);

            UCLN(a, b);
            Console.ReadKey();
        }
    }
}
