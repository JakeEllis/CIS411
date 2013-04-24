using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class ProfileRepo : IRepository<Profile>
    {
        private PlaylisterDEV _context = null;

        public ProfileRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Profile getById(Profile playlisterObject)
        {
            return _context.Profiles.Find(playlisterObject.Profile_ID);
        }

        public Profile[] getAll()
        {
            return _context.Profiles.ToArray();
        }

        public void add(Profile playlisterObject)
        {
            _context.Profiles.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Profile playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Profile playlisterObject)
        {
            _context.Profiles.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Profile> query(System.Linq.Expressions.Expression<Func<Profile, bool>> filter)
        {
            return _context.Profiles.Where(filter);
        }
    }
}