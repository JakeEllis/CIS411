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
    public class Person_RoleTEST
    {
        private Role_PermissionRepo roleRepo;
        private Person_RoleRepo person_roleRepo;

        [TestInitialize]
        public void setup()
        {

            roleRepo = new Role_PermissionRepo();
            roleRepo.add(new Role_Permission
            {
                Role_Permission_Combo_ID = 1,
                Permission1 = true,
                Permission2 = true,
                PermissionN = 1
            });


            person_roleRepo = new Person_RoleRepo();
            person_roleRepo.add(new Person_Role
            {
                Person_Role_ID = 1,
                Role_Title = "Host",
                Role_Permission_Combo_ID = 1,
            }
            );
        }


        [TestMethod]
        public void person_roleTEST()
        {
            Person_Role person_role = person_roleRepo.getById(new Person_Role
            {
                Person_Role_ID = 1
            }
            );
            Assert.AreNotEqual(null, person_role, "");

            IQueryable<Person_Role> p_roles = person_roleRepo.query(a => a.Person_Role_ID == 1);
            Assert.AreEqual(1, p_roles.Count());
        }

        [TestInitialize]
        public void clear()
        {
            IQueryable<Person_Role> rolesPermissions = person_roleRepo.query(a => a.Person_Role_ID == 1);
            foreach (Person_Role item in rolesPermissions.ToList<Person_Role>())
            {
                person_roleRepo.remove(item);
            }

            IQueryable<Role_Permission> rolePermissions = roleRepo.query(a => a.Role_Permission_Combo_ID == 1);
            foreach (Role_Permission item in rolePermissions.ToList<Role_Permission>())
            {
                roleRepo.remove(item);
            }
        }
    }
}
