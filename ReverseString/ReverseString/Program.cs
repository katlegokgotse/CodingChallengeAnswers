using System.Linq;
using System.Text.Json.Serialization.Metadata;

internal class Program
{
    public static void Main(string[] args)
    {
        ReverseString();
    }

   public static void ReverseString()
    {
        Console.WriteLine($"Enter a string: ");
        String userInput = Console.ReadLine();
        char[] value = userInput.ToCharArray();
        string v = "";
        for (int i = value.Length - 1; i >= 0; i--)
        {
             v = Convert.ToString(value[i]);
            Console.Write(v);
        }

    }
}