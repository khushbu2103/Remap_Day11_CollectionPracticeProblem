using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day11_CollectionPracticeProblem
{
    internal class MaximumSellingPrice
    {
        public static void MaximumSellingPriceBySwapping()
        {
            int n = 5;
            int k = 2;
            int[] a = {  25, 16, 9, 21 };
            int[] b = { 1, 34, 22, 6, 12 };
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    sum += Math.Max(a[i], b[i]);
                }
                else
                {
                    sum += a[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
