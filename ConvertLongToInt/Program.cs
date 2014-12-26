using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLongToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            int printNumber;

            number = Convert.ToInt64(Console.ReadLine());

            printNumber = (Int16) number;

            Console.WriteLine(printNumber);

            Console.ReadKey();

        }
    }
}
