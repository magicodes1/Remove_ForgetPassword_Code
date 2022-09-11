using Microsoft.EntityFrameworkCore;
using test_event.Models;

namespace test_event.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<ForgetPasswordCode> forgetPasswordCodes { get; set; } = null!;
}