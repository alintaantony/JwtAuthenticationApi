﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthenticationApi.Repository
{
    public interface IAuthenticationManager
    {
        public string Authenticate(string Username, string Password);
    }
}
