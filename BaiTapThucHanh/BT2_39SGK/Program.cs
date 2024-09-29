using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_39SGK
{
    internal class Program
    {
        //Hàm phương trình bậc 1
        static void PhuongTrinhBac1(double a, double b)
        {
            if(a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phương trình vừa nhập vô số nghiệm");
                else
                    Console.WriteLine("Phương trình vừa nhập vô nghiệm");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phương trình vừa nhập có nghiệm x = {0}", x);
            }    
        }

        //Hàm phương trình bậc 2
        static void PhuongTrinhBac2(double a, double b, double c)
        {
            if(a == 0)
                PhuongTrinhBac1(b, c);
            else
            {
                double Delta = b * b - 4 * a * c;
                
                if(Delta < 0)
                    Console.WriteLine("Vì Delta = {0} < 0. Nên phương trình vừa nhập vô nghiệm", Delta);
                else if(Delta == 0)
                {
                    double xkep = -b / (2 * a);
                    Console.WriteLine("Vì Delta = 0. Nên phương trình vừa nhập có 1 nghiệm kép x = {0}", xkep);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(Delta)) / (2 * a);

                    Console.WriteLine("Vì Delta = {0} > 0. Nên phương trình vừa nhập có 2 nghiệm phân biệt.", Delta);
                    Console.WriteLine("x1 = {0} \nx2 = {1}", x1, x2);
                }
            }    
        }

        //Hàm Main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào hệ số a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập vào hệ số b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập vào hệ số c = ");
            double c = double.Parse(Console.ReadLine());

            PhuongTrinhBac2 (a, b, c);
            Console.ReadKey();
        }
    }
}
