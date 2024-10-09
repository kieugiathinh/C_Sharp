using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT14_41SGK
{
    internal class Program
    {
        //Hàm bảng cửu chương
        static void BangCuuChuong(int x)
        {
            Console.WriteLine("Bảng cửu chương {0} là: ", x);
            for (int i = 1; i <= 9; i++)
            {
                double kq = x * i;
                Console.WriteLine("{0} x {1} = {2}", x, i, kq);
            }    
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int x;
            do
            {
                Console.Write("Bạn muốn in ra màn hình bảng cửu chương mấy: ");
                x = int.Parse(Console.ReadLine());

                if (x <= 0)
                    Console.WriteLine("Vui lòng nhập vào số nguyên dương!");
            } while (x <= 0);

            BangCuuChuong(x);
            Console.ReadKey();
        }
    }
}
