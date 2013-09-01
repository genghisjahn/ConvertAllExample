using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllExample
{
    public static class Converters
    {
        public static dynamic PeopleConverter(dynamic sourceobject)
        {
            if (sourceobject.GetType().Name == "Person")
            {
                return ConvertFromPersonToHuman(sourceobject);
            }
            if (sourceobject.GetType().Name == "Human")
            {
                return ConvertFromHumanToPersion(sourceobject);
            }

            throw new Exception("Bang!  Pow!  You submitted the wrong type!");
        }
        private static Human ConvertFromPersonToHuman(Person person)
        {
            Human result = new Human();
            string[] parts = person.Name.Split(' ');
            result.BirthDay = person.DOB.ToShortDateString();
            result.FirstName = parts[0];
            result.LastName = parts[1];
            result.HeightInInches = (short)((Double)person.HeightInCM * 0.393701);
            return result;
        }
        private static Person ConvertFromHumanToPersion(Human human)
        {
            Person result = new Person();
            result.DOB = DateTime.Parse(human.BirthDay);
            result.HeightInCM = (int)((Double)human.HeightInInches * 2.54);
            result.Name = string.Format("{0} {1}", human.FirstName, human.LastName);
            return result;
        }
    }
}
