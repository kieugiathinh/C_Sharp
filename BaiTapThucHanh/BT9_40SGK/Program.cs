using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT9_40SGK
{
    internal class Program
    {
        //Hàm tính tiền lương
        static void TienLuong(double LuongMoiNgay, double SoNgayLamViec, double SoGioTangCa, double SoNgayDiTre)
        {
            //Tính tiền thưởng
            double TienThuong = SoGioTangCa * 10000; 

            for (int i = 1; i <= SoNgayLamViec; i++)
                if (i > 24)
                    TienThuong = TienThuong + 15000;

            //Tình tiền phạt
            double TienPhat = SoNgayDiTre * 20000;

            //Tính tổng tiền lương
            //TienLuong = (Mức lương mỗi ngày * số ngày) + tiền thưởng - tiền phạt
            double TongLuong = (LuongMoiNgay * SoNgayLamViec) + TienThuong - TienPhat;

            Console.WriteLine("Tổng tiền lương mà nhân viên nhận được là: {0}đ", TongLuong);
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double LuongMoiNgay, SoNgayLamViec, SoGioTangCa, SoNgayDiTre;

            //Nhập
            do
            {
                Console.Write("Nhập vào tiền lương mỗi ngày: ");
                LuongMoiNgay = double.Parse(Console.ReadLine());

                if (LuongMoiNgay <= 0)
                    Console.WriteLine("Nhập sai. Vui lòng nhập lương mỗi ngày > 0!");
            } while (LuongMoiNgay <= 0);
            
            do
            {
                Console.Write("Nhập vào số ngày làm việc: ");
                SoNgayLamViec = double.Parse(Console.ReadLine());

                if (SoNgayLamViec <= 0)
                    Console.WriteLine("Nhập sai. Vui lòng nhập số ngày làm việc > 0!");
            } while(SoNgayLamViec <= 0);

            do
            {
                Console.Write("Nhập vào số giờ làm việc tăng ca: ");
                SoGioTangCa = double.Parse(Console.ReadLine());

                if (SoGioTangCa < 0)
                    Console.WriteLine("Nhập sai. Vui lòng nhập số giờ tăng ca >= 0!");
            }while(SoGioTangCa < 0);
            
            do
            {
                Console.Write("Nhập vào số ngày đi trễ: ");
                SoNgayDiTre = double.Parse(Console.ReadLine());

                if (SoNgayDiTre < 0)
                    Console.WriteLine("Nhập sai. Vui lòng nhập số ngày đi trễ >= 0!");
            } while(SoNgayDiTre < 0);   
            

            //Xuất
            Console.WriteLine();
            Console.WriteLine("Tiền lương mỗi ngày là: {0}đ", LuongMoiNgay);
            Console.WriteLine("Số ngày làm việc là: {0} ngày", SoNgayLamViec);
            Console.WriteLine("Số giờ tăng ca là: {0} giờ", SoGioTangCa);
            Console.WriteLine("Số ngày đi trễ là: {0} ngày", SoNgayDiTre);

            TienLuong(LuongMoiNgay, SoNgayLamViec, SoGioTangCa, SoNgayDiTre);
            Console.ReadKey();
        }
    }
}
