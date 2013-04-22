using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlister.dal;
using Playlister.dal.Repositories;

namespace Playlister.Tests.Unit_Tests
{
    [TestClass]
    public class CSCT_Test
    {
        private CSCTRepo csctRepo;

        [TestInitialize]
        public void setup()
        {
            csctRepo = new CSCTRepo();
            csctRepo.add(new Credential_Source_Code_Table
            {
                Credential_Source_Code = 12345,
                Credential_Source = "Credential source text",
                Credential_Description = "Credential Description Test Text"
            }
            );
        }

        [TestMethod]
        public void csct_TEST()
        {
            Credential_Source_Code_Table csct = csctRepo.getById(new Credential_Source_Code_Table
            {
                Credential_Source_Code = 12345
            }
            );

            Assert.AreNotEqual(null, csct, "");

            IQueryable<Credential_Source_Code_Table> cscts = csctRepo.query(a => a.Credential_Source_Code == 12345);
            Assert.AreEqual(1, cscts.Count());
        }

        [TestCleanup]
        public void clear()
        {
            IQueryable<Credential_Source_Code_Table> playlists = csctRepo.query(a => a.Credential_Source_Code == 12345);
            foreach (Credential_Source_Code_Table item in playlists.ToList<Credential_Source_Code_Table>())
            {
                csctRepo.remove(item);
            }
        }
    }
}

