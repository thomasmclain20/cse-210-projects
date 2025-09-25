using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Let's make a list of numbers! Then we will add then find average and which one is the largest!");
        List<int> numbers = new List<int>();
        int userNumber;
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            userNumber = int.Parse(Console.ReadLine());
            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }while (userNumber !=0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum:" + sum);

        double average = (double)sum / numbers.Count;
        Console.WriteLine("Average: " + average);

        int largest = numbers.Max();
        Console.WriteLine("Largest: " + largest);
    }
}