using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Lenght;
            double L = myDelegate(5);
            Console.WriteLine(L);
          

            myDelegate = Area;
            double A = myDelegate(5);
            Console.WriteLine(A);
           


            myDelegate = Volume;
            double V = myDelegate(5);
            Console.WriteLine(V);
            Console.ReadKey();

        }
        static double Lenght(double R) => 2 * Math.PI * R;
        static double Area(double R) => Math.PI * R * R;
        static double Volume(double R) => Math.PI * 4 / 3 * Math.Pow(R, 3);
    }
}
