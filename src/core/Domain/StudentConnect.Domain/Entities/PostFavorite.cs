namespace StudentConnect.Domain.Entities
{
    public class PostFavorite
    {
        public Guid PostId { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public Post Post { get; set; } = null!;

        public PostFavorite(string userId, Guid postId)
        {
            UserId = userId;
            PostId = postId;
        }
    }
}
