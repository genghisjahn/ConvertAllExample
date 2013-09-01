using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllExample
{
    public static class PersonGenerator
    {
        public static List<Person> Get()
        {
            List<Person> result = new List<Person>()
            {
                new Person(){ Name="David North", DOB=new DateTime(1980,1,1), HeightInCM=190}
                ,new Person(){ Name="Edward South", DOB=new DateTime(1981,2,3), HeightInCM=194}
                ,new Person(){ Name="Frank West", DOB=new DateTime(1982,3,3), HeightInCM=181}
                ,new Person(){ Name="Greg Eastman", DOB=new DateTime(1983,4,4), HeightInCM=174}
            };
            return result;
        }
    }
}
