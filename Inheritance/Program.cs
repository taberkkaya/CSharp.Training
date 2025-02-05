namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User2 user = new();
            user.SetAge();
            var mail = user.Mail;
            user.Set();
        }
    }
}
