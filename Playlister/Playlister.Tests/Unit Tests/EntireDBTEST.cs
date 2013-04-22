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
   public class EntireDBTest 
    {
        private SongRepo songrepo;
        private PlaylistRepo playlistrepo;
        private PartyRepo partyrepo;
        private Role_PermissionRepo role_permissionrepo;
        private Person_RoleRepo personrolerepo;
        private CSCTRepo csctrepo;
        private User_CredentialRepo user_cedentialrepo;
        private ProfileRepo profilerepo;
        private PersonRepo personrepo;

        [TestInitialize]
        public void setup()
        {
            songrepo = new SongRepo();
            songrepo.add(new Song {
                Song_ID = "4",
                Title = "Get on My Level",
                Artist = "Steven",
                Album = "LOLS",
                Genre = "dfsd",
                Album_Art = null,
            });

            playlistrepo = new PlaylistRepo();
            playlistrepo.add(new Playlist{
                Song_ID = "4",
                Playlist_ID = 4,
                Playlist_Title = "mongo",
                Party_ID = 4,
                Song_Vote = 1,
                Song_Title = "Get on My Level"
            });

            partyrepo = new PartyRepo();
            partyrepo.add(new Party { 
                Party_ID = 4,
                Playlist = 4,
                Party_Title = "TEST",
                Participant_Count = 4,
                Genre_Limitation = "4",
                Repeat_Contraint = 1
            });

            role_permissionrepo = new Role_PermissionRepo();
            role_permissionrepo.add(new Role_Permission { 
                Role_Permission_Combo_ID = 4,
                Permission1 = true,
                Permission2 = true,
                PermissionN = 4
            });

            personrolerepo = new Person_RoleRepo();
            personrolerepo.add(new Person_Role{
                Person_Role_ID = 4,
                Role_Title = "TEST",
                Role_Permission_Combo_ID = 4
            });

            csctrepo = new CSCTRepo();
            csctrepo.add(new Credential_Source_Code_Table{
                Credential_Source_Code = 4,
                Credential_Source = "TEST",
                Credential_Description = "TEST TEST"
            });

            user_cedentialrepo = new User_CredentialRepo();
            user_cedentialrepo.add(new User_Credential
            {
                User_Name = "TEST",
                Password = "TEST",
                Security_Question_1 = "TEST",
                Security_Question_2 = "TEST",
                Security_Answer_1 = "Test",
                Security_Answer_2 = "TEST"
            });

            profilerepo = new ProfileRepo();
            profilerepo.add(new Profile{
                Person_ID = 4,
                Profile_ID = 4,
                Profile_Name = "4",
                Profile_Picture = null,
                Bio = "TEST TEST"
            });

            personrepo = new PersonRepo();
            personrepo.add(new Person { 
                Person_ID = 4,
                Last_Name = "TEST",
                First_Name = "TEST",
                Role_ID = 4,
                User_Name = "ENTIRE DB TEST",
                Sex = true,
                E_Mail = "TEST@TEST",
                Phone = 1234567891,
                Facebook_Key = "",
                Twitter_Key = "",
                Spotify_Key = "",
                Profile_ID = 4,
                Party_Owner_ID = 4,
                Party_Participant = 4,
                IsActive = true
            });

        }

        [TestMethod]
        public void PopulatedevDBTEST()
        {


        }

        [TestCleanup]
        public void cleanup()
        {


        }
    }
}
