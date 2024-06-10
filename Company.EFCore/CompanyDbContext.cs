using Company.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.EFCore;

public class CompanyDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=CompanyDb;User Id=sa; Password=ExamPrepPass15%;");
    }
}