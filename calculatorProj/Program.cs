using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace calculatorProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbe 1:");
            string str =Console.ReadLine();
            double n1 = Convert.ToDouble(str);
            Console.WriteLine($"You have entered {str}");

            Console.Write("Enter the numbe 2:");
            string str1 = Console.ReadLine();
            double n2 = Convert.ToDouble(str1);
            Console.WriteLine($"You have entered {str1}");

            Console.WriteLine($"sum = {n1 + n2}");
            Console.Read();
        }
    }
}
