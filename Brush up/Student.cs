using System;

namespace Brush_up
{
    public class Student : Person
    {

        private int _semester;

        public Student( string name, string address, int semester, Gender gender): base(address,name, gender)
        {
          
            Semester = semester;

        }
       
        public int Semester
        {
            get => _semester; 
            
            set
            {
                if (1 <= value && value <= 8)
                    _semester = value;
                else throw new ArgumentOutOfRangeException("semester", value, "SHIIIT");
            }
        }
    }
}
