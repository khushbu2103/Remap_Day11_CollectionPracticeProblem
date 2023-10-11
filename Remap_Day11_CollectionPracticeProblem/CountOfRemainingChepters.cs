using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day11_CollectionPracticeProblem
{
    internal class CountOfRemainingChepters
    {
        //public static void RemainingChepters()
        //{
        //    int N = 4;
        //    List<int[]> chapters = new List<int[]> { new int[] { 1, 4 }, new int[] { 5, 7 }, new int[] { 9, 16 }, new int[] { 17, 26 } };
        //    int K = 7;

        //    int chaptersLeft = N;
        //    foreach (int[] chapter in chapters)
        //    {
        //        if (K >= chapter[0] && K <= chapter[1])
        //        {
        //            Console.WriteLine(chaptersLeft);
        //            break;
        //        }
        //        chaptersLeft--;
        //    }
        //}

        public static void RemainingChepters()
        {
            int N = 4;
            int[] arr = { 1, 4, 5, 7, 9, 16, 17, 26 };
            int K = 3;
            int kPosition = 0;
            for(int i = 0; i < arr.Length; i = i+2)
            {
                if (arr[i] <= K && K <= arr[i+1] )
                {
                    kPosition = (i / 2) + 1;
                }
            }
            Console.WriteLine( N - kPosition + 1);
        }
    }
}
