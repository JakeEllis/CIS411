using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class Person_RoleRepo : IRepository<Person_Role>
    {
        private PlaylisterDEV _context = null;

        public Person_RoleRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Person_Role getById(Person_Role playlisterObject)
        {
            return _context.Person_Roles.Find(playlisterObject.Person_Role_ID);

        }

        public Person_Role[] getAll()
        {
            return _context.Person_Roles.ToArray();
        }

        public void add(Person_Role playlisterObject)
        {
            _context.Person_Roles.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Person_Role playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Person_Role playlisterObject)
        {
            _context.Person_Roles.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Person_Role> query(System.Linq.Expressions.Expression<Func<Person_Role, bool>> filter)
        {
            return _context.Person_Roles.Where(filter);
        }
    }
}