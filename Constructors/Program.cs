using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şimdiye kadar böyle yazıyorduk *Default Constructor da parametre verilmedi Dikkat!
            Customer customer1 = new Customer();
            customer1.Id = 3;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.City = "Ankara";

            //Böyle de yazılır aynı şey *Default Constructor iken bu da parametreli girildi. 
            //Customerdan sonra ()olsa da olur olmasa da 
            Customer customer2 = new Customer { Id = 2, FirstName = "Derin", LastName = "Demiroğ", City = "Ankara" };
            Console.WriteLine(customer2.FirstName);

            //Parametreyi Constructor da verecek olursam Metot mantığı gibi yazarım.
            Customer customer3 = new Customer(1, "Ayse", "Ta", "Antalya");
            Console.WriteLine(customer3.FirstName);
        }

        class Customer
        {
            //default constructor parametresiz constructordır. blok içine yazdığım komutu her defaultconstructora bağlı customer için tekrarlar
            public Customer()
            {
                
            }

            //sadece bunu yazarsam default constructora göre yazılanları ezer. Çözüm overloading yapıp tekrar default constructor da eklemek
            public Customer(int id, string firstName, string lastName, string city) //metot parametreleri camelCase yazılır
            {
                Id = id;   //bu şekilde yazmazsam yukarıda yazdır da desem çıktı vermez
                FirstName = firstName;
                LastName = lastName;
                City = city;
            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}