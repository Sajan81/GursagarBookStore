﻿using GursagarsBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GursagarBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

     public DbSet<Category> Categories { get; set; }

        public DbSet<CoverType> CoverType { get; set; }

        public object CoverTypes { get; internal set; }
        public DbSet<Product> Products { get; set; }

    }
}
