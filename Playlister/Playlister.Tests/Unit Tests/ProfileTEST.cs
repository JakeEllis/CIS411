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
    public class ProfileTEST
    {
        private ProfileRepo profileRepo;
    
    [TestInitialize]
        public void setup()
    {
        profileRepo = new ProfileRepo();
        profileRepo.add(new Profile
        {
            Person_ID = 1,
            Profile_ID = 12345,
            Profile_Name = "McLovinProfile",
            Profile_Picture = null,
            Bio = "I'm here to love on you good!"
        }
        );
    }

        [TestMethod]
        public void ProfileTESTMethod()
        {
            Profile profile = profileRepo.getById(new Profile
            {
                Profile_ID = 1
            }
            );
            Assert.AreNotEqual(null, profile, "");

            IQueryable<Profile> profiles = profileRepo.query(a => a.Profile_ID == 1);
            Assert.AreEqual(1, profiles.Count());
        }

        [TestCleanup]
        public void clear()
        {
            IQueryable<Profile> profiles = profileRepo.query(a => a.Profile_ID == 1);
            foreach (Profile item in profiles.ToList<Profile>())
            {
                profileRepo.remove(item);
            }
        }
    }
}
