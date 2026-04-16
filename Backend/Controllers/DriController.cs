using Backend.DTOs;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DriController(IDriService driService) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<DriResponseDto>> GetAll()
    {
        return driService.GetAll();
    }
}
