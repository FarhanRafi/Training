using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Student : Person // single inheritance // hierarchical inheritance
    {
        public int studentId { get; set; }

        public Student(int studentId, string name, DateOnly dob, string address) : base(name, dob, address)
        {
            this.studentId = studentId;
        }

        public override void GetDetails() // Method overriding // Polymorphism
        {
            Console.WriteLine($"Student ID: {studentId}");
            base.GetDetails();
        }

    }
}
