using Backend.Constants;
using Backend.DTOs;
using System.Reflection;
using System.Text.Json;

namespace Backend.Services;

public class DriService : IDriService
{
    public List<DriResponseDto> GetAll()
    {
        var type = typeof(Nutrients);

        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

        return [.. fields
            .Select(f => (Field: f, Nutrient: (Nutrient)f.GetValue(null)!))
            .Where(x => x.Nutrient.Recommended.HasValue || x.Nutrient.UpperLimit.HasValue)
            .Select(x => new DriResponseDto
            {
                Recommended = x.Nutrient.Recommended,
                UpperLimit = x.Nutrient.UpperLimit,
                Key = JsonNamingPolicy.CamelCase.ConvertName(x.Field.Name),
                Name = x.Nutrient.Name,
                Unit = x.Nutrient.Unit.ToString()
            })];
    }
}
