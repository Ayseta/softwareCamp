using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3); 
            // bu statik programlama yani mecburen her değişkeni tek tek çağırıp her değişikliği tek tek uygulamak gerekir.istemeyiz.

            
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java" };
            // gerçek hayatta bu bilgi bir veri kaynağından geliyor ve biz sadece atıyorum kurslarıGetir(); yazıyoruz.Dinamikolan. 

            for (int i = 0; kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu-footer");
        }
    }
}
