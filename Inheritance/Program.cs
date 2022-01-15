using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                FirstName = "Boğaç",
                LastName = "Han",
                Department = "Yazılım"
            };
            //Person studentPerson1 = new Person();
            Person studentPerson2 = new Student();
            studentPerson2.Id = 2;
            studentPerson2.FirstName = "Simge";
            studentPerson2.LastName = "Işık";

            Person p = new Person();
            p = new Student();
            //((Student)p).Department = "Test";
            (p as Student).Department = "Test";

            // polymorphism
            Person customerPerson1 = new Customer()
            {
                Id = 3,
                FirstName = "Uğur",
                LastName = "Özçelik",
                Address = "Ankara",
            };
            Person studentPerson3 = new Student()
            {
                Id = 4,
                FirstName = "Berk",
                LastName = "Demir",
                Department = "Tasarım"
            };

            Person[] people = new Person[3]
            {
                new Person()
                {
                    Id = 1,
                    FirstName = "Çağıl",
                    LastName = "Alsaç",
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Boğaç",
                    LastName = "Bakkaloğlu",
                    Department = "Yazılım"
                },
                new Customer()
                {
                    Id = 3,
                    FirstName = "Okan",
                    LastName = "Sabitoğulları",
                    Address = "Eryaman Ankara"
                }
            };
            foreach (Person person in people)
            {
                Console.WriteLine("ID: " + person.Id + ", Adı: " + person.FirstName + ", Soyadı : "+ person.LastName);
            }
            Customer customerInPeople = people[2] as Customer;
            Console.WriteLine("ID: " + customerInPeople.Id + ", Adı: " + customerInPeople.FirstName + "," +
                " Soyadı : " + customerInPeople.LastName + ", Address: " + customerInPeople.Address);

            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = "Çağıl",
                Soyadi = "Alsaç",
                Ulke = new Ulke()
                {
                    Id = 1,
                    Adi = "Türkiye"
                },
                Sehri = new Sehir()
                {
                    Id = 1,
                    Adi = "Ankara",
                    UlkeId = 1
                }

            };

            Console.WriteLine($"Adı: {ogrenci.Adi}, Soyadı: {ogrenci.Soyadi}, Ülke: {ogrenci.Ulke.Adi}, Şehri: {ogrenci.Sehri.Adi}");

            Console.ReadLine();

        }
    }

    class Person // base, parent class, concrete(somut)
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : Person // sub, child class, concrete(somut: çünkü newleyebiliyosun)
    {
        public string Department { get; set; }
    }

    class Customer : Person  // c#'da sadece tek bir class üzerinden miras alınabilir.
    {
        public string Address { get; set; }
    }

    class CustomerPayment : Customer // is a relationship
    {
        public string CardNo { get; set; }
    }

    // Is a relationship:

    // Has a relationship:
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Ulke Ulke { get; set; }
        public Sehir Sehri { get; set; }
    }

    class Ulke
    {
        public int Id { get; set; }
        public string Adi { get; set; }

    }

    class Sehir
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int UlkeId { get; set; }
    }


}
