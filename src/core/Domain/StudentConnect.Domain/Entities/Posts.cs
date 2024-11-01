using StudentConnect.Domain.Helper;

namespace StudentConnect.Domain.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Slug { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Content { get; set; } = null!;
        public ApplicationUser Author { get; set; } = null!;
        public string AuthorId { get; set; } = null!;
        public bool IsFavorited { get; set; }
        public int FavoritesCount { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;

        // Parameterless constructor
        public Post() { }

        // Parameterized constructor
        public Post(string title, string description, string content, string authorId)
        {
            Slug = title.GenerateSlug();
            Title = title;
            Description = description;
            Content = content;
            AuthorId = authorId;
        }
    }
}
