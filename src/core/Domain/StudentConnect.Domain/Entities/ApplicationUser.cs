using StudentConnect.Domain.Enums;

namespace StudentConnect.Domain.Entities
{
    public class ApplicationUser
    {
        public string? Bio { get; set; }
        public string? ProfilePicture { get; set; }
        public Role Role { get; set; }
        public string? Education { get; set; }
        public string Profession { get; set; } = null!;
        public ICollection<string>? Interests { get; set; }
        public ICollection<string>? Skills { get; set; }
        public string? CourseOfStudy { get; set; }
        public DateTime JoinedDate { get; set; } = DateTime.UtcNow;
        public ICollection<ApplicationUser> Followers { get; set; } = new List<ApplicationUser>();
        public ICollection<ApplicationUser> FollowedUsers { get; set; } = new List<ApplicationUser>();
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<PostFavorite> Favorites { get; set; } = new List<PostFavorite>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
