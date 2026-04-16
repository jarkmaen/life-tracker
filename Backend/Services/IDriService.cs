using Backend.DTOs;

namespace Backend.Services;

public interface IDriService
{
    List<DriResponseDto> GetAll();
}
