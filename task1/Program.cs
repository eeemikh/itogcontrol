namespace task1
{
    public static class IntExtention
    {
        public static string Toword (this int number)
        {
            string[] words = { "zero", "one", "two", "three", "four", "fivr", "six", "seven", "eight", "nine" };
        if (number == 0) return words[0];

            string result = string.Empty;

            while (number > 0) 
            {
            int digit = number % 10;
                result = words[digit] + " " + result;
                number /= 10;
            }
            return result.Trim();

        }
    }
    public class Program
    {
        static void Main(string[] args) 
        {
            int number = 123456;
            string wordstr = number.Toword();
            Console.WriteLine(wordstr);
        }
    }
}
