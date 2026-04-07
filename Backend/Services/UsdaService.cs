using Backend.DTOs;

namespace Backend.Services;

public class UsdaService(IConfiguration config, IHttpClientFactory httpClientFactory) : IUsdaService
{
    public async Task<UsdaResponseDto?> GetByIdAsync(int id)
    {
        var apiKey = config["UsdaApiKey"];
        var client = httpClientFactory.CreateClient();
        var url = $"https://api.nal.usda.gov/fdc/v1/food/{id}?api_key={apiKey}";

        try
        {
            return await client.GetFromJsonAsync<UsdaResponseDto>(url);
        }
        catch
        {
            return null;
        }
    }
}
