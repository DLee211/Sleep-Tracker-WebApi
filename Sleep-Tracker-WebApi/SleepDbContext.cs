using Microsoft.EntityFrameworkCore;
using Sleep_Tracker_WebApi.Models;

namespace Sleep_Tracker_WebApi;

public class SleepDbContext : DbContext
{
    public SleepDbContext (DbContextOptions<SleepDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<SleepData> SleepDatas { get; set; }
}