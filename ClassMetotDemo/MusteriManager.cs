using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            TimeSpan span = DateTime.Now.Date.Subtract(musteri.MusteriYas);
            int yas = Convert.ToInt32(span.TotalDays);
            Console.WriteLine("Musteri veri tabanına eklendi.Musteri yaşı :"+yas/365);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri veri tabanınadan silindi");
        }
        public void listele(Musteri musteri)
        {
            Console.WriteLine("Musteriler listelendi");
        }
    }
}
