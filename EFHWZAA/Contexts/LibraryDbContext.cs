using EFHWZAA.Models;
using Microsoft.EntityFrameworkCore;

namespace EFHWZAA.Contexts;

public class LibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var sqlConnectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        optionsBuilder.UseSqlServer(sqlConnectionString);

        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Author> Authors { get; set; }
}
