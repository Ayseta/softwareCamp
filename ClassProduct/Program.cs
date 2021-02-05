using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] kategori = new string[] { "Yazlık", " ", "Kışlık", " " };
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(kategori[i]);
                }
                Console.WriteLine("İndirimdekiler");

                Urun urun1 = new Urun();
                urun1.UrunAdi = "Palto";
                urun1.indirim = 30;
                urun1.fiyat = 350.99;

                Urun urun2 = new Urun();
                urun2.UrunAdi = "Etek";
                urun2.indirim = 50;
                urun2.fiyat = 188.99;

                Urun[] urunler = new Urun[] { urun1, urun2 };

                foreach (var urun in urunler)
                {
                    Console.WriteLine(urun.UrunAdi + " %" + urun.indirim + " " + urun.fiyat + "TL");
                }
                Console.WriteLine("xxxxxxxxx");
                


                int sayac = 0;
                int[] tumUrunler = new int[2];
               
                Console.WriteLine("Tüm Ürünler");
               
                while (sayac<tumUrunler.Length)
                {
                    sayac++;
                    Console.WriteLine("Sepete Ekle");
                }      

            }
        }

        class Urun
        {
            public string UrunAdi { get; set; }
            public int indirim { get; set; }
            public double fiyat { get; set; }
       

        }


    }
}

