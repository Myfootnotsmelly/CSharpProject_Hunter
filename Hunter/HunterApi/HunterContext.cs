using HunterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HunterApi
{
    public class HunterContext : DbContext
    {
        
        public HunterContext(DbContextOptions<HunterContext> options)
            : base(options)
        {
            this.Database.EnsureCreated(); //�Զ����⽨��
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Collect> Collects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SuccessfulTrade> SuccessfulTrades { get; set; }
        public DbSet<Preference> Preferences { get; set; }
    }
}
