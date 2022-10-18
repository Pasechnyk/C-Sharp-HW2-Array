using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - find minimum value in array
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Minimum value is: " + numbers.Min());


            // Task 2 - create an array with random numbers
            int[] numbers2 = new int[5];

            Random random = new Random();
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = random.Next();
            }
            foreach (int i in numbers2)
            {
                Console.WriteLine(i.ToString());
            }

            if (numbers2.Distinct().Count() != numbers2.Length)
            {
                Console.WriteLine("This array has duplicates!");
            }
            else { Console.WriteLine("No duplicates!"); }


            // Task 3 - copy odd numbers into new array

            int[] numbers3 = new int[5];

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    numbers.CopyTo(numbers3, i);
                }
            }
            foreach (int i in numbers3)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
