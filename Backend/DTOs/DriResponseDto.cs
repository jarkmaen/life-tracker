namespace Backend.DTOs;

public class DriResponseDto
{
    public decimal? Recommended { get; set; }
    public decimal? UpperLimit { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
}
