using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playlister.dal.Repositories
{
    public class PlaylistRepo : IRepository<Playlist>
    {
        private PlaylisterDEV _context = null;

        public PlaylistRepo()
        {
            _context = new PlaylisterDEV();
        }

        public Playlist getById(Playlist playlisterObject)
        {
            return _context.Playlists.Find(playlisterObject.Playlist_ID);

        }

        public Playlist[] getAll()
        {
            return _context.Playlists.ToArray();
        }

        public void add(Playlist playlisterObject)
        {
            _context.Playlists.Add(playlisterObject);
            _context.SaveChanges();
        }

        public void update(Playlist playlisterObject)
        {
            _context.Entry(playlisterObject).State = System.Data.EntityState.Modified;
            _context.SaveChanges();

        }

        public void remove(Playlist playlisterObject)
        {
            _context.Playlists.Remove(playlisterObject);
            _context.SaveChanges();
        }

        public IQueryable<Playlist> query(System.Linq.Expressions.Expression<Func<Playlist, bool>> filter)
        {
            return _context.Playlists.Where(filter);
        }
    }
}