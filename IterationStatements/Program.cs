using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {            
            var numbers = new List<int>();

            int num = 0;

            do
            {
                num++;

                numbers.Add(num);

            } while (num < 100);
          
            while (num < 200) 
            {
                num++;

                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for(var i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }
        }
    }
}
