using System;
using System.Reflection;
using eLearning.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace eLeaning.Infrastructure.Data
{
	public class ElearningDbContext : DbContext
	{
		public ElearningDbContext(DbContextOptions<ElearningDbContext> options) : base(options)
		{
            
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Roles> Roles { get; set; }

    }
}

