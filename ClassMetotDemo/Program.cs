using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Oğuzhan";
            musteri1.MusteriSoyadi = "Yazar";
            musteri1.MusteriMeslegi = "Öğrenci";
            musteri1.MusteriYasi = 22;


            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Enes";
            musteri2.MusteriSoyadi = "Yiğit";
            musteri2.MusteriMeslegi = "Mühendis";
            musteri2.MusteriYasi = 25;


            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Batuhan";
            musteri3.MusteriSoyadi = "Gültekin";
            musteri3.MusteriMeslegi = "Cam Ustası";
            musteri3.MusteriYasi = 24;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteriler);
           
                

        }
    }
}
