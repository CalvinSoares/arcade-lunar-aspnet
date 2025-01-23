namespace arcade_net.Models
{
    public class CommunityMemberModel
    {
        public int UserId { get; set; }
        public int CommunityId { get; set; }
        public string Role { get; set; } = string.Empty;
        public DateTime JoinedAt { get; set; }

        public UserModel User { get; set; } = null!;
        public CommunityModel Community { get; set; } = null!;
    }
}
