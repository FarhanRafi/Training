using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Employee : Person // hierarchical inheritance
    {
        public int EmpId { get; set; }
        public double BasicSalary { get; set; }

        public Employee(string name, DateOnly dob, string address) : base(name, dob, address)
        {

        }
    }
}
