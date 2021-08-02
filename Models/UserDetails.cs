using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JwtAuthenticationApi.Models
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            LikedSongs = new HashSet<LikedSongs>();
            PlaylistDetails = new HashSet<PlaylistDetails>();
            UserLibrary = new HashSet<UserLibrary>();
        }

        public int Userid { get; set; }
        public string Username { get; set; }
        public string Useremail { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public DateTime? Dob { get; set; }
        public string Role { get; set; }

        public virtual ICollection<LikedSongs> LikedSongs { get; set; }
        public virtual ICollection<PlaylistDetails> PlaylistDetails { get; set; }
        public virtual ICollection<UserLibrary> UserLibrary { get; set; }
    }
}
