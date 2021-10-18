using System;

namespace DongulerTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {
                "kurslar 1",
                "kurslar 2",
                "kurslar 3"
            };

            for(int i = 0; i <  kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
