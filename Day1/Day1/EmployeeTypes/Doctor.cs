using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.EmployeeTypes
{
    internal class Doctor : Employee, IBonus // multilevel inheritance, multiple inheritance
    {
        public int BMDCNumber { get; set; }

        public Doctor(string name, DateOnly dob, string address) : base(name, dob, address)
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
