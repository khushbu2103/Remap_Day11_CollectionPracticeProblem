using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day11_CollectionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose any program");
            Console.WriteLine("1. Count of remaining chepters\n" +
                "2. Maximaum selling price");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CountOfRemainingChepters.RemainingChepters();
                    break;
                case 2:
                    MaximumSellingPrice.MaximumSellingPriceBySwapping();
                    break;
               
                default:
                    Console.WriteLine("Invalid use case number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
