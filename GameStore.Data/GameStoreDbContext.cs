using GameStore.Data.Configurations;
using GameStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Data
{
    public class GameStoreDbContext : DbContext
    {
        public GameStoreDbContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfiguration())
                        .ApplyConfiguration(new AppTypeConfiguration())
                        .ApplyConfiguration(new AppCategorieConfiguration())
                        .ApplyConfiguration(new CategorieConfiguration())
                        .ApplyConfiguration(new DeveloperConfiguration())
                        .ApplyConfiguration(new UserConfiguration())
                        .ApplyConfiguration(new UserAppConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<App> Apps { get; set; }
        public DbSet<AppType> AppTypes { get; set; }
        public DbSet<AppCategorie> AppCategories { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserApp> UserApps { get; set; }

    }
}
