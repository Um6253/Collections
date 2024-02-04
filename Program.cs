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

        static void Main(string[] args)
        {

            Dictionary<int, bool> numbers = new Dictionary<int, bool>();

            Console.WriteLine("Enter numbers (enter -1 to stop):");

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input == "-1")
                    break;

                if (int.TryParse(input, out int number))
                {
                    if (!numbers.ContainsKey(number))
                    {
                        numbers[number] = true;
                    }
                    else
                    {
                        Console.WriteLine($"Number {number} already exists. Please enter a different number.");
                    }
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

            
            bool found = numbers.ContainsKey(searchNumber);

            if (found)
            {
                Console.WriteLine($"The number {searchNumber} is found in the set.");
            }
            else
            {
                Console.WriteLine($"The number {searchNumber} is not found in the set.");
            }

        }
    }
        
    
}