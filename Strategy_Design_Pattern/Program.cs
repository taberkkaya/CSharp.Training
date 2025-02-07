namespace Strategy_Design_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            OzelYapimUret ozel = new();
            SeriUret seriUret = new();
            SiparisUzerine siparisUzerine = new();

            Uretici uretici = new(ozel);

        }




        public class Opel
        {
            public Opel(string uretimTipi)
            {
                Console.WriteLine($"Opel {uretimTipi} üretilmiştir.");
            }

        }

        abstract class Startegy
        {
            public abstract Opel Uret();
        }

        class SeriUret : Startegy
        {
            public override Opel Uret()
            {
                return new Opel("Seri");
            }
        }

        class OzelYapimUret : Startegy
        {
            public override Opel Uret()
            {
                return new Opel("Özel");
            }
        }

        class SiparisUzerine : Startegy
        {
            public override Opel Uret()
            {
                return new Opel("Sipariş üzerine");
            }
        }

        class Uretici
        {
            public Uretici(Startegy yontem)
            {
                yontem.Uret();
            }
        }

    }
}
