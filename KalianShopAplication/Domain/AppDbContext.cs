using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalianShopApplication.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KalianShopApplication.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "7c7e3d94-1000-49aa-a831-0abe1c9c95ef",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "abc2c623-9698-4348-a8ac-9b56ae42f994",
                UserName = "admin",
                NormalizedUserName = "Admin",
                Email = "Igartuk@gmail.com",
                NormalizedEmail = "IGARTUK@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = String.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "ca29b9ba-22d1-4128-8e7c-e4fcfb6b8c76",
                UserId = "cf1c3da6-caa1-4463-b614-4f40c2ab9bb8"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("98d22faa-1780-4088-84ed-be6a9166f9cd"),
                CodeWord = "PageIndex",
                Title = "Main"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("c099ca99-1381-4cd8-a7c2-e1547ac6808c"),
                CodeWord = "PageServices",
                Title = "Our services "
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("c3760745-2c89-4fa4-a601-1912b6462f07"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });
        }
    }
}
