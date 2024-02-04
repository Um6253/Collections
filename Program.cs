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
        class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        static Node AddNumber(Node head, int number)
        {
            Node newNode = new Node(number);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            return head;
        }

        static bool LinearSearch(Node head, int searchNumber)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == searchNumber)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Node numbers = null;

            Console.WriteLine("Enter numbers (enter -1 to stop):");

            
            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input == "-1")
                    break;

                if (int.TryParse(input, out int number))
                {
                    numbers = AddNumber(numbers, number);
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

            
            bool found = LinearSearch(numbers, searchNumber);

            
            if (found)
            {
                Console.WriteLine($"The number {searchNumber} is found in the list.");
            }
            else
            {
                Console.WriteLine($"The number {searchNumber} is not found in the list.");
            }
                Console.ReadLine();
        }
    }

        
    
}