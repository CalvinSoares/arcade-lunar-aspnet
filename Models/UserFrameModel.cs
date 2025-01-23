namespace arcade_net.Models
{
    public class UserFrameModel
    {
        public int UserId { get; set; }
        public int FrameId { get; set; }
        public DateTime AcquiredAt { get; set; }

        public UserModel User { get; set; } = null!;
        public FrameModel Frame { get; set; } = null!;
    }
}
