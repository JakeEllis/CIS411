using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playlister.dal.Repositories;
using Playlister.dal;

namespace Playlister.Tests.Unit_Tests
{
    [TestClass]
    public class PlaylistTEST
    {
        private PlaylistRepo playlistRepo;

        [TestInitialize]
        public void setup()
        {
            playlistRepo = new PlaylistRepo();
            playlistRepo.add(new Playlist
            {
                Playlist_ID = 1,
                Playlist_Title = "Max's Mix",
                Song_ID = "1",
                Song_Title = "Do Dat Ting Right Durr",
                Song_Vote = 1,
                Party_ID = 1
            }
            );
        }

        [TestMethod]
        public void playlistTEST()
        {
            Playlist playlist = playlistRepo.getById(new Playlist
            {
                Playlist_ID = 1
            }
            );
            Assert.AreNotEqual(null, playlist, "");

            IQueryable<Playlist> playlists = playlistRepo.query(a => a.Playlist_ID == 1);
            Assert.AreEqual(1, playlists.Count());
        }

        [TestCleanup]
        public void clear()
        {
            IQueryable<Playlist> playlists = playlistRepo.query(a => a.Playlist_ID == 1);
            foreach (Playlist item in playlists.ToList<Playlist>())
            {
                playlistRepo.remove(item);
            }
        }
    }
}
