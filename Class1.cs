using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Class1
    {
        public void Discountcalculation()
        {
            int price = Convert.ToInt32(Console.ReadLine());
            int discount = Convert.ToInt32(Console.ReadLine());
            int calculate = Convert.ToInt32((price * discount) / 100);
            Console.WriteLine("The discount for given Price is " + calculate);
        }

    }
}
