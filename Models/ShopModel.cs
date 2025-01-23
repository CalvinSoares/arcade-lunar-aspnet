namespace arcade_net.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        public int FrameId { get; set; }
        public DateTime CreatedAt { get; set; }

        public FrameModel Frame { get; set; } = null!;
    }
}
