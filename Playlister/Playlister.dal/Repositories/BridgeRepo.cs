using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Playlister.dal.Repositories
{
    public class BridgeRepo : IRepository<Bridge_Combo_ID>
    {
        private PlaylisterDEV _context = null;

        public BridgeRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Bridge_Combo_ID getById(Bridge_Combo_ID playlisterObject)
        {
            return _context.Bridge_Combo_ID.Find(playlisterObject.Bridge_Combo_ID1);
        }

        public Bridge_Combo_ID[] getAll()
        {
            return _context.Bridge_Combo_ID.ToArray();
        }

        public void add(Bridge_Combo_ID playlisterObject)
        {
            _context.Bridge_Combo_ID.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Bridge_Combo_ID playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();
        }

        public void remove(Bridge_Combo_ID playlisterObject)
        {
            _context.Bridge_Combo_ID.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Bridge_Combo_ID> query(System.Linq.Expressions.Expression<Func<Bridge_Combo_ID, bool>> filter)
        {
            return _context.Bridge_Combo_ID.Where(filter);
        }
    }
}
