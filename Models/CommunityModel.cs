using Microsoft.Extensions.Hosting;

namespace arcade_net.Models
{
    public class CommunityModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public UserModel CreatedBy { get; set; } = null!;
        public ICollection<PostsModel> Posts { get; set; } = new List<PostsModel>();
        public ICollection<CommunityMemberModel> Members { get; set; } = new List<CommunityMemberModel>();

    }
}
