using System;
using System.Collections.Generic; //for Lists
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAOK_1
{
    //Inheritance

    public class Animal1
        {
            public string Name { get; set; } 
            private string Name1 { get; set; } //Has no acces from other classes BY DEFAULT
            protected string Name2 { get; set; } //Has access only from this class or наследников
        //Constructor
        public Animal1(string name)
        {
            Name = name;
        }
        //Virtual Method
        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
        }




    public class Dog : Animal1
        {
        public float speed;
        //Constructor
        public Dog (float speed, string name) : base (name) //we use basic constructor -place name in basic constructor
        {
            this.speed = speed;
            //Console.WriteLine("Speed" + speed);
        }
        // Method of наследник has access to protected variable
         void test()
            {
                Console.WriteLine(Name2.GetType());
            }
        //Virtual Method переопределение - method which can be reinitiated in inherited class from main class
        public override void Print()
        {
            base.Print(); //copy all lines from this method from base class
            Console.WriteLine("Dog Speed" + speed); //Name will not be shown if no base.Print();
        }
    }

    public class Cat : Animal1
    {
        public float speed;
        //Constructor
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
            //Console.WriteLine("Speed" + speed);
        }
        public override void Print()
        {
            base.Print(); //copy all lines from this method from base class
            Console.WriteLine("Cat Speed" + speed); //Name will not be shown if no base.Print();
        }
    }


    }


