namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new();
            Console.WriteLine(user.GetAge());
            
            User2 user2 = new();
            Console.WriteLine(user2.GetAge());
        }
    }
}
