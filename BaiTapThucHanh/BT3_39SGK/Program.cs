using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_39SGK
{
    internal class Program
    {
        //Hàm tính tổng hiệu 2 giờ
        static void TongHieu2Gio(int Gio1, int Phut1, int Gio2, int Phut2)
        {
            int TongThoiGian1 = Gio1 * 60 + Phut1;
            int TongThoiGian2 = Gio2 * 60 + Phut2;

            int Tong2ThoiGian = TongThoiGian1 + TongThoiGian2;
            int Hieu2ThoiGian = Math.Abs(TongThoiGian1 - TongThoiGian2);

            int GioTong = Tong2ThoiGian / 60;
            int PhutTong = Tong2ThoiGian % 60;

            int GioHieu = Hieu2ThoiGian / 60;
            int PhutHieu = Hieu2ThoiGian % 60;

            //if (GioTong > 12)
            //    GioTong = GioTong / 12;

            //Xuất thời gian
            Console.WriteLine("Thời gian thứ nhất là: {0}:{1}", (TongThoiGian1 / 60), (TongThoiGian1 % 60));
            Console.WriteLine("Thời gian thứ hai là: {0}:{1}", (TongThoiGian2 / 60), (TongThoiGian2 % 60));
            Console.WriteLine();

            Console.WriteLine("Tổng 2 thời gian là: {0} giờ {1} phút.", GioTong, PhutTong);
            Console.WriteLine("Hiệu 2 thời gian là: {0} giờ {1} phút.", GioHieu, PhutHieu);
        }



        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("***Nhập thời gian thứ nhất***");

            Console.Write("Nhập vào giờ thứ nhất: ");
            int Gio1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào phút thứ nhất: ");
            int Phut1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("***Nhập thời gian thứ hai***");

            Console.Write("Nhập vào giờ thứ hai: ");
            int Gio2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào phút thứ hai: ");
            int Phut2 = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Thời gian thứ nhất là: {0}:{1}", Gio1, Phut1);
            //Console.WriteLine("Thời gian thứ hai là: {0}:{1}", Gio2, Phut2);
            Console.WriteLine();

            TongHieu2Gio(Gio1, Phut1, Gio2, Phut2 );
            Console.ReadKey();
        }
    }
}
