﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MinecraftWrapper.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<AuthorizedUser> Users { get; set; }
    }
}