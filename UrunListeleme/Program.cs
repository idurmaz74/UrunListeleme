using System;

namespace UrunListeleme
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunSnf Urun1 = new UrunSnf();
            Urun1.Ad = "4GB DDR3 1600Mhz";
            Urun1.Tur = "Bellek";
            Urun1.Fiyat = "208,00 TL";

            UrunSnf Urun2 = new UrunSnf();
            Urun2.Ad = "Huawei P40 Lite";
            Urun2.Tur = "Telefon";
            Urun2.Fiyat = "2649,00 TL";

            UrunSnf Urun3 = new UrunSnf();
            Urun3.Ad = "Arzum AR2013 Mikser";
            Urun3.Tur = "Küçük Ev Aletleri";
            Urun3.Fiyat = "179,89 TL";

            UrunSnf[] Urunler = new UrunSnf[]{ Urun1, Urun2, Urun3 };

            Console.WriteLine("-----------Foreach döngüsü ile--------\n");
            foreach (UrunSnf Urun in Urunler)
            {
                Console.WriteLine(Urun.Ad + " - " + Urun.Tur + " - " + Urun.Fiyat);
            }
            Console.WriteLine();

            Console.WriteLine("--------For döngüsü ile-----------\n");
            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine(Urunler[i].Ad + " - " + Urunler[i].Tur + " - " + Urunler[i].Fiyat);
            }
            Console.WriteLine();

            Console.WriteLine("----------While döngüsü ile-----------\n");
            int j = 0;
            while (j < Urunler.Length)
            {
                Console.WriteLine(Urunler[j].Ad + " - " + Urunler[j].Tur + " - " + Urunler[j].Fiyat);
                j++;
            }
        }
    }
}
