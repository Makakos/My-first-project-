using asp.net.Domain.Entitys;
using asp.net.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Domain
{
    public class SiteContext:IdentityDbContext<IdentityUser>
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName ="Admin",
                NormalizedUserName="ADMIN",
                Email="bs@gmail.com",
                NormalizedEmail="BS@gmail.com",
                EmailConfirmed=true,
                PasswordHash=new PasswordHasher<IdentityUser>().HashPassword(null,"youcantkillrocknroll"),
                SecurityStamp=string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                //RoleId= "44546e06-8719-4ad8-b88a-f271are9d6eab",
                //UserId = "3b62472e-4f66-49fa-a20f-e768b9565d8"
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id=new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                CodeWord="PageIndex",
                Title="Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                CodeWord = "PageServices",
                Title = "Услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
