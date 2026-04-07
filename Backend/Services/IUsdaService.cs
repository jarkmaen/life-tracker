using Backend.DTOs;

namespace Backend.Services;

public interface IUsdaService
{
    Task<UsdaResponseDto?> GetByIdAsync(int id);
}
