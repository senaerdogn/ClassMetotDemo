using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.name + " " + musteri.surname + " eklendi...");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("**************MÜŞTERİLER**************");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.name + " " + musteri.surname);
                Console.WriteLine("************************");
            }
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.name + " " + musteri.surname + " silindi...");
        }
    }
}
