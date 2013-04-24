using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class Song_StoreRepo : IRepository<Song_Store>
    {
         private PlaylisterDEV _context = null;

        public Song_StoreRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Song_Store getById(Song_Store playlisterObject)
        {
            return _context.Song_Store.Find(playlisterObject.HREF);

        }

        public Song_Store[] getAll()
        {
            return _context.Song_Store.ToArray();
        }

        public void add(Song_Store playlisterObject)
        {
            _context.Song_Store.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Song_Store playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Song_Store playlisterObject)
        {
            _context.Song_Store.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Song_Store> query(System.Linq.Expressions.Expression<Func<Song_Store, bool>> filter)
        {
            return _context.Song_Store.Where(filter);
        }
    }
}