using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class PartyRepo :IRepository<Party>
    {
        private PlaylisterDEV _context = null;

        public PartyRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Party getById(Party playlisterObject)
        {
            return _context.Parties.Find(playlisterObject.Party_ID);

        }

        public Party[] getAll()
        {
            return _context.Parties.ToArray();
        }

        public void add(Party playlisterObject)
        {
            _context.Parties.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Party playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Party playlisterObject)
        {
            _context.Parties.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Party> query(System.Linq.Expressions.Expression<Func<Party, bool>> filter)
        {
            return _context.Parties.Where(filter);
        }
    }
}