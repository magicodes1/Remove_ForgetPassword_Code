using Microsoft.EntityFrameworkCore;
using test_event.Models;

namespace test_event.Data;

public static class DataSeed
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            if (!context.forgetPasswordCodes.Any())
            {
                System.Console.WriteLine("ok");
                context.forgetPasswordCodes.AddRange(new List<ForgetPasswordCode>() {
                        new ForgetPasswordCode { Code = "123",ExpiredTime = 2},
                        new ForgetPasswordCode { Code = "456",ExpiredTime = 2},
                        new ForgetPasswordCode { Code = "789",ExpiredTime = 2},
                    });

                context.SaveChanges();
                System.Console.WriteLine("asd");
            }
        }
    }
}