using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JwtAuthenticationApi.Models
{
    public partial class PlaylistDetails
    {
        public PlaylistDetails()
        {
            UserLibrary = new HashSet<UserLibrary>();
        }

        public int Playlistid { get; set; }
        public string Playlistname { get; set; }
        public int? Userid { get; set; }
        public int? Songid { get; set; }
        public DateTime? Addeddate { get; set; }
        public int? Usersongplaycounter { get; set; }

        public virtual SongDetails Song { get; set; }
        public virtual UserDetails User { get; set; }
        public virtual ICollection<UserLibrary> UserLibrary { get; set; }
    }
}
