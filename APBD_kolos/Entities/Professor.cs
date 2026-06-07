using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolos.Entities;

[Table( "Professors")]
public class Professor
{
    [Key]
    public int ProfessorId { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    
    public int DepartmentId { get; set; }
    
    [ForeignKey(nameof(DepartmentId))]
    public Department Department { get; set; }
    
    public ICollection<Course> Courses { get; set; } = [];
}