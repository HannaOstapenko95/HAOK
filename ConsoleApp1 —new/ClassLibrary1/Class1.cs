using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserClass
    {
        public int age;
        string name;
        public void Display()
        {
            Console.WriteLine($"Name: {name}");
        }
    }
}
