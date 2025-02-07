namespace Template_Method_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alisveris a1 = new Televizyon();
            a1.TemplateMethod();

            Alisveris a2 = new Buzdolabi();
            a2.TemplateMethod();
        }

        enum OdemeTipi
        {
            Pesin,Taksit
        }

        abstract class Alisveris
        {
            protected string UrunAdi;
            protected OdemeTipi OdemeTipi;

            void Baslat() => Console.WriteLine("Başlat");
            void Bitir() => Console.WriteLine($"Bitir. {UrunAdi} {OdemeTipi} olarak alındı.");

            abstract public void Urun();
            abstract public void OdemeSekli();
            public void TemplateMethod()
            {
                Baslat();
                Urun();
                OdemeSekli();
                Bitir();
            }

        }

        class Televizyon : Alisveris
        {
            public override void OdemeSekli()
            {
                OdemeTipi = OdemeTipi.Pesin;
            }

            public override void Urun()
            {
                UrunAdi = "Televizyon";
            }
        }

        class Buzdolabi : Alisveris
        {
            public override void OdemeSekli()
            {
                OdemeTipi = OdemeTipi.Taksit;
            }

            public override void Urun()
            {
                UrunAdi = "Buzdolabı";
            }
        }
    }
}
