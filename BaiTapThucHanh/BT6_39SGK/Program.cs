using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6_39SGK
{
    internal class Program
    {
        //Hàm tổng, hiệu, tích, thương
        static void Tong(double a, double b)
        {
            double tong = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, tong);
        }

        static void Hieu(double a, double b)
        {
            double hieu = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, hieu);
        }

        static void Tich(double a, double b)
        {
            double tich = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, tich);
        }

        static void Thuong(double a, double b)
        {
            //Kiểm tra điều kiện mẫu. Nếu mẫu =0 thì không thực hiện phép chia
            if(b==0)
                Console.WriteLine("Vì b = 0. Nên không thể thực hiện phép chia.");
            else
            {
                double thuong = a / b;
                Console.WriteLine("{0} / {1} = {2}", a, b, thuong);
            }
        }


        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số nguyên a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên b = ");
            double b = double.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine(); 
                Console.WriteLine("***Mời bạn chọn chức năng***");
                Console.WriteLine("1. Tổng");
                Console.WriteLine("2. Hiệu");
                Console.WriteLine("3. Tích");
                Console.WriteLine("4. Thương");
                Console.WriteLine("5. Thoát chương trình");

                Console.Write("Mời bạn nhập lựa chọn: ");
                double LuaChon = double.Parse(Console.ReadLine());

                switch (LuaChon)
                {
                    case 1: Tong(a, b); break;
                    case 2: Hieu(a, b); break;
                    case 3: Tich(a, b); break;
                    case 4: Thuong(a, b); break;
                    case 5: return;
                }
            }
            
            Console.ReadKey();
        }
    }
}
