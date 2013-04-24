using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlister.dal.Repositories;
using Playlister.dal;
namespace Playlister.Tests.Unit_Tests
{
    [TestClass]
    public class PersonTEST
    {

        private PersonRepo personRepo;

        [TestInitialize]
        public void setup()
        {
            personRepo = new PersonRepo();
            personRepo.add(new Person
            {
                Person_ID = 1,
                First_Name = "Jake",
                Last_Name = "Ellis",
                Role_ID = 1,
                User_Name = "McLovin",
                E_Mail = "jmelli12@gmail.com",
                Phone = 1111, //phone number should probably be a long not an int
                Facebook_Key = "FB",
                Twitter_Key = "TW",
                Profile_ID = 12345,
                Party_Owner_ID = 918,
                Party_Participant = 1,
                IsActive = true,
                User_Password = "test",
                Security_Question1 = "Favorite Color?",
                Secuirty_Answer1 = "red",
                Security_Question2 = "Hometown?",
                Security_Answer2 = "Louisville",

            }
            );

            personRepo = new PersonRepo();
            personRepo.add(new Person
            {
                Person_ID = 2,
                First_Name = "J",
                Last_Name = "E",
                Role_ID = 2,
                User_Name = "McMuffin",
                E_Mail = "jmelli12@web.com",
                Phone = 2222, //phone number should probably be a long not an int
                Facebook_Key = "Face",
                Twitter_Key = "Twit",
                Profile_ID = 678910,
                Party_Owner_ID = 500,
                Party_Participant = 2,
                User_Password = "readonly",
                Security_Question1 = "Favorite Color?",
                Secuirty_Answer1 = "blue",
                Security_Question2 = "Hometown?",
                Security_Answer2 = "Lexington",
            }
            );

        }

        [TestMethod]
        public void personTEST()
        {
            Person person = personRepo.getById(new Person
            {
                Person_ID = 1
            }
            );
            Assert.AreNotEqual(null, person, "");

            IQueryable<Person> persons = personRepo.query(a => a.Person_ID == 1);
            Assert.AreEqual(2, persons.Count());
        }

        [TestCleanup]
        public void clear()
        {
            IQueryable<Person> persons = personRepo.query(a => a.Person_ID == 1);
            foreach (Person item in persons.ToList<Person>())
            {
                personRepo.remove(item);
            }
        }
    }
}

