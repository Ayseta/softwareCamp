using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            var result=Add2(20, 30);
               //burada var yerine direkt veri tipi olan int de yazabilirdik //var ne atarsak onu alır
            int result2 = Add3(4);
            int num1 = 7;
            int num2 = 3;
            var result3 = Add4(ref num1, num2); //burada ref keywordu değer tipi ref tip gibi çalışmasını sağladı.
                        //bellekte 2 değişken tanımlamak yerine tamamen num1 referansı kullan demiş olduk
                            
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(num1); //ref int demeseydim 7 yazacaktı methoda girmicekti
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,5));
            Console.WriteLine(Add5(1, 2, 3, 4, 5, 6));
            Console.WriteLine(Add6(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }
        static void Add() 
            //void git şunu yap demek
        {
            Console.WriteLine("Added!!");
        }

        static int Add2 (int number1, int number2) 
            // burada döndürmek istediğim bir sayı oyüzden void yerine int yazdık
        {
            var result = number1 + number2;
            return result;
          //parametreli veri döndüren method  
        }
        static int Add3 (int x, int y = 10, int z = 5)
        {
            var result2 = x + y + z;
            return result2;
            //default parametreli method.değer verilmezse varsayılanı kullan demek 
            //mesela Kdv hesaplama değer verilmezse %18 al gibi
            //hepsine birden default değer verebilirsin ama sondan başlanır atamaya
        }

        static int Add4 (ref int num1, int num2) 
                       //methodda değer tipinin ref olarak da değişebileceğini düşünüyorsak ref kullanırız
        // alternatifi out keywordudür ref yerine out yazılır.
        //Farkı out da değeri set etmek zorunluluğu yok ama ref de değişkene illa değer atamak gerekir
        {
            num1 = 10;
            return num1 + num2;
        }

        static int Multiply (int num1, int num2) //Methodun imzası, en temel hali
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2, int num3) 
            //aynı method ismi kullanarak farklı parametreler kullanılıyor ise method overloading metodun asırı yüklenmesi
        {
            return num1 * num2*num3;
        }
        static int Add5 (params int[] numbers )  //istedigim kadar parametre yollayabilirim params keyword ile
        {
            return numbers.Sum(); //hazır method tüm sayıları topla demek
        }
        static int Add6(int number1, params int[] numbers)  //params son parametre olmalı, önünde yazabiliriz baştan sırayla atar
        {
            return numbers.Sum(); //sadece numbers için komut tanımlı
        }
    }
}
