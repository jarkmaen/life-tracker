using CLI.DTOs;
using System.Net.Http.Json;

namespace CLI.Services;

public class IngredientService(HttpClient httpClient)
{
    public async Task AddAsync(IngredientCreateDto dto)
    {
        var response = await httpClient.PostAsJsonAsync("api/ingredients", dto);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<IngredientResponseDto>> GetAllAsync()
    {
        return await httpClient.GetFromJsonAsync<List<IngredientResponseDto>>("api/ingredients") ?? [];
    }
}
