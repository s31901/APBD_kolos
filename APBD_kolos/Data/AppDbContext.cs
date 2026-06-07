using APBD_kolos.Entities;
using Microsoft.EntityFrameworkCore;

namespace APBD_kolos.Data;

public class AppDbContext : DbContext
{
    protected AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Student>().HasData(
            new Student { StudentId = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jan@mail.to", EnrollmentYear = 2022 },
            new Student { StudentId = 2, FirstName = "Dawid", LastName = "Zygzak", Email = "zygzak@mail.to", EnrollmentYear = 2022 }
        );
        modelBuilder.Entity<Department>().HasData(
            new Department { DepartmentId = 1, Name = "Informatyka", FacilityBuilding = "K101", Budget = 100000 }
        );
        
        modelBuilder.Entity<Professor>().HasData(
            new Professor { ProfessorId = 1, FirstName = "Jacek", LastName = "Smok", Email = "smok@mail.to", DepartmentId = 1 },
            new Professor { ProfessorId = 2, FirstName = "Mark", LastName = "Johnson", Email = "smok@mail.to", DepartmentId = 1 }
        );
        
        modelBuilder.Entity<Course>().HasData(
            new Course { CourseId = 1, Title = "Programowanie obiektowe", Credits = 3, Semester = 1, ProfessorId = 1 }
        );

        modelBuilder.Entity<Enrollment>().HasData(
            new Enrollment { CourseId = 1, StudentId = 1, Grade = 4.5m, Status = "Approved" },
            new Enrollment { CourseId = 1, StudentId = 2, Grade = 4m, Status = "Approved" }
        );
    }
}