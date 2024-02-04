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
            
                Stack<int> numbers = new Stack<int>();

                Console.WriteLine("Enter numbers (enter -1 to stop):");

                
                while (true)
                {
                    Console.Write("Enter a number: ");
                    string input = Console.ReadLine();

                    if (input == "-1")
                        break;

                    if (int.TryParse(input, out int number))
                    {
                        numbers.Push(number);
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
                    Console.WriteLine($"The number {searchNumber} is found in the stack.");
                }
                else
                {
                    Console.WriteLine($"The number {searchNumber} is not found in the stack.");
                }

            }
    }
        
    
}