using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Welcome.Others;

namespace DataLayer.Database;

public class DatabaseContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string databaseFile = "Welcome.db";
        string databasePath = Path.Combine(solutionFolder, databaseFile);
        optionsBuilder.UseSqlite($"Data Source={databasePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DatabaseeUser>().Property(e => e.FacultyNumber).ValueGeneratedOnAdd();

        var user = new DatabaseeUser()
        {
            FacultyNumber = 1,
            Name = "John Doe",
            Password = "1234",
            Role = UserRolesEnum.ADMIN,
            Email = "neshto"
        };
        modelBuilder.Entity<DatabaseeUser>().HasData(user);
    }
    public  DbSet<DatabaseeUser> Users { get; set; }
}