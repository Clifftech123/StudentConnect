namespace StudentConnect.Domain.Models
{
    public class ErrorResponse
    {
        public string Message { get; set; }
        public string? Details { get; set; }

        public string Title { get; set; }

        public int StatusCode { get; set; }
    }
}
