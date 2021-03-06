﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimelERP.Domain.Entities;

namespace SimelERP.Persistence
{
    //TBD for user 
  public  class SimelERPDbContext : IdentityDbContext
    {
        public SimelERPDbContext(DbContextOptions<SimelERPDbContext> options)
           : base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
