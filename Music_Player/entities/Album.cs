using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Music_Player.entities
{
    internal class Album
    {
        public Album(string title, Artist artist, DateTime yearReleace, int numberOfSongs)
        {
            Id = Guid.NewGuid();
            Title = title;
            Artist = artist;
            YearReleace = yearReleace;
            NumberOfSongs = numberOfSongs;
            Songs = new List<Song>();
            SongOrder = new Dictionary<int, Guid>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public DateTime YearReleace { get; set; }
        public ICollection<Song> Songs { get; set; }
        public IDictionary<int, Guid> SongOrder { get; set; }
        public int NumberOfSongs { get; set; }
        public TimeSpan Duration { get; set; }


        private bool IsOrderInUse(int order)
        {
            // todo
            return false;
        }
        private void MoveSongsDown(int order)
        {
            // todo
        }

        private void CalculateAlbumDuration()
        {
            TimeSpan duration = new TimeSpan();

            // calculate

            Duration = duration;
        }

        public void AddSong(Song song, int order)
        {
            if (Songs.Count() == NumberOfSongs)
            {
                throw new InvalidOperationException("Album reached max number of songs.");
            }

            if (order > NumberOfSongs || order < 1)
            {
                throw new ArgumentException(nameof(order));
            }

            if (IsOrderInUse(order))
            {
                MoveSongsDown(order);
            }

            SongOrder.Add(order, song.Id);
            Songs.Add(song);
            CalculateAlbumDuration();
        }

        public void RemoveSong(Song song)
        {
            // todo
        }

        public void ChangeSongOrder(int oldOrder, int newOrder) 
        {
            // todoa
        }


    }

    // add song
    // remove song
    // change order
    // cal duration
}
