using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class LinQ
    {
        public static void IntroLinq()
        {
            int[] numbers = new int[] { 98, 99, 200, 95, 97, 94, 80, 2019 };
            // sum from 98 to 2019
            var sum = numbers.Sum(x => x++);
            Console.WriteLine($"Sum = {sum}");

            var min = numbers.Min();
            Console.WriteLine($"Min ={min}");

            var max = numbers.Max();
            Console.WriteLine($"Max ={max}");

            var duplicates = numbers.Distinct();

            foreach (var item in duplicates)
            {
                Console.WriteLine(item);
            }
        }
    }
}
