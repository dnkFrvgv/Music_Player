using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.entities
{
    internal class Artist
    {

        public Artist(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Album> Albums {  get; set; }


    }
}
