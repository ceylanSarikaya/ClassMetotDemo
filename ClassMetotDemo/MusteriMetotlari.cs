using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriMetotlari
    {
        public void Listele (Musteri musteri)
        {
            Console.WriteLine("Eklendi: " +musteri.Adi+ " " +musteri.Soyadi);
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Basarılı Bir Şekilde Eklendi!");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silindi: " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Güncellendi: "  + musteri.Adi + " " + musteri.Soyadi);
        }
        
    }
}
