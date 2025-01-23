namespace arcade_net.Models
{
    public class PostsModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int? CommunityId { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public UserModel User { get; set; } = null!;
        public CommunityModel? Community { get; set; }

    }
}
