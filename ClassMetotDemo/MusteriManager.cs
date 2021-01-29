using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " nolu musteri eklendi");
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " nolu musteri guncellendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " nolu musteri silindi");
        }
    }
}
