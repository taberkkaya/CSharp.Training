namespace Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            int age = 5;
            Console.WriteLine(age);
            user.SetAge(ref age);
            Console.WriteLine(age);


            Console.WriteLine("Hello, World!");
        }
    }
}
