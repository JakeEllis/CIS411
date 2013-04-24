using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class Role_PermissionRepo : IRepository<Role_Permission>
    {
         private PlaylisterDEV _context = null;

        public Role_PermissionRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Role_Permission getById(Role_Permission playlisterObject)
        {
            return _context.Role_Permissions.Find(playlisterObject.Role_Permission_Combo_ID);
        }

        public Role_Permission[] getAll()
        {
            return _context.Role_Permissions.ToArray();
        }

        public void add(Role_Permission playlisterObject)
        {
            _context.Role_Permissions.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Role_Permission playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();
        }

        public void remove(Role_Permission playlisterObject)
        {
            _context.Role_Permissions.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Role_Permission> query(System.Linq.Expressions.Expression<Func<Role_Permission, bool>> filter)
        {
            return _context.Role_Permissions.Where(filter);
        }
    }
}