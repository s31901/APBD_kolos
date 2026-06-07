using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolos.Entities;

[Table( "Students")]
public class Student
{
    [Key]
    public int StudentId { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    public int EnrollmentYear { get; set; }
    
    public ICollection<Enrollment> Enrollments { get; set; } = [];
}