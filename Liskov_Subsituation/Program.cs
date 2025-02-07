namespace Liskov_Subsituation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HP hP = new HP();
            hP.Print();
            hP.Scan();

            Canon canon = new Canon();
            canon.Print();
            //canon.Scan();

        }

        public abstract class BasePrinter
        {
            public abstract void Print();
        }

        public interface IScanner
        {
            void Scan();
        }

        public class HP : BasePrinter, IScanner
        {
            public override void Print()
            {
                throw new NotImplementedException();
            }

            public void Scan()
            {
                throw new NotImplementedException();
            }
        }

        public class Canon : BasePrinter
        {
            public override void Print()
            {
                throw new NotImplementedException();
            }
        }
    }
}
