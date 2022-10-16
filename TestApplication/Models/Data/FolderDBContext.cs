using Microsoft.EntityFrameworkCore;
namespace TestApplication.Models.Data
{
    public class FolderDBContext:DbContext
    {
        public FolderDBContext(DbContextOptions<FolderDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Folder> Folders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Folder>().HasData(
                new Folder { Id = 1, Name = "Creating Digital Images",CatalogId = 1,RootFolderId = null},
                new Folder { Id = 2, Name = "Resources", CatalogId = 1, RootFolderId = 1 },
                new Folder { Id = 3, Name = "Evidence", CatalogId = 1, RootFolderId = 1 },
                new Folder { Id = 4, Name = "Graphic Products", CatalogId = 1, RootFolderId = 1 },
                new Folder { Id = 5, Name = "Primary Sources", CatalogId = 1, RootFolderId = 2 },
                new Folder { Id = 6, Name = "Secondary Sources", CatalogId = 1, RootFolderId = 2 },
                new Folder { Id = 7, Name = "Process", CatalogId = 1, RootFolderId = 4 },
                new Folder { Id = 8, Name = "Final Product", CatalogId = 1, RootFolderId = 4 }
                );
        }
    }
}
