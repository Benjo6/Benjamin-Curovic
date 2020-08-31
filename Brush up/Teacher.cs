using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up
{

    public class Teacher : Person
    {
        private int _salary;

        public Teacher(string name, string address, int salary, Gender gender) : base(address, name, gender)
        {

            Salary = salary;

        }

        public int Salary
        {
            get => _salary; set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("LOOOOOL");
                _salary = value;
            }
        }

    }
}
