namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Id = 1;
            //user.Name = "Ataberk Kaya";
            string name = user.Name;

            user.Properties = "Prop";

            Console.WriteLine(user.Properties);
        }
    }
}
