using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngredientsController(IIngredientService ingredientService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Ingredient>> Create(Ingredient ingredient)
    {
        var createdIngredient = await ingredientService.AddAsync(ingredient);

        return CreatedAtAction(nameof(GetById), new { id = createdIngredient.Id }, createdIngredient);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Ingredient>> GetById(int id)
    {
        var ingredient = await ingredientService.GetByIdAsync(id);

        if (ingredient == null)
        {
            return NotFound();
        }

        return ingredient;
    }

    [HttpGet]
    public async Task<ActionResult<List<Ingredient>>> GetAll()
    {
        return await ingredientService.GetAllAsync();
    }
}
