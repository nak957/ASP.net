using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace lesson2._2.Controllers
{
    public class Pham_The_quyen : Controller
    {
        public class SongController : Controller
        {
            public ActionResult Index()
            {
                string musicFolderPath = @"E:\DJ\house\new track"; 
                string[] musicFiles = Directory.GetFiles(musicFolderPath);

                List<Song> songs = new List<Song>();
                foreach (string file in musicFiles)
                {
                    Song song = new Song
                    {
                        Name = Path.GetFileNameWithoutExtension(file),
                        Url = file
                    };
                    songs.Add(song);
                }

                return View(songs);
            }


            public ActionResult Details(string name)
            {
                
                var song = GetSongDetailsByName(name);
                return View(song);
            }

            public ActionResult Download(string url)
            {
                
                return File(url, "application/mp3", "song.mp3");
            }
            public Song GetSongDetailsByName(string name)
            {
                
                var song = GetAllSongs().FirstOrDefault(s => s.Name == name);
                return song;
            }

            private List<Song> GetAllSongs()
            {

                return new List<Song>
            {
            new Song { Name = "Song 1", Url = "url1", Description = "Description 1" },
            new Song { Name = "Song 2", Url = "url2", Description = "Description 2" },

            };
            }
        }


        
    }
}