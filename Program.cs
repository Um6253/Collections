using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static bool LinearSearchWithHashSet(int[] array, int target)
        {
            HashSet<int> set = new HashSet<int>(array);

            return set.Contains(target);
        }

        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            Console.WriteLine("Enter numbers (enter -1 to stop):");

           
            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input == "-1")
                    break;

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine("\nEnter the number to search:");
            int searchNumber;
            while (!int.TryParse(Console.ReadLine(), out searchNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer to search:");
            }

            
            bool found = false;
            foreach (int num in numbers)
            {
                if (num == searchNumber)
                {
                    found = true;
                    break;
                }
            }

            
            if (found)
            {
                Console.WriteLine($"The number {searchNumber} is found in the set.");
            }
            else
            {
                Console.WriteLine($"The number {searchNumber} is not found in the set.");
            }
            Console.ReadLine();
        }
    }
}