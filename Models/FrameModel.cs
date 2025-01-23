namespace arcade_net.Models
{
    public class FrameModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int Price { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<UserFrameModel> UserFrames { get; set; } = new List<UserFrameModel>();
        public ICollection<ShopModel> Shops { get; set; } = new List<ShopModel>();
    }
}
