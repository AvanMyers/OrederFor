using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int staticNumber = 7;
            int starterNumber = 5;
            string enteredMesage = "";
            int lastNumber = 103;

            Console.WriteLine($"Счет будет вестись до {lastNumber}");

            for (int i = starterNumber; i <= lastNumber; i += staticNumber)
            {
                enteredMesage += Convert.ToString(i) + " ";
            }

            Console.WriteLine(enteredMesage);
            Console.ReadKey();
        }
    }
}
