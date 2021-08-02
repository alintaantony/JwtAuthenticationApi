using JwtAuthenticationApi.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationApi.Repository
{
    public class AuthenticationManager : IAuthenticationManager
    {
        SpotifyDemoDbContext _context = new SpotifyDemoDbContext();
        private readonly string _tokenKey;

        public AuthenticationManager(string TokenKey)
        {
            this._tokenKey = TokenKey;
        }

        public string Authenticate(string Username, string password)
        {
            if (!_context.UserDetails.Any(u => u.Useremail == Username && u.Password == password))
            {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_tokenKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, Username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
