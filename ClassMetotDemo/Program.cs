using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri { Id = 1, Ad = "Anıl", Soyad = "Nüyükaşık", DogumYeri = "Hatay" };
            Musteri musteri2 = new Musteri { Id = 2, Ad = "Nurnilay", Soyad = "Pınar", DogumYeri = "Trabzon" };
            Musteri musteri3 = new Musteri { Id = 3, Ad = "Sansa", Soyad = "Büyükaşık", DogumYeri = "Hatay" };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Guncelle(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
