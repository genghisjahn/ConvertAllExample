using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllExample
{
    public static class HumanGenerator
    {
        public static List<Human> Get()
        {
            List<Human> result = new List<Human>() 
                { 
                    new Human { FirstName = "Adam", LastName = "Zellmun", BirthDay = "1/1/1970", HeightInInches = 60 }
                    ,new Human {FirstName = "Bill",LastName="Young",BirthDay="2/2/1972",HeightInInches=70}
                    ,new Human {FirstName="Charles",LastName="Smith",BirthDay="3/1/1973",HeightInInches=80}           
                };
            return result;
        }
    }
}
