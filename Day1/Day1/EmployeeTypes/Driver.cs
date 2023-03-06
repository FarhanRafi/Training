using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.EmployeeTypes
{
    internal class Driver : Employee, IBonus // multilevel inheritance, multiple inheritance
    {
        public Driver(string name, DateOnly dob, string address) : base(name, dob, address)
        {
        }

        public string DrivingLicense { get; set; }

        public double FestivalBonus()
        {
            return 1.2 * BasicSalary;
        }

        public double LeaveEncashment()
        {
            throw new NotImplementedException();
        }
    }
}
