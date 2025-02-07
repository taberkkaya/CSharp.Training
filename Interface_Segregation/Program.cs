namespace Interface_Segregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        interface IGet
        {
            void Get();

        }

        interface IApiMethods : IGet
        {
            void Post();
        }

        class News : IApiMethods
        {
            public void Get()
            {
                throw new NotImplementedException();
            }

            public void Post()
            {
                throw new NotImplementedException();
            }
        }

        class Notification : IGet
        {
            public void Get()
            {
                throw new NotImplementedException();
            }
        }
    }
}
