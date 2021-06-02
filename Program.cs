using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = Class1();
            obj = Discountcalculation();
            Console.WriteLine("Discount is calculated");
            Console.ReadLine();
        }
    }
}
