using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthenticationApi.Models.ViewModels
{
    public class LoginDetails
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
