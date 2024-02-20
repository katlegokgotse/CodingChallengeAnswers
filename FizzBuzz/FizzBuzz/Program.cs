internal class Program
{
    public static void Main(string[] args)
    {
        for (int numToHundred = 1; numToHundred <= 100; numToHundred++)
        {
             if (numToHundred % 5 == 0 && numToHundred % 3 == 0)
            {
                Console.WriteLine($"{numToHundred}\t FizzBuzz");
            }
            else if (numToHundred % 3 == 0)
            {
                Console.WriteLine($"{numToHundred}\t Fizz");
            }
            else if (numToHundred % 5 == 0)
            {
                Console.WriteLine($"{numToHundred}\t Buzz");
            }
           
            else
            {
                Console.WriteLine(numToHundred);
            }
        }
    }
}