using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MvcTueTest.Models;

namespace MvcTueTest.models
{
  public class ApplicationContext: DbContext
  {
    public DbSet<Ksodd> Ksodds { get; set; }
//    public DbSet<Podd> Podds { get; set; }
    

    public ApplicationContext()
    {
      Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MDD;Username=sergeiyurkin");
    }
  }
}    