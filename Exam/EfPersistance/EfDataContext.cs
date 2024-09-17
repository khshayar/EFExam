using Exam.EfPersistance.Zoos;
using Exam.Entity;
using Microsoft.EntityFrameworkCore;

namespace Exam.EfPersistance;

public class EfDataContext: DbContext
{
    //table 
    public DbSet<Zoo> Zoos { get; set; }
    public DbSet<Part> Parts { get; set; }
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Tiket> Tikets { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=WIN10\\TEST;Initial Catalog=Exam_17_9;" +
                                    "Integrated Security=true;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ZooEntityMap).Assembly);
    }
}