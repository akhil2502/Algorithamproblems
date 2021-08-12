using System;
using System.IO;

namespace Algorithm
{
    class Program
    {
        static void InvokeClass()
        {
            string filepath = @"V:\BridgeLabz\Algorithm\Algorithm\BinarySearch.txt";
            string text = File.ReadAllText(filepath);
            string[] textArray = text.Split(" ");
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1: BinarySearchWord");
                Console.WriteLine("2. Insertion Sort");
                Console.WriteLine("3. Bubble Sort");
                Console.WriteLine("4. Prime Number");
                Console.WriteLine("5. Prime: Palindrome and Anagram");
                Console.WriteLine("0: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearchWord<string> search = new BinarySearchWord<string>(textArray);
                        Console.WriteLine("Enter the word to search");
                        string searchElement = Console.ReadLine();
                        int found = search.BinarySearch(textArray, searchElement);
                        if (found == -1)
                        {
                            Console.WriteLine("Sorry! Word is not present.");
                        }
                        else
                        {
                            Console.WriteLine("{0} is present in the file", searchElement);
                        }
                        break;
                    case 2:
                        InsertionSort<string> insertionSort = new InsertionSort<string>();
                        insertionSort.Insertion_Sort(textArray);
                        insertionSort.Display(textArray);
                        break;
                    case 3:
                       
                        BubbleSorting<int> bubbleSorting = new BubbleSorting<int>();
                        bubbleSort.Bubble_Sort(arr);
                        bubbleSort.Display(arr);
                        break;
                    case 4:
                        Console.WriteLine("Prime Numbers");
                        PrimeNumber.PrintPrime();
                        break;
                    case 5:
                        PrimeNumber.PrintPrime();
                        PrimeNumber.PrintPalindrome();
                        break;
                    case 0:
                        Console.WriteLine("Have a nice day!");
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Please, Select valid option!");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Program.InvokeClass();
        }
    }
}