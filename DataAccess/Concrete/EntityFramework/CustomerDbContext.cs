﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CustomerDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=Bitirme2;UserId=postgres;Password=koletsa66");

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transformer> Transformers { get; set; }
        
    }
}
