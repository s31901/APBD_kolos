public class PostCourseDto
{
    public string LastName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int Credits { get; set; }
    public ICollection<StudentIdDto> Students { get; set; } = [];
}

public class StudentIdDto
{
    public int StudentId { get; set; }
}