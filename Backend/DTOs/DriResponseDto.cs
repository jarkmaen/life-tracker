using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs;

public class DriResponseDto
{
    [Required]
    public decimal? Recommended { get; set; }

    [Required]
    public decimal? UpperLimit { get; set; }

    [Required]
    public string Key { get; set; } = string.Empty;

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Unit { get; set; } = string.Empty;
}
