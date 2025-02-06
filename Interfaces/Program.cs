namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUser user = new User();
            user.Register();

            IUser googleUser = new GoogleUser();
            googleUser.Register();

            Console.WriteLine("Hello, World!");
        }
    }
}
