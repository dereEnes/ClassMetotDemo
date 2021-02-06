using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1,"Enes","Dere",new DateTime(1997,03,16));
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.listele(musteri);
            musteriManager.Sil(musteri);
        }
    }
}
