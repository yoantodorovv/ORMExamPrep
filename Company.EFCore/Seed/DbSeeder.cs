namespace Company.EFCore.Seed;

public class DbSeeder
{
    private readonly CompanyDbContext context;

    public DbSeeder(CompanyDbContext context)
    {
        this.context = context;
    }
    
    public void SeedDatabase()
    {
        if (context.Database.EnsureCreated())
        {
            SeedDepartments(context);
            SeedEmployees(context);
        }
    }

    private static void SeedEmployees(CompanyDbContext context)
    {
        // Seed employees
    }

    private static void SeedDepartments(CompanyDbContext context)
    {
        // Seed departments
    }
}