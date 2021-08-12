using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
    
{
    class bubbleSorting
    {
        static void main(string[] args)
        {
            int[] data = { 98 , 67 ,45 , 98 ,54 };
            int temp;

            for (int j = 0; j <= data.Length - 2; j++)
            {
                for (int i = 0; i <= data.Length - 2; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        temp = data[i + 1];
                        data[i + 1] = data[i];
                        data[i] = temp;
                    }
                }
            }

            Console.WriteLine("Bubble sort data:");
            foreach (int p in data)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
   