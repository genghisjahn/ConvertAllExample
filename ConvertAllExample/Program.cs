using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAllExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = HumanGenerator.Get();
            List<Person> persons = PersonGenerator.Get();
            var humansfrompersons= new List<Human>();

            humansfrompersons = persons.ConvertAll(p => new Human 
            { 
                FirstName = p.Name.Split(' ').FirstOrDefault()
                , LastName = p.Name.Split(' ').LastOrDefault()
                , BirthDay = p.DOB.ToShortDateString()
                , HeightInInches = (short)((Double)p.HeightInCM * 0.393701) 
            });

            var HfromP2 = persons.ConvertAll(p => Converters.PeopleConverter(p));

            var PfromH2 = humans.ConvertAll(p => Converters.PeopleConverter(p));
            
            var human = humans.First();
            var person = persons.First();

            var h2 = Converters.PeopleConverter(person);
            var p2 = Converters.PeopleConverter(human);

  

            persons.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("----");

            humansfrompersons.ForEach(nh => Console.WriteLine(nh.ToString()));
            Console.ReadKey();
        }

        
    }
}
