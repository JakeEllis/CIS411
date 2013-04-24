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
    public class SongTEST
    {
    
        private SongRepo songRepo;

        [TestInitialize]
        public void setup()
        {
            songRepo = new SongRepo();
            songRepo.add(new Song
            {
                Song_ID = "3",
                Title = "hello",
                Artist = "Kissha",
                Album = "Not Kesha",
                Genre = "HipHop",
                Album_Art = null
            }
            );
        }

        
        [TestMethod]
        public void songTEST()
        {
            Song song = songRepo.getById(new Song
            {
                Song_ID = "3"
            }
            );
            Assert.AreNotEqual(null, song, "");

            IQueryable<Song> songs = songRepo.query(a => a.Song_ID == "3");
            Assert.AreEqual(1, songs.Count());
        }

        [TestCleanup]
        public void clear()
        {
            IQueryable<Song> songs = songRepo.query(a => a.Song_ID == "3");
            foreach (Song item in songs.ToList<Song>())
            {
                songRepo.remove(item);
            }
        }
    }
}
