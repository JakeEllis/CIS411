using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class PersonRepo : IRepository<Person>
    {
        private PlaylisterDEV _context = null;

        public PersonRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Person getById(Person playlisterObject)
        {
            return _context.People.Find(playlisterObject.Person_ID);

        }

        public Person[] getAll()
        {
            return _context.People.ToArray();
        }

        public void add(Person playlisterObject)
        {
            _context.People.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Person playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Person playlisterObject)
        {
            _context.People.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Person> query(System.Linq.Expressions.Expression<Func<Person, bool>> filter)
        {
            return _context.People.Where(filter);
        }
    }
}