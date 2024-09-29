using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_39SGK
{
    internal class Program
    {
        //Hàm tìm số nguyên lớn nhất trong 4 số nguyên: Dùng hàm Max trong Math
        static void Max(double a, double b, double c, double d)
        {
            double Max = Math.Max(Math.Max(a, b), Math.Max(c, d));
            Console.WriteLine("Số lớn nhất trong 4 số là: {0}", Max);
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số nguyên thứ nhất: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên thứ hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên thứ ba: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào số nguyên thứ tư: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("4 số nguyên bạn vừa nhập là: {0}, {1}, {2}, {3}", a, b, c, d);
            Max(a, b, c, d);
            Console.ReadKey();
        }
    }
}
