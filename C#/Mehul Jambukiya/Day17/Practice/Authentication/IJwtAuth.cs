﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17_Practice.Authentication
{
    public interface IJwtAuth
    {
        string Authentication(string username, string password);
    }
}
