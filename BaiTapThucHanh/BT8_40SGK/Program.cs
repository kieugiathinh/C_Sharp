using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT8_40SGK
{
    internal class Program
    {
        //Hàm tính tiền thuê phòng loại A
        static void TienPhongA(double n)
        {
            double Tien = n * 250000;
            if (n > 10)
                Tien = Tien - Tien / 100 * 10;
            Console.WriteLine("Vậy tiền thuê phòng A trong {0} ngày là: {1}đ", n, Tien);
        }

        //Hàm tính tiền thuê phòng loại B
        static void TienPhongB(double n)
        {
            double Tien = n * 200000;
            if (n > 10)
                Tien = Tien - Tien / 100 * 10;
            Console.WriteLine("Vậy tiền thuê phòng B trong {0} ngày là: {1}đ", n, Tien);
        }

        //Hàm tính tiền thuê phòng loại C
        static void TienPhongC(double n)
        {
            double Tien = n * 150000;
            if (n > 10)
                Tien = Tien - Tien / 100 * 10;
            Console.WriteLine("Vậy tiền thuê phòng C trong {0} ngày là: {1}đ", n, Tien);
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double LuaChon, n;

            do
            {
                Console.Write("Nhập vào số ngày thuê phòng: ");
                n = double.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Nhập sai. Yêu cầu nhập số ngày thuê phòng > 0.");
            } while (n <= 0);
            

            Console.WriteLine();
            Console.WriteLine("Chọn loại phòng mà bạn muốn thuê");
            Console.WriteLine("1. Loại A - 250.000 đ/ngày");
            Console.WriteLine("2. Loại B - 200.000 đ/ngày");
            Console.WriteLine("3. Loại C - 150.000 đ/ngày");
            Console.WriteLine("4. Thoát");
            Console.WriteLine();

            do
            {
                Console.Write("Chọn loại phòng mà bạn muốn: ");
                LuaChon = double.Parse(Console.ReadLine());

                if (LuaChon < 1 || LuaChon > 4)
                    Console.WriteLine("Nhập sai. Yêu cầu nhập lựa chọn từ 1 - 3.");
            } while (LuaChon < 1 || LuaChon > 4);
            
            switch (LuaChon)
            {
                case 1: TienPhongA(n); break;
                case 2: TienPhongB(n); break;
                case 3: TienPhongC(n); break;
                case 4: return;
            }

            Console.ReadKey();
        }
    }
}
