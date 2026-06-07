using APBD_kolos.Exceptions;
using APBD_kolos.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_kolos.Controllers;

[Route("api/[controller]")]
public class ProfessorsController : ControllerBase
{
    private readonly IDbService _dbService;
    public ProfessorsController(IDbService db) { _dbService = db; }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? search)
    {
        var res = await _dbService.GetProfessors(search);
        return Ok(res);
    }
}