using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberOfZero;

namespace program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");

            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Base");

            double bases = Convert.ToDouble(Console.ReadLine());

            Fact factorial = new Fact();
            int num_Zero = factorial.Factoriallogic(num, bases);
            Console.WriteLine("The number of zero is " + num_Zero);

            Console.ReadKey();
        }
    }
}
