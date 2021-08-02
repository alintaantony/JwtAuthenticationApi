using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JwtAuthenticationApi.Models
{
    public partial class SongDetails
    {
        public SongDetails()
        {
            LikedSongs = new HashSet<LikedSongs>();
            PlaylistDetails = new HashSet<PlaylistDetails>();
        }

        public int Songid { get; set; }
        public string Songname { get; set; }
        public string Artistname { get; set; }
        public string Songdescription { get; set; }
        public string Albumname { get; set; }
        public string Genre { get; set; }
        public string Songpath { get; set; }
        public string Lyrics { get; set; }
        public int? Songplaycounter { get; set; }

        public virtual ICollection<LikedSongs> LikedSongs { get; set; }
        public virtual ICollection<PlaylistDetails> PlaylistDetails { get; set; }
    }
}
