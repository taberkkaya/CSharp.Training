namespace Dependency_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ILogger logger = new DbLog();
            ILogger logger = new TextLog();
            logger.Log();
        }

        interface ILogger
        {
            void Log();
        }

        public class DbLog : ILogger
        {
            public void Log()
            {
                Console.WriteLine("DbLogger");
            }
        }

        public class TextLog : ILogger
        {
            public void Log()
            {
                Console.WriteLine("TextLogger");
            }
        }
    }
}
