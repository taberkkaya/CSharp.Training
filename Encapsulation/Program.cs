namespace Encapsulation
{
    internal class Program : User
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Id = 1;

            Program program = new();
            program.Age = 1;
        }
    }
}
