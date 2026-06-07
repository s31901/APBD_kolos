using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_kolos.Entities;

[Table( "Departments")]
public class Department
{
    [Key]
    public int DepartmentId { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string FacilityBuilding { get; set; } = string.Empty;
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal Budget { get; set; }
    
    public ICollection<Professor> Professors { get; set; } = [];
    
    
}