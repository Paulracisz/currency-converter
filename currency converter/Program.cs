using System;
using System.Threading;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining ints and doubles, that we will use later in our number comparisons
            int x = 0;
            double smallest = 0.0;
            double large = 0.00;
            int i = 0;
            //Greet the user, and prompt the user to enter 3 inputs
            Console.WriteLine("Welcome To The Currency Converter");

            Console.WriteLine("Please enter 3 numbers (Ex: 5.20): ");
            // Turning the user's input into a string called 'userInput1'
            String userInput1 = Console.ReadLine();
            //converting that string into a double value called 'doubleVal1'
            double doubleVal = Convert.ToDouble(userInput1);

            Console.WriteLine("Converting your number into US Dollars");
            //Fragment the doubleVal with the US dollar, rinse and repeat 2 more times
            Console.WriteLine($"${doubleVal}");
            Console.WriteLine("Please enter your second number.");
            String userInput2 = Console.ReadLine();
            double doubleVal2 = Convert.ToDouble(userInput2);

            Console.WriteLine("Converting your second number into Swedish currency");

            Console.WriteLine($"{doubleVal2}kr");

            Console.WriteLine("Please enter your final number (Integers Only)");
            //for the final number, the input is converted into an integer, because japanese currency has no decimal.

            String userInput3 = Console.ReadLine();
            int intVal3 = Convert.ToInt32(userInput3);

            Console.WriteLine("Converting your third and final number into Japanese currency");

            Console.WriteLine($"¥{intVal3}");
            //Now time to find the largest and smallest number. Here we go.
            //first lets make an array for our user's inputs
            double[] inputs = { doubleVal, doubleVal2, intVal3 };


            smallest = inputs[x];
            large = inputs[x];
            // a for loop, that will compare each number 
            for (i = 1; i < inputs.Length; i++)
            {
                //comparing the 3 numbers to find the smallest
                if (smallest > inputs[i])
                    smallest = inputs[i];
            }

            for (i = 1; i < inputs.Length; i++)
            {
                //comparing the 3 numbers to find the largest
                if (large < inputs[i])
                    large = inputs[i];
            }

            //printing the smallest and largest numbers
            Console.WriteLine("Your smallest number is : " + smallest);
            Console.WriteLine("Your greatest number is : " + large);
            //some basic math to find our sum
            double sumInput = doubleVal + doubleVal2 + intVal3;
            Console.WriteLine($"The sum of all of your numbers is {sumInput}");
            //Now to find the average of all numbers.
            double averageInput = doubleVal + doubleVal2 + intVal3 / 3;
            // adding up all of the numbers, then dividing that by 3, the ammount of numbers we have.
            Console.WriteLine($"The average number is {averageInput}");
            Console.WriteLine("Thank you for using the currency converter, and have a nice day!");
            // zzzzzzz..... (giving the user time to read.....) zzzz......
            Thread.Sleep(5000);



        }
    }
}
