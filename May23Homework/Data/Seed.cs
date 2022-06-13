using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace May23Homework.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder application)
        {
            using (var serviceScope = application.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
