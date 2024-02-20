internal class Program
{
    public static void Main(string[] args)
    {
        A1TOH8();
    }
    public static void A1TOH8()
    {
        for (int character = 65; character <= 72; character++)
        {
            char letter = (char)character;
            for (int number = 1; number <= 8; number++)
            {
                Console.WriteLine($"{letter}{number}");
            }
        }
    }
}