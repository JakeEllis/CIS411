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
                Role_Permission_Combo_ID = 1,
                Permission1 = true,
                Permission2 = false,
                PermissionN = 1,
            }
            );
        }

        [TestMethod]
        public void role_permissionTEST()
        {
            Role_Permission role_permission = role_permissionRepo.getById(new Role_Permission
            {
                Role_Permission_Combo_ID = 1
            }
            );
            Assert.AreNotEqual(null, role_permission, "");

            IQueryable<Role_Permission> roles = role_permissionRepo.query(a => a.Role_Permission_Combo_ID == 1);
            Assert.AreEqual(1, roles.Count());
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
