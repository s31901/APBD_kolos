using APBD_kolos.Data;
using APBD_kolos.DTOs;
using APBD_kolos.Entities;
using Microsoft.EntityFrameworkCore;

namespace APBD_kolos.Services;

public class DbService : IDbService
{
    private readonly AppDbContext _dbContext;
    public DbService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<GetProfessorWithCoursesDto>> GetProfessors(string? search)
    {
        var query = _dbContext.Professors.AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(p =>
                EF.Functions.Like(p.LastName, $"%{search}%"));
        }
        
        return await _dbContext.Professors
            .Select(e => new GetProfessorWithCoursesDto()
            {
                ProfessorId = e.ProfessorId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email,
               // Name = e.Department.Select
                Courses = e.Courses.Select(c => new CourseDto()
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Credits = c.Credits,
                    Semester = c.Semester,
                    Enrollments = c.Enrollments.Select(en => new EnrollmentWithStudentsDto()
                    {
                        Grade = en.Grade,
                        Status = en.Status,
                        Student = new StudentDto
                        {
                            StudentId = en.StudentId,
                            FirstName = en.Student.FirstName,
                            LastName = en.Student.LastName,
                            Email = en.Student.Email,
                            EnrollmentYear = en.Student.EnrollmentYear
                        }
                        
                    }).ToList()
                }).ToList()
            }).ToListAsync();
    }

}