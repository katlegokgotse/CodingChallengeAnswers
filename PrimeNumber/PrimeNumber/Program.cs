internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to predict a prime number");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(isNumberPrime(number));
    }
   
    public static Boolean isNumberPrime(int number)
    {
       
            if ( number / 1 == number && number / number == 1 && number % 2 != 0 && number % 3 != 0 )
                return true;
        return false;
    }
}