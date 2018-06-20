using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace CodeFirst
{
    
        class UserContext : DbContext
        {
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                base.OnModelCreating(modelBuilder);
            }
            public UserContext()
            {
                Database.Connection.ConnectionString = "server=.;database=UserDb;Trusted_Connection=true";
            }
            public DbSet<User> Users { get; set; }
        }
    }

