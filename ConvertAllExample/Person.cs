using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllExample
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int HeightInCM { get; set; }
        public override string ToString()
        {
            return string.Format("{0} is {1} cm tall.  Born on {2}", this.Name, this.HeightInCM, this.DOB.ToShortDateString());
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Person p = obj as Person;
            if ((System.Object)p == null) return false;
            if (p.DOB != this.DOB || p.HeightInCM != this.HeightInCM || p.Name != this.Name) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return string.Format("{0} {1} {2}", this.Name, this.DOB,this.HeightInCM).GetHashCode();
        }
    }
}
