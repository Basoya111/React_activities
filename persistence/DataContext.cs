using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace persistence
{
    public class DataContext: DbContext
    {
        //Creating connection to the database Step1
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Value> Values {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
            
                new Value {Id=1, Name = "Value101"},
                new Value {Id=2, Name ="Nishant is King"},
                new Value {Id=3, Name = "Nishant Bhaskar is everlasting quintillionire"}
            );

            

        }

    }
}
