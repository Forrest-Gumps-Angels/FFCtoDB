using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FFCtoDB.Models;

namespace FFCtoDB.Data
{
    public class ReferenceContext : DbContext
    {

        private string _connectionString = "Source";
        public DbSet<Reference> References { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Reference>().HasKey(c => new { c.xPoint, c.yPoint });
        }
    }
}
