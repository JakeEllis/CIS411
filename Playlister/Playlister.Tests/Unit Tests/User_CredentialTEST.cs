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
    public class User_CredentialTEST
    {
        private User_CredentialRepo credentialRepo;

        [TestInitialize]
        public void setup()
        {
            credentialRepo = new User_CredentialRepo();
            credentialRepo.add(new User_Credential
            {
                User_Name = "TEST"
            }
            );

        }

        [TestMethod]
        public void user_credentialTEST()
        {
            User_Credential user = credentialRepo.getById(new User_Credential
            {
                User_Name = "TEST"
            }
            );

            Assert.AreNotEqual(null, user, "");

            IQueryable<User_Credential> users = credentialRepo.query(a => a.User_Name == "TEST");
            Assert.AreEqual(1, users.Count());
        }
    }
}
