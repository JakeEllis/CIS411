using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Playlister.dal;

namespace Playlister.dal.Repositories
{
    public class CSCTRepo
    {
        private PlaylisterDEV _context = null;

        public CSCTRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Credential_Source_Code_Table getById(Credential_Source_Code_Table playlisterObject)
        {
            return _context.Credential_Source_Code_Tables.Find(playlisterObject.Credential_Source_Code);

        }

        public Credential_Source_Code_Table[] getAll()
        {
            return _context.Credential_Source_Code_Tables.ToArray();
        }

        public void add(Credential_Source_Code_Table playlisterObject)
        {
            _context.Credential_Source_Code_Tables.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Credential_Source_Code_Table playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Credential_Source_Code_Table playlisterObject)
        {
            _context.Credential_Source_Code_Tables.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Credential_Source_Code_Table> query(System.Linq.Expressions.Expression<Func<Credential_Source_Code_Table, bool>> filter)
        {
            return _context.Credential_Source_Code_Tables.Where(filter);
        }
    }
}