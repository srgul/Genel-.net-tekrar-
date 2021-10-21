using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 12;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sait";
            musteri1.Soyadi = "Gül";
            musteri1.TcNo = "12312312312";

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 1;
            musteri2.MusteriNo = "1231231231";
            musteri2.SirketAdi = "Ozztech Information";
            musteri2.VergiNo = "123123123";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
        }
    }
}
