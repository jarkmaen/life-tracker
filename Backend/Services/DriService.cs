using Backend.Constants;
using Backend.DTOs;
using System.Reflection;

namespace Backend.Services;

public class DriService : IDriService
{
    public List<DriResponseDto> GetAll()
    {
        var type = typeof(Nutrients);

        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

        return [.. fields
            .Select(f => f.GetValue(null) as Nutrient)
            .Select(n => new DriResponseDto
            {
                Recommended = n!.Recommended,
                UpperLimit = n.UpperLimit,
                Name = n.Name,
                Unit = n.Unit.ToString()
            })];
    }
}
