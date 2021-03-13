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

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("ed87c8f8-82bb-471b-aa44-80bd6ffb9a9a"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("368eb6c7-cd57-407d-ab0e-3ce51d616fc2"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("30afafcc-42e4-4e1e-9247-57b886c5f715"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }
}
