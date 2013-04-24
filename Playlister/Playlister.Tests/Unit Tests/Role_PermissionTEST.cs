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
    public class Role_PermissionTEST
    {
        private Role_PermissionRepo role_permissionRepo;

        [TestInitialize]
        private void setup()
        {
            role_permissionRepo = new Role_PermissionRepo();
            role_permissionRepo.add(new Role_Permission
            {
                Role_Permission_Combo_ID = 2,
                Permission1 = true,
                Permission2 = true,
                PermissionN = 1
            }
            );
        }

        [TestMethod]
        public void role_permissionTEST()
        {
            Role_Permission role = role_permissionRepo.getById(new Role_Permission
            {
                Role_Permission_Combo_ID = 2
            }
         );
            Assert.AreNotEqual(null, role, "");
        }

        [TestCleanup]
        public void clear()
        {
            IQueryable<Role_Permission> rolePermissions = role_permissionRepo.query(a => a.Role_Permission_Combo_ID == 1);
            foreach (Role_Permission item in rolePermissions.ToList<Role_Permission>())
            {
                role_permissionRepo.remove(item);
            }
        }
    }
}

