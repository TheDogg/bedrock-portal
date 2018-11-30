﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinecraftWrapper.Models;

namespace MinecraftWrapper.Data
{
    public class SystemRepository
    {
        private readonly ApplicationDbContext _context;

        public SystemRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public void SaveApplicationLogs ( IEnumerable<ApplicationLog> logs )
        {
            foreach (var log in logs)
            {
                _context.Add ( log );
            }

            _context.SaveChanges ();
        }
    }
}