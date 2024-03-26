using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    static class Programm1
    {
        public static void main() 
        {
            int[] arr = new int[3]
                .Select(x => new Random().Next(100)).ToArray().Print();
            int[] arr1 = arr.OrderBy(x => x).ToArray().Print();
            int[] arr2 = arr.OrderByDescending(x => x).ToArray();
            if (arr.SequenceEqual(arr1)) "orderby".Print();
            else if (arr.SequenceEqual(arr2)) "OrderByDescending".Print();
            else "random".Print();
        
        }
    }
}
