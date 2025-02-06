namespace Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            int age = 5;
            int age2;
            Console.WriteLine(age);
            user.SetAge(ref age);
            Console.WriteLine(age);
            

            user.SetAge2(out age2);
            Console.WriteLine(age2);

            Console.WriteLine("Hello, World!");
        }
    }
}
