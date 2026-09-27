using System;

class Task1
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        long number = long.Parse(Console.ReadLine());

        Console.Write("Enter the digit to find (0-9): ");
        int digitToFind = int.Parse(Console.ReadLine());

        if (digitToFind < 0 || digitToFind > 9)
        {
            Console.WriteLine("Error: Please enter a valid digit between 0 and 9.");
            return;
        }

        long temp = Math.Abs(number);
        int count = 0;

        if (temp == 0 && digitToFind == 0)
        {
            count = 1;
        }
        else
        {
            while (temp > 0)
            {
                long currentDigit = temp % 10;
                if (currentDigit == digitToFind)
                {
                    count++;
                }
                temp /= 10;
            }
        }

        Console.WriteLine($"The digit {digitToFind} occurs in the number {number} {count} time(s).");
    }
}