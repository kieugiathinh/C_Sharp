using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7_40SGK
{
    internal class Program
    {
        //Hàm đọc số
        static string DocSo(int a)
        {
            //Tạo 2 mảng string
            string[] HangChuc = { "", "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };
            string[] HangDonVi = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            
            int chuc = a / 10;
            int donvi = a % 10;

            if (chuc == 1)
            {
                if (donvi == 0)
                    return "Mười";
                else if (donvi == 5)
                    return "Mười lăm";
                else
                    return "Mười " + HangDonVi[donvi];
            } 
            else
            {
                if (donvi == 0)
                    return HangChuc[chuc];
                else if (donvi == 1)
                    return HangChuc[chuc] + " mốt";
                else if (donvi == 5)
                    return HangChuc[chuc] + " lăm";
                else
                    return HangChuc[chuc] + " " + HangDonVi[donvi];
            }
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a;
            do
            {
                Console.Write("Nhập vào số nguyên dương có 2 chữ số (10 - 99): ");
                a = int.Parse(Console.ReadLine());

                if (a < 10 || a > 99)
                    Console.WriteLine("Nhập sai. Yêu cầu nhập từ 10 - 99!");
            } while (a < 10 || a > 99);

            //Vì hàm DocSo là string nên gọi hàm phải Console.Write(DocSo(a));
            Console.WriteLine("Số {0} đọc là: {1}", a, DocSo(a));
            Console.ReadKey();
        }
    }
}
