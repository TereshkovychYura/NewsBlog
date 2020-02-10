﻿using Microsoft.EntityFrameworkCore;
using MVC_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Entities
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<BlogModel> News { get; set; }

    }
}