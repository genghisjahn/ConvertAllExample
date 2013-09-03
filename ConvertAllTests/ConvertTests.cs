using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertAllExample;
using Microsoft.CSharp;
namespace ConvertAllTests
{
    [TestClass]
    public class ConvertTests
    {
        [TestMethod]
        public void Convert_Person_To_Human_Equals_Human_Test()
        {
            Human human1 = new Human() { BirthDay = @"4/5/1980", FirstName = "Han", LastName = "Solo", HeightInInches =(short)74 };
            var person = new Person() { DOB = new DateTime(1980, 4, 5), Name = "Han Solo", HeightInCM =(int)188 };
            Human human2 = Converters.PeopleConverter(person);
            Assert.AreEqual(human1, human2);         
        }

        [TestMethod]
        public void Convert_Human_To_Person_Equals_Person_Test()
        {
            Person person1 = new Person() { DOB = new DateTime(1977, 5, 5), Name = "John Jones", HeightInCM = (int)187.96 };
            var human = new Human() { BirthDay = "5/5/1977", FirstName = "John", LastName = "Jones", HeightInInches = 74 };
            Person person2 = Converters.PeopleConverter(human);
            Assert.AreEqual(person1, person2);
        }

        [TestMethod]
        public void Convert_Human_List_To_Person_List_Test()
        {
            var humans = HumanGenerator.Get();
            var persons = humans.ConvertAll(h => Converters.PeopleConverter(h));
            Assert.IsTrue(humans.Count == persons.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
        "There should have been an exception thrown.")]
        public void Invalid_Test_Passed_To_Converter_Test()
        {
            int invalid=5;
            var human = Converters.PeopleConverter(invalid);
        }
    }
}
