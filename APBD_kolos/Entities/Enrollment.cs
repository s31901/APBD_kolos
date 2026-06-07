using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_kolos.Entities;

[PrimaryKey(nameof(CourseId), nameof(StudentId))]
[Table( "Enrollments")]
public class Enrollment
{
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    
    [Column(TypeName = "decimal(2,1)")]
    public decimal? Grade { get; set; }
    public string Status { get; set; } = string.Empty;
    
    [ForeignKey(nameof(CourseId))]
    public Course Course { get; set; }
    
    [ForeignKey(nameof(StudentId))]
    public Student Student { get; set; }
}