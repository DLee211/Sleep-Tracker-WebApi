using Microsoft.EntityFrameworkCore;

namespace Sleep_Tracker_WebApi.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SleepDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<SleepDbContext>>()))
        {
            // Look for any sleep data.
            if (context.SleepDatas.Any())
            {
                // DB has been seeded
                return;
            }

            for (int i = 1; i <= 10; i++)
            {
                context.SleepDatas.Add(new SleepData
                {
                    Date = DateTime.Now.AddDays(-i),
                    Hours = i,
                    Minutes = (i * 10) % 60,
                    Notes = $"Sleep note {i}"
                });
            }

            context.SaveChanges();
        }
    }
    
    public static void ClearDatabase(IServiceProvider serviceProvider)
    {
        using (var context = new SleepDbContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<SleepDbContext>>()))
        {
            context.SleepDatas.RemoveRange(context.SleepDatas);
            context.SaveChanges();
        }
    }
}