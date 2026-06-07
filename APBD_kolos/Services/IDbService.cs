
using APBD_kolos.DTOs;

namespace APBD_kolos.Services;

public interface IDbService
{
    Task<IEnumerable<GetProfessorWithCoursesDto>> GetProfessors(string? search);
    
}