using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up
{
    public enum Gender
    {
        Male, Female
    }
    public class Person
    {
        private string _name;
        private string _address;
        

        public Person(string address, string name, Gender gender)
        {
            Gender = gender;
            Address = address;
            Name = name;
        }

        public string Name
        {
            get => _name; set
            {
                if (value == null) throw new ArgumentNullException("Why are you making me mad");
                if (value.Length < 2) throw new ArgumentException("STUPID");

                _name = value;
            }
        }
        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentNullException("Fuck");
                _address = value;
            }
        }
        public Gender Gender { get; set; }

    }
}
