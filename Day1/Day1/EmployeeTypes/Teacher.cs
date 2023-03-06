using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.EmployeeTypes
{
    internal class Teacher : Employee, IBonus // multilevel inheritance, multiple inheritance
    {
        public Teacher(string name, DateOnly dob, string address) : base(name, dob, address)
        {
        }

        public double FestivalBonus()
        {
            return BasicSalary;
        }

        public double LeaveEncashment()
        {
            throw new NotImplementedException();
        }
    }
}
