namespace arcade_net.Models
{
    public class FollowModel
    {
        public int FollowingUserId { get; set; }
        public int FollowedUserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserModel FollowingUser { get; set; } = null!;
        public UserModel FollowedUser { get; set; } = null!;
    }
}
