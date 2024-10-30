namespace StudentConnect.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = null!;
        public string AuthorId { get; set; } = null!;
        public Guid PostId { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
        public ApplicationUser Author { get; set; } = null!;
        public Post Post { get; set; } = null!;
    }
}
