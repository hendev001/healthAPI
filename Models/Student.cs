namespace healthAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        = string.Empty;
        public DateTime DOB { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Email { get; set; }
        public string SSN { get; set; } = string.Empty;
    }
}
