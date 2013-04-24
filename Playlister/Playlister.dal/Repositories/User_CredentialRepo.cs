using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class User_CredentialRepo : IRepository<User_Credential>
    {
        PlaylisterDEV _context;
        
        public void User_Credential()
        {
            _context = new PlaylisterDEV();
        }

        public User_Credential getById(User_Credential playlisterObject)
        {
            return _context.User_Credentials.Find(playlisterObject.User_Name);
        }

        public User_Credential[] getAll()
        {
            return _context.User_Credentials.ToArray(); 
        }

        public void add(User_Credential playlisterObject)
        {
            _context.User_Credentials.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(User_Credential playlisterObject)
        {
            _context.User_Credentials.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void remove(User_Credential playlisterObject)
        {
            _context.User_Credentials.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<User_Credential> query(System.Linq.Expressions.Expression<Func<User_Credential, bool>> filter)
        {
            return _context.User_Credentials.Where(filter);
        }
    }
}