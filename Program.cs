using System;

namespace Osvoenie
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Enter arguments!");
          
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int D = b*b - 4 * a * c;
            if(D<0)
            {
                Console.WriteLine("Bad arguments, try again");
                
            }
            double k = Math.Sqrt(D);
            double x1=(-b+ k)/(2*a);
            double x2 = (-b - k) / (2 * a);
            Console.WriteLine();
            Console.Write("x1=");
            Console.WriteLine(x1);
            Console.Write("x2=");
            Console.WriteLine(x2);
        }
    }
}
