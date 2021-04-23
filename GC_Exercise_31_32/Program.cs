using System;
using System.Linq;

namespace GC_Exercise_31_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise31();
            Exercise32();
        }

        public static void Exercise31()
        {
            Console.WriteLine("Exercise 31");
            int[] numbers = new int[] { 2, 8, 0, 24, 51 };
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Enter an index of the array");

                int index;

                bool userInput = int.TryParse(Console.ReadLine(), out index);
                
                if(!userInput || index > numbers.Length)
                {
                    Console.WriteLine("That is not a valid index.");
                }
                else
                    Console.WriteLine($"The value at index {index} is {numbers[index]}");

                //continue?
                bool conLoop = true;
                while (conLoop)
                {
                    Console.WriteLine("Continue? y/n");
                    string vCon = Console.ReadLine().ToLower();

                    switch (vCon)
                    {
                        case "y":
                            conLoop = false;
                            repeat = true;
                            break;
                        case "n":
                            Console.WriteLine("Goodbye!");
                            conLoop = false;
                            repeat = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            conLoop = true;
                            break;
                    }
                }
            }

        }



        public static void Exercise32()
        {
            Console.WriteLine("Exercise 32");
            int[] numbers = new int[] { 2, 8, 0, 24, 51 };

            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Enter a number.");
                int parsedInput;

                bool userInput = int.TryParse(Console.ReadLine(), out parsedInput);


                int index = Array.IndexOf(numbers, parsedInput);

                if (numbers.Contains(parsedInput) == false || userInput == false)
                {
                    Console.WriteLine("That value cannot be found in the array.");
                }
                else
                {
                    Console.WriteLine($"The value {parsedInput} can be found at index {index}");
                }

                //continue?
                bool conLoop = true;
                while (conLoop)
                {
                    Console.WriteLine("Continue? y/n");
                    string vCon = Console.ReadLine().ToLower();

                    switch (vCon)
                    {
                        case "y":
                            conLoop = false;
                            repeat = true;
                            break;
                        case "n":
                            Console.WriteLine("Goodbye!");
                            conLoop = false;
                            repeat = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            conLoop = true;
                            break;
                    }
                }
            }
        }
    }
}

