﻿using Fundamentals_entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace Fundamentals_entity_framework.Data
{
    public class BlogDataContext : DbContext
    {
        // PostTag e UserRole comentados pois não possuem chave primaria e seim composta. Vamos fazer primeiro um crud basico
        // Na parte avançada voltamos
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        // public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        // public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Blog;Encrypt=False;User ID=sa;Password=1q2w3e4r@#$");
        }
    }
}
