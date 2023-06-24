using System;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = GenerateRandomNumbers(10);

        var sortedNumbers = numbers.OrderBy(x => x).ToArray();
        int middleIndex = (int)Math.Ceiling(sortedNumbers.Length / 2.0);
        var result = sortedNumbers.Skip(middleIndex).Select(x => x * x).OrderByDescending(x => x).ToArray();
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
    public static int[] GenerateRandomNumbers(int count)
    {
        Random random = new Random();
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = random.Next(1, 100);
        }

        return numbers;
    }
}
