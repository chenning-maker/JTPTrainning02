using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyProject.Authorization.Roles;
using MyProject.Authorization.Users;
using MyProject.MultiTenancy;
using MyProject.Test;

namespace MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }
        public DbSet<Meeting> Meetings { get; set; }

        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>(p =>
            {
                p.ToTable("Persons","test");
                p.Property(x => x.Name).IsRequired(true).HasMaxLength(20);


            });

            modelBuilder.Entity<Meeting>(p =>
            {
                p.ToTable("Meetings", "test");
                p.Property(x => x.CreateUserName).IsRequired(true).HasMaxLength(20);


            });

        }
    }
}
