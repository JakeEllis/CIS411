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
    public class PartyTEST
    {
        private PlaylistRepo playlistRepo;
        private PartyRepo partyRepo;

        [TestInitialize]
        public void setup()
        {

            playlistRepo = new PlaylistRepo();
            playlistRepo.add(new Playlist
            {
                Playlist_ID = 123,
                Playlist_Title = "test",
                Song_ID = "asdf1",
                Song_Title = "Bill Brasky",
                Song_Vote = 1,
                Party_ID = 1
            });

            partyRepo = new PartyRepo();
            partyRepo.add(new Party
            {
                Party_ID = 1,
                Playlist = 123,
                Party_Title = "Flying Stringrays",
                Participant_Count = 14,
                Genre_Limitation = "Rock, Rap",
                Repeat_Contraint = 30
            }
            );
        }

        [TestMethod]
        public void partyTEST()
        {
            Party party = partyRepo.getById(new Party
            {
                Party_ID = 1
            }
            );
            Assert.AreNotEqual(null, party, "");

            IQueryable<Party> parties = partyRepo.query(a => a.Party_ID == 1);
            Assert.AreEqual(1, parties.Count());
        }

        [TestCleanup]
        public void clear()
        {
            IQueryable<Party> partys = partyRepo.query(a => a.Party_ID == 1);
            foreach (Party item in partys.ToList<Party>())
            {
                partyRepo.remove(item);
            }

            IQueryable<Playlist> playlists = playlistRepo.query(a => a.Playlist_ID == 123);
            foreach (Playlist item in playlists.ToList<Playlist>())
            {
                playlistRepo.remove(item);
            }
        }
    }
}
