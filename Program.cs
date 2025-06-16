namespace ConsoleApp_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <=num; i++) {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of " + num + " is " + fact);

        }
    }
}
