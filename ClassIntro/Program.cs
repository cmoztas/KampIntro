using System;

namespace ClassIntro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs { KursAdi = "C#", Egitmen = "Engin Demiroğ", IzlenmeOrani = 68 };
            Kurs kurs2 = new Kurs { KursAdi = "Java", Egitmen = "Kerem Varış", IzlenmeOrani = 64 };
            Kurs kurs3 = new Kurs { KursAdi = "Python", Egitmen = "Berkay Bilgin", IzlenmeOrani = 80 };
            Kurs kurs4 = new Kurs { KursAdi = "C++", Egitmen = "Murat Kurtboğan", IzlenmeOrani = 100 };

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }

    internal class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}