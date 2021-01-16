using System;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine($"{urun.Ad} sepete eklendi.");
        }
    }
}