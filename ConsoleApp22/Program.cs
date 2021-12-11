using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int[] arr = { 100, 0, -5, 10, 2222 };
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] > 99 && arr[i] < 1000)
                {
                    sum1+=arr[i];
                }
                else
                {
                    sum2+=arr[i];
                }
            }
            Console.WriteLine(sum1-sum2);
        }
    }
}
