using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kursu";
            string kurs2 = "İkinci kurs";

            Console.WriteLine(kurs1);

            //array dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici Kursu","İkinci kurs","Üçüncü kurs"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine();
            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
