using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public DateTime MusteriYas { get; set; }

        public Musteri(int id,string ad,string soyad,DateTime dogumTarigi)
        {
            MusteriId = id;
            MusteriAd = ad;
            MusteriSoyad = soyad;
            MusteriYas = dogumTarigi;
        }
    }
}
