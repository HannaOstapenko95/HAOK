using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAOK_2
{
    abstract class Animal2
    {
        //  public abstract string Name1 { get; set; }
        //internal -> we can use this variable in every place in the current PROJECT
        //protected internal - combines the properties 
        public string Name1 { get; set; }
        public Animal2 (string name1)
        {
            Name1 = name1;
        }
        //Abstract Method
        public abstract void Print3();
        private class Animalnew //private - for вложенный класс
        {
            private string password;
        }

    }

    class Cat2 : Animal2 //inherited class can be in another project //internal by default internal class
    { //no private class, but public class. public or internal class - directly in namespace
      //  public override string Name1
       // {
            //get { }
       //     set { }
       // }
        public float speed;
        public Cat2(float speed, string name1) : base(name1)
        {
            this.speed = speed;
        }

        public override void Print3()
        {
            
            Console.WriteLine("\nAbstract Cat_3 Speed" + speed); //Name will not be shown if no base.Print();
        }
    }
    abstract class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class Client : Person
    {
        public int Sum { get; set; }    // сумма на счету

        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }
    }

    class Employee : Person
    {
        public string Position { get; set; } // должность

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
    }
}

