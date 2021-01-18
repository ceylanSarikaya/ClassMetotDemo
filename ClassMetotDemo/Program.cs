using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Iletisim = 05378922;
            musteri1.Adres = "Erzurum";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Gul";
            musteri2.Iletisim = 05378922;
            musteri2.Adres = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Sinan";
            musteri3.Soyadi = "Kara";
            musteri3.Iletisim = 05378922;
            musteri3.Adres = "Aksaray";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Ayşe";
            musteri4.Soyadi = "Gül";
            musteri4.Iletisim = 05378922;
            musteri4.Adres = "Izmır";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4 };

            foreach (Musteri abc in musteriler)
            {
                Console.WriteLine(abc.Id);
                Console.WriteLine(abc.Adi);
                Console.WriteLine(abc.Soyadi);
                Console.WriteLine(abc.Iletisim);
                Console.WriteLine(abc.Adres);
                Console.WriteLine("------------------");

            }

            MusteriMetotlari musteriMetotlari = new MusteriMetotlari();
            musteriMetotlari.Ekle(musteri1);
            musteriMetotlari.Ekle(musteri2);
            musteriMetotlari.Ekle(musteri3);
            musteriMetotlari.Ekle(musteri4);
            Console.WriteLine("...............");
            musteriMetotlari.Listele(musteri1);
            musteriMetotlari.Listele(musteri2);
            musteriMetotlari.Listele(musteri3);
            musteriMetotlari.Listele(musteri4);
            Console.WriteLine("................");
            musteriMetotlari.Sil(musteri1);
            Console.WriteLine("................");
            musteriMetotlari.Guncelle(musteri1);
            musteriMetotlari.Guncelle(musteri2);
            musteriMetotlari.Guncelle(musteri3);
            musteriMetotlari.Guncelle(musteri4);

        }
    }
}
