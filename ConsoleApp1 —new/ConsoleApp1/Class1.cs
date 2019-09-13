using System;
using System.Collections.Generic; //for Lists
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAOK_2
{
    abstract class Animal2
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
        public abstract void Print2()
        {
            Console.WriteLine(Name);
        }
    }
}
