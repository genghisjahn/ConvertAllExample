using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllExample
{
    public class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BirthDay { get; set; }
        public Int16 HeightInInches { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1} is {2} inches tall. Born on {3}", this.LastName, this.FirstName, this.HeightInInches, this.BirthDay);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Human h = obj as Human;
            if ((System.Object)h == null) return false;
            if (h.BirthDay != this.BirthDay || h.FirstName != this.FirstName || h.LastName != this.LastName || h.HeightInInches != this.HeightInInches) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return string.Format("{0} {1} {2} {3}", this.FirstName, this.LastName, this.BirthDay, this.HeightInInches).GetHashCode();
        }
    }
}
