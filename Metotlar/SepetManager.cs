using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle (Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: "+ urun.Adi);
        }

        //böyle yapmamalıyız  aşağıdaki gibi çünkü programda tek tek bilgi girmek gerektircek ayrıca metotda bir değişiklikte hepsi patlıyor

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);
        }
    }
}
