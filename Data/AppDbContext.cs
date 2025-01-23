using arcade_net.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace arcade_net.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<PostsModel> Posts { get; set; }
        public DbSet<CommunityModel> Communities { get; set; }
        public DbSet<CommunityMemberModel> CommunityMembers { get; set; }
        public DbSet<FrameModel> Frames { get; set; }
        public DbSet<UserFrameModel> UserFrames { get; set; }
        public DbSet<ShopModel> Shops { get; set; }
        public DbSet<FollowModel> Follows { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FollowModel>()
                .HasKey(f => new { f.FollowingUserId, f.FollowedUserId });

            modelBuilder.Entity<CommunityMemberModel>()
                .HasKey(cm => new { cm.UserId, cm.CommunityId });

            modelBuilder.Entity<UserFrameModel>()
                .HasKey(uf => new { uf.UserId, uf.FrameId });
        }
    }
}
