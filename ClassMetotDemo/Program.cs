using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Bilgehan";
            musteri1.Soyad = "Yaradanakul";
            musteri1.Yas = 18;
            musteri1.Id = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Buğse";
            musteri2.Soyad = "Ateş";
            musteri2.Yas = 22;
            musteri2.Id = 132456784;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Hakkı";
            musteri3.Soyad = "Yılmaz";
            musteri3.Yas = 37;
            musteri3.Id = 132346784;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriList(musteri1);
            musteriManager.musteriList(musteri2);
            musteriManager.musteriList(musteri3);

            musteriManager.musteriEkle(musteri1);

            musteriManager.musteriSil(musteri2);




        }
    }
}
