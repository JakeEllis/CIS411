using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class SongRepo : IRepository<Song>
    {
        private PlaylisterDEV _context = null;

        public SongRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Song getById(Song playlisterObject)
        {
            return _context.Songs.Find(playlisterObject.Song_ID);

        }

        public Song[] getAll()
        {
            return _context.Songs.ToArray();
        }

        public void add(Song playlisterObject)
        {
            _context.Songs.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Song playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Song playlisterObject)
        {
            _context.Songs.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Song> query(System.Linq.Expressions.Expression<Func<Song, bool>> filter)
        {
            return _context.Songs.Where(filter);
        }
    }
}