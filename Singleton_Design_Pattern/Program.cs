namespace Singleton_Design_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance(); 
            Singleton s3 = Singleton.getInstance();
            Singleton s4 = Singleton.getInstance();
            Singleton s5 = Singleton.getInstance();
            Singleton s6 = Singleton.getInstance();
        }

        class Singleton
        {
            private static Singleton _instance;
            private Singleton()
            {
                Console.WriteLine("Single class instance oluşturuldu.");
            }

            public static Singleton getInstance() {
                if(_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
