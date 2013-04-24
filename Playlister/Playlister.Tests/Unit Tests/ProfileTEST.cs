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
    public class ProfileTest
    {
        private SongRepo songrepo;
        private PlaylistRepo playlistrepo;
        private PartyRepo partyrepo;
        private Role_PermissionRepo role_permissionrepo;
        private Person_RoleRepo personrolerepo;
        private ProfileRepo profilerepo;
        private PersonRepo personrepo;

        [TestInitialize]
        public void setup()
        {
            songrepo = new SongRepo();
            songrepo.add(new Song
            {
                Song_ID = 11111,
                HREF = "3240asfsadf92g342",
                Song_Name = "Get on My Level",
                Artist = "Steven",
                Popularity = "High"
            });

            playlistrepo = new PlaylistRepo();
            playlistrepo.add(new Playlist
            {
                Song_ID = "4",
                Playlist_ID = 4,
                Playlist_Title = "mongo",
                Party_ID = 4,
                Song_Vote = 1,
                Song_Title = "Get on My Level"
            });

            partyrepo = new PartyRepo();
            partyrepo.add(new Party
            {
                Party_ID = 4,
                Playlist = 4,
                Party_Title = "TEST",
                Participant_Count = 4,
                Genre_Limitation = "4",
                Repeat_Contraint = 1
            });

            role_permissionrepo = new Role_PermissionRepo();
            role_permissionrepo.add(new Role_Permission
            {
                Role_Permission_Combo_ID = 4,
                Permission1 = true,
                Permission2 = true,
                PermissionN = 4
            });

            personrolerepo = new Person_RoleRepo();
            personrolerepo.add(new Person_Role
            {
                Person_Role_ID = 4,
                Role_Title = "TEST",
                Role_Permission_Combo_ID = 4
            });


            personrepo = new PersonRepo();
            personrepo.add(new Person
            {
                Person_ID = 4,
                Last_Name = "TEST",
                First_Name = "TEST",
                Role_ID = 4,
                User_Name = "TEST",
                Sex = null,
                E_Mail = "TEST@TEST",
                Phone = 1234567891,
                Facebook_Key = null,
                Twitter_Key = null,
                Spotify_Key = null,
                Profile_ID = 4,
                Party_Owner_ID = 4,
                Party_Participant = 4,
                IsActive = true,
                User_Password = "test",
                Security_Question1 = "test",
                Security_Question2 = "testtest",
                Secuirty_Answer1 = "test",
                Security_Answer2 = "testtest"
            });

            profilerepo = new ProfileRepo();
            profilerepo.add(new Profile
            {
                Person_ID = 4,
                Profile_ID = 4,
                Profile_Name = "TEST",
                Profile_Picture = null,
                Bio = "TEST TEST"
            });


        }

        [TestMethod]
        public void Profile_TEST()
        {
             Song song = songrepo.getById(new Song
            {
                Song_ID = 11111
            }
           );
            Assert.AreNotEqual(null, song, "");

            Playlist playlist = playlistrepo.getById(new Playlist
            {
                Playlist_ID = 4
            }
           );
            Assert.AreNotEqual(null, playlist, "");

            Party party = partyrepo.getById(new Party
            {
                Party_ID = 4
            }
            );
            Assert.AreNotEqual(null, party, "");

            Role_Permission role_permission = role_permissionrepo.getById(new Role_Permission
            {
                Role_Permission_Combo_ID = 4
            }
            );
            Assert.AreNotEqual(null, role_permission, "");

            Person_Role person_role = personrolerepo.getById(new Person_Role
            {
                Person_Role_ID = 4
            }
            );
            Assert.AreNotEqual(null, person_role, "");

            Person person = personrepo.getById(new Person
            {
                Person_ID = 4
            }
           );
            Assert.AreNotEqual(null, person, "");

            Profile profile = profilerepo.getById(new Profile
            {
                Profile_ID = 4
            });

           
            IQueryable<Song> songs = songrepo.query(a => a.Song_ID == 11111);
            Assert.AreEqual(1, songs.Count());

            IQueryable<Playlist> playlists = playlistrepo.query(a => a.Playlist_ID == 4);
            Assert.AreEqual(1, playlists.Count());

            IQueryable<Party> parties = partyrepo.query(a => a.Party_ID == 4);
            Assert.AreEqual(1, parties.Count());

            IQueryable<Role_Permission> roles = role_permissionrepo.query(a => a.Role_Permission_Combo_ID == 4);
            Assert.AreEqual(1, roles.Count());

            IQueryable<Person_Role> p_roles = personrolerepo.query(a => a.Person_Role_ID == 4);
            Assert.AreEqual(1, p_roles.Count());

            IQueryable<Person> persons = personrepo.query(a => a.Person_ID == 4);
            Assert.AreEqual(1, persons.Count());

            IQueryable<Profile> profiles = profilerepo.query(a => a.Profile_ID == 4);
            Assert.AreEqual(1, profiles.Count());

        }

        [TestCleanup]
        public void cleanup()
        {
            IQueryable<Song> songs = songrepo.query(a => a.Song_ID == 11111);
            foreach (Song item in songs.ToList<Song>())
            {
                songrepo.remove(item);
            }

            IQueryable<Playlist> playlists = playlistrepo.query(a => a.Playlist_ID == 4);
            foreach (Playlist item in playlists.ToList<Playlist>())
            {
                playlistrepo.remove(item);
            }

            IQueryable<Party> partys = partyrepo.query(a => a.Party_ID == 4);
            foreach (Party item in partys.ToList<Party>())
            {
                partyrepo.remove(item);
            }

            IQueryable<Role_Permission> rolePermissions = role_permissionrepo.query(a => a.Role_Permission_Combo_ID == 4);
            foreach (Role_Permission item in rolePermissions.ToList<Role_Permission>())
            {
                role_permissionrepo.remove(item);
            }

            IQueryable<Person_Role> rolesPermissions = personrolerepo.query(a => a.Person_Role_ID == 4);
            foreach (Person_Role item in rolesPermissions.ToList<Person_Role>())
            {
                personrolerepo.remove(item);
            }

            IQueryable<Person> persons = personrepo.query(a => a.Person_ID == 4);
            foreach (Person item in persons.ToList<Person>())
            {
                personrepo.remove(item);
            }

            IQueryable<Profile> profiles = profilerepo.query(a => a.Profile_ID == 4);
            foreach (Profile item in profiles.ToList<Profile>())
            {
                profilerepo.remove(item);
            }

        }
    }
}
