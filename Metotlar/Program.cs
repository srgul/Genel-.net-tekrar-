using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun elma = new Urun();

            elma.Adi = "Amasya";
            elma.Aciklama = "Amasyadan gelen elma";
            elma.Fiyat = 200;
            elma.Id = 1;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Fiyat = 199;
            urun2.Id = 2;


            Urun[] urunler = new Urun[]
            {
                elma, urun2
            };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Aciklama);
            }

            Console.WriteLine("---------------------------------");


            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun2);
            sepetManager.Ekle(elma);
           

            Console.WriteLine("Hello World!");


            sepetManager.Ekle2("armut", "çok iyi armut", 12, 20);
        }
    }
}
