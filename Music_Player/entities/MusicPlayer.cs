using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.entities
{
    internal class MusicPlayer
    {
        public Guid SongCurrentlyPlaying { get; set; }
        public ICollection<Song> Songs { get; set;}
        public ICollection<Playlist> Playlists { get; set;}

        public int GenerateSongId() {  return 0; }
        public int GeneratePlaylistId() {  return 0; }
        public void AddNewPlaylist(string Name)
        {

        }

    }
}
