using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            //Kurs kurs1; //Kurs diye bir değişken tanımlayabilmen için classı tanımlı olmalı. Kendi veri türünü bu şekilde tanımlayabilirsin. 


            //oluşturduğun classın değişkenlerini oluşturmak ve atamak için kullanacağın yapı bu aşağıdaki blok. 
            Kurs kurs1 = new Kurs(); //bu veri tipinden bir değişken tanımlamak istiyorsan bu syntaxı kullanmalısın. 
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //bu veri tipinden bir değişken tanımlamak istiyorsan bu syntaxı kullanmalısın. 
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); //bu veri tipinden bir değişken tanımlamak istiyorsan bu syntaxı kullanmalısın. 
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen);

            // Bir öncekinde string diziyi nasıl oluşturmuştum aşağıdaki gibi
            //string[] kurslar = new string[] { "Yazılım Geliştirici Kursu", "Java", "C#" };

            //Şimdi de stringlerden değil de Kurs veri tipli verilerden oluşan bir diziyi aşağıdaki gibi tanımlıcam
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": "+ kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }
}
