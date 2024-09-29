using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_39SGK
{
    internal class Program
    {
        //Hàm tính điểm trung bình
        static void DiemTrungBinh(double a, double b, double c)
        {
            double DTB = (a + b + c) / 3;
            Console.WriteLine("Vậy điểm trung bình của 3 môn Toán, Lý, Hóa là: {0}", DTB);
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double Toan, Ly, Hoa;
            do
            {
                Console.Write("Nhập vào điểm môn Toán: ");
                Toan = double.Parse(Console.ReadLine());

                if (Toan < 0 || Toan > 10)
                    Console.WriteLine("Nhập sai. Yêu cầu nhập điểm từ 0 - 10.");
            } while(Toan < 0 || Toan > 10);

            do
            {
                Console.Write("Nhập vào điểm môn Lý: ");
                Ly = double.Parse(Console.ReadLine());

                if (Ly < 0 || Ly > 10)
                    Console.WriteLine("Nhập sai. Yêu cầu nhập điểm từ 0 - 10.");
            } while (Ly < 0 || Ly > 10);

            do
            {
                Console.Write("Nhập vào điểm môn Hóa: ");
                Hoa = double.Parse(Console.ReadLine());

                if (Hoa < 0 || Hoa > 10)
                    Console.WriteLine("Nhập sai. Yêu cầu nhập điểm từ 0 - 10.");
            } while (Hoa < 0 || Hoa > 10);

            DiemTrungBinh(Toan, Ly, Hoa);
            Console.ReadKey();
        }
    }
}
