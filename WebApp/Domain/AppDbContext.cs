using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Domain.Entities;

namespace WebApp.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Description> Description { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "3fdef149-fd52-48e1-b5ce-a099a7cac941",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "8559a0b0-a171-4724-8431-982e2c8a5ed4",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "3fdef149-fd52-48e1-b5ce-a099a7cac941",
                UserId = "8559a0b0-a171-4724-8431-982e2c8a5ed4"
            });

            builder.Entity<Description>().HasData(new Description
            {
                Id = new Guid("58e519d6-5f87-48aa-b4f2-743db9772fc5"),
                Text = "Я Семен"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("ed87c8f8-82bb-471b-aa44-80bd6ffb9a9a"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });
        }
    }
}
