using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.entities
{
    internal class Song
    {
        public Guid Id { get;set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public Album Albuum { get; set; }
        public TimeSpan Duration { get; set; }

    }
}
