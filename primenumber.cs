using System;
namespace algoritham
 class Primenumber
{
    public static void Main(string[] args)
    {
        int n, count = 0;
        Console.Write("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i ==)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            Console.WriteLine("prime number");
        }
        else
        {
            Console.WriteLine("not a prime");
        }
        Console.ReadLine();
