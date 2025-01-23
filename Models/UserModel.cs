namespace arcade_net.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool VerifyEmail { get; set; }
        public string ProfileImage { get; set; } = string.Empty;
        public string CommunityRole { get; set; } = string.Empty;
        public int Tokens { get; set; } = 0;
        public DateTime CreatedAt { get; set; }

        public ICollection<PostsModel> Posts { get; set; } = new List<PostsModel>();
        public ICollection<CommunityModel> CreatedCommunities { get; set; } = new List<CommunityModel>();
        public ICollection<CommunityMemberModel> CommunityMemberships { get; set; } = new List<CommunityMemberModel>();
    }
}
