using System;

namespace Apstract_Class_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nyobain Abstract Bersama Mahasiswa AMIKOM");
            Person[] persons = new Person[3];
            persons[0] = new Employee("Faat");
            persons[1] = new Employee("Dhendy");
            persons[2] = new Contractor("Zidan");

            foreach (Person p in persons)
            {
                p.promote(15);
            }
        }
    }
    public class Employee : Person
    {

        public Employee(String name) : base(name) { }


        public override Boolean Point(int percent)
        {
            Console.WriteLine($"Mendapat poin keaktifan sebesar {percent} % " + getName());
            return true;


        }
    }
    public class Contractor : Person
    {

        public Contractor(String name) : base(name) { }

        public override Boolean Point(int percent)
        {
            if (percent > 5)
            {
                Console.WriteLine($"Tidak mendapat poin keaktifan karena jawaban salah : " + getName());
                return false;
            }
            else
            {
                Console.WriteLine($"Tidak mendapat poin keaktifan karena jawaban salah : " + getName());
                return true;
            }
        }

    }

}