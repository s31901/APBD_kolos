using APBD_kolos.Entities;

namespace APBD_kolos.DTOs;

public class GetProfessorWithCoursesDto
{
    public int ProfessorId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
   // public string Name { get; set; } = string.Empty;
    
    public IEnumerable<CourseDto> Courses { get; set; } = [];
}

public class CourseDto
{
    public int CourseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Credits { get; set; }
    public int Semester { get; set; }
    
    public IEnumerable<EnrollmentWithStudentsDto> Enrollments { get; set; } = [];
}

public class EnrollmentWithStudentsDto
{
    public decimal? Grade { get; set; }
    public string Status { get; set; } = string.Empty;
    public StudentDto Student { get; set; }
}

public class StudentDto
{
    public int StudentId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int EnrollmentYear { get; set; }
}