using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JwtAuthenticationApi.Models
{
    public partial class UserLibrary
    {
        public int Userlibraryid { get; set; }
        public int? Userid { get; set; }
        public int? Playlistid { get; set; }

        public virtual PlaylistDetails Playlist { get; set; }
        public virtual UserDetails User { get; set; }
    }
}
