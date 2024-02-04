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

            Queue<int> numbers = new Queue<int>();

            Console.WriteLine("Enter numbers (enter -1 to stop):");

            
            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input == "-1")
                    break;

                if (int.TryParse(input, out int number))
                {
                    numbers.Enqueue(number);
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
            int count = numbers.Count;
            for (int i = 0; i < count; i++)
            {
                int num = numbers.Dequeue();
                if (num == searchNumber)
                {
                    found = true;
                    break;
                }
                numbers.Enqueue(num);
            }

            
            if (found)
            {
                Console.WriteLine($"The number {searchNumber} is found in the queue.");
            }
            else
            {
                Console.WriteLine($"The number {searchNumber} is not found in the queue.");
            }

        }
    }
        
    
}