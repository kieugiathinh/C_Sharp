using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_39SGK
{
    internal class Program
    {
        //Hàm tính tiền Taxi
        static void TienTaxi(double km)
        {
            double Tien = 0;
            for (int i = 1; i <= km; i++)
            {
                if (i <= 1)
                    Tien += 5000;
                if (i >= 2 && i <= 5)
                    Tien += 4500;
                if (i > 5)
                    Tien += 3500;
            }
            if (km > 120)
                Tien = Tien - Tien / 100 * 10;

            Console.WriteLine("Tổng tiền mà bạn phải trả cho {0}km là: {1}đ", km, Tien);
        }


        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double km;
            do
            {
                Console.Write("Nhập số km mà bạn đã đi: ");
                km = double.Parse(Console.ReadLine());

                if (km <= 0)
                    Console.WriteLine("Vui lòng nhập vào số km > 0");
            } while (km <= 0);
            

            TienTaxi(km);
            Console.ReadKey();
        }
    }
}
