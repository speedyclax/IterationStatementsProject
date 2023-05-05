using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
            
            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num - done
            //initialize the variable with a value of 0 - done

            int num = 0;


            // Create a do-while loop and use the template below: - done

            do
            {
                num++;
                // Increment num by 1 - done

                // Then add num to the collection - numbers - done
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100); // <---- While your variable is less than 100 - done



            // Create a while loop
            // <--- While num is less than 200 - done
            while(num < 200)
            {
                // Increment num by 1 - done
                num++;
                // Then add num to the collection numbers - done
                //HINT: copy how this was done in the do while loop
                numbers.Add(num);
            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers - done
                //In the scope of the foreach loop, print each number in numbers - done
             foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199 - done
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count) - done
                // AND as long as i is greater than or equal to 0 - done
                // Decrement i by 1 - done

            for(int i = 199; i <= numbers.Count && i >= 0; i--)

            //start for loop here
            {
                // place numbers[i] inside of the Console.WriteLine() method - done
                Console.WriteLine(numbers[i]);
            }

            //------------End of exercise
        }
    }
}
