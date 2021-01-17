using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.name = "Sena";
            musteri1.surname = "Erdoğan";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.name = "Batuhan";
            musteri2.surname = "Hasanoğlu";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.name = "Mervenur";
            musteri3.surname = "Yıldırım";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteriler);

            musteriManager.Silme(musteri1);

            Console.ReadLine();

        }
    }
}
