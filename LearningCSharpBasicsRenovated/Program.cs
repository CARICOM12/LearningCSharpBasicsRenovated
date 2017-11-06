using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private decimal dollarToUa = 26.93m;
        private decimal dollarToBy = 1.98m;
        private decimal dollarToRu = 59.05m;
        private decimal dollarToCn = 6.63m;
        private decimal dollarToIn = 64.70m;
        private decimal storage;

        private decimal Input()
        {
            Console.WriteLine("Please type amount of money for a conversion: ");
            storage = Convert.ToDecimal(Console.ReadLine());
            return storage;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
