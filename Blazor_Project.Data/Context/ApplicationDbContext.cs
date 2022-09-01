using Blazor_Project.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Blazor_Project.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<NewsCategory> NewsCategories { get; set; }

    public DbSet<News> Newses { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // | fluent config : |
        //modelBuilder.Entity<BaseEntity>()
        //    .HasQueryFilter(t => !t.IsDelete);

        modelBuilder.Entity<News>()
            .HasQueryFilter(x => !x.IsDelete);

        modelBuilder.Entity<NewsCategory>()
            .HasQueryFilter(x => !x.IsDelete);

        //Seed Data :
        modelBuilder.Entity<User>()
            .HasData(new List<User>
            {
                new User { Id = 1, CreateDate = DateTime.Now, UpdateDate = DateTime.Now, Email = "koohkan96@gmail.com",UserName = "Mahdiar Koohkan",Password = "mahdiar@koohkan",IsDelete = false}
            });
    }
}