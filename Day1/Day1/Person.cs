using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Person
    {
        public Person(string name, DateOnly dob, string address)
        {
            this.name = name;
            this.dob = dob;
            this.address = address;
        }
        protected string name { get; set; } // encapsulation
        protected DateOnly dob { get; set; } // encapsulation
        protected string address { get; set; } // encapsulation

        public virtual void GetDetails() 
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
        }

    }
}
