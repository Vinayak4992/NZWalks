using Microsoft.EntityFrameworkCore;
using NZWalks.WebAPI.Models.Domain;
using System.Data;

namespace NZWalks.WebAPI.Data
{
    public class NZDbContext:DbContext
    {
        public NZDbContext(DbContextOptions<NZDbContext> option):base(option)
        {
                
        }
        public DbSet<Region>  Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
