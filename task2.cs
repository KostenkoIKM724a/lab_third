using System;

class Task2
{
    static void Main()
    {
        Console.Write("Enter the number of array elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array[{i}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the target sum: ");
        int targetSum = int.Parse(Console.ReadLine());

        Console.WriteLine("\nFound pairs:");
        bool found = false;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == targetSum)
                {
                    Console.WriteLine($"Pair at indices [{i}] and [{j}]: {array[i]} + {array[j]} = {targetSum}");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No pairs with the specified sum were found.");
        }
    }
}