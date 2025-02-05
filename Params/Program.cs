namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User user = new User();
            Console.WriteLine(user.Calculate(1, 2, 3, 4, 5, 6, 7, 8, 9));
        }
    }
}
