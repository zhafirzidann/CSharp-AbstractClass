using System;

namespace Apstract_Class_Interface
{

    public abstract class Person
    {

        private String name;
        private String adress;


        public Person(String name)
        {
            this.name = name;

        }
        public String getName()
        {
            return this.name;
        }
        public String changeAdress(String adress)
        {
            return this.adress = adress;
        }
        public void PoinActive()
        {
            Console.WriteLine("Poin keaktifan dua kali lipat diberikan kepada " + this.name);
        }
        public void promote(int percentage)
        {
            Console.WriteLine("Mahasiswa yang mendapat poin keaktifan " + this.name);
            PoinActive();
            Point(percentage);//coling abstract method that not yet implemented
        }
        public abstract Boolean Point(int percent);//we define abstract method

    }

}