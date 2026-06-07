using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolos.Entities;

[Table( "Courses")]
public class Course
{
    [Key]
    public int CourseId { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;
    public int Credits { get; set; }
    public int Semester { get; set; }
    public int ProfessorId { get; set; }
    
    [ForeignKey(nameof(ProfessorId))]
    public Professor Professor { get; set; }
    
    public ICollection<Enrollment> Enrollments { get; set; } = [];
}