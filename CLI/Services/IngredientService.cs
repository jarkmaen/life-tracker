namespace CLI.Services;

public class IngredientService(HttpClient httpClient)
{
    public async Task<string> GetAllAsync()
    {
        return await httpClient.GetStringAsync("api/ingredients");
    }
}
