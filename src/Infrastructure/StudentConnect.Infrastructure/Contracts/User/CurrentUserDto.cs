namespace StudentConnect.Infrastructure.Contracts.User
{
    public class CurrentUserDto
    {
        public string id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public string Role { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string CourseOfStudy { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
