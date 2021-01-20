using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriList(Musteri musteri)
        {
            Console.WriteLine("Müsteri Bilgileri");
            Console.WriteLine("-----------------");
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
            Console.WriteLine(musteri.Yas);
            Console.WriteLine(musteri.Id);
            Console.WriteLine("-----------------");
        }

        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.Ad);
        }

        public void musteriSil (Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + musteri.Ad);
        }
            
    }
}
