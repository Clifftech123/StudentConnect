namespace StudentConnect.Infrastructure.Contracts.User
{
    public class UserRegisterDto
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string CourseOfStudy { get; set; }
    }
}
