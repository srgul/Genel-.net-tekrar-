using System;

namespace ClassIntroTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Sait";
            int yas = 24;

            Kurs kurs1 = new Kurs();

            kurs1.KursAdi = "deneme";
            kurs1.IzlenmeOranı = 1231;
            kurs1.Egitmen = "sait";

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "asd";
            kurs2.IzlenmeOranı = 1231;
            kurs2.Egitmen = "sait";

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "qweqwe";
            kurs3.IzlenmeOranı = 1231;
            kurs3.Egitmen = "sait";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : "+ kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
