using System;

namespace Metotlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Urun urun1 = new Urun()
            {
                Id = 1,
                Ad = "Elma",
                Fiyat = 15,
                Aciklama = "Amasya elması",
                StokAdedi = 10
            };

            Urun urun2 = new Urun()
            {
                Id = 2,
                Ad = "Karpuz",
                Fiyat = 80,
                Aciklama = "Diyarbakır karpuzu",
                StokAdedi = 5
            };

            //Urun[] urunler = new Urun[]
            //{
            //    urun1, urun2
            //};

            //// type-safe
            //foreach (Urun urun in urunler)
            //{
            //    Console.WriteLine($"{urun.Id}) {urun.Ad} ({urun.Aciklama}): {urun.Fiyat}TL");
            //}

            Console.WriteLine("\n--------------------\n");

            // Metotlar
            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
        }
    }
}