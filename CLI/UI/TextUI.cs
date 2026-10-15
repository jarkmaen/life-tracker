using CLI.Services;
using System.Globalization;

namespace CLI.UI;

public class TextUI(IngredientService ingredientService)
{
    public async Task RunAsync()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("life tracker");
            Console.WriteLine();
            Console.WriteLine("1. add ingredient");
            Console.WriteLine("2. list ingredients");
            Console.WriteLine("3. exit");
            Console.WriteLine();
            Console.Write("> ");

            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                AddIngredient();
            }
            else if (choice == "2")
            {
                await ListIngredientsAsync();
            }
            else if (choice == "3" || string.IsNullOrWhiteSpace(choice))
            {
                break;
            }
        }
    }

    private void AddIngredient()
    {
        Console.Clear();
        Console.WriteLine("life tracker > add ingredient");
        Console.WriteLine();

        int? usdaId = ReadOptionalInt("usda id  : ");
        string name = ReadString("name     : ");
        decimal quantity = ReadDecimal("quantity : ");
        decimal price = ReadDecimal("price    : ");

        Console.WriteLine();

        decimal energy = ReadDecimal("energy   : ");
        decimal fat = ReadDecimal("fat      : ");
        decimal saturatedFat = ReadDecimal("sat. fat : ");
        decimal carbohydrate = ReadDecimal("carbs    : ");
        decimal sugar = ReadDecimal("sugar    : ");
        decimal protein = ReadDecimal("protein  : ");
        decimal salt = ReadDecimal("salt     : ");
        decimal fiber = ReadDecimal("fiber    : ");

        Console.WriteLine();
        Console.WriteLine("ingredient added.");
        Console.WriteLine();
        Console.Write("press any key to continue...");
        Console.ReadKey();
    }

    private async Task ListIngredientsAsync()
    {
        Console.Clear();
        Console.WriteLine("life tracker > list ingredients");
        Console.WriteLine();

        try
        {
            var ingredients = await ingredientService.GetAllAsync();

            if (ingredients.Count == 0)
            {
                Console.WriteLine("no ingredients found.");
            }
            else
            {
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine(ingredient.Name);
                }
            }
        }
        catch (HttpRequestException)
        {
            Console.WriteLine("could not load ingredients. is the backend running?");
        }

        Console.WriteLine();
        Console.Write("press any key to continue...");
        Console.ReadKey();
    }

    private static decimal ReadDecimal(string label)
    {
        while (true)
        {
            Console.Write(label);
            string? input = Console.ReadLine()?.Replace(',', '.');

            if (decimal.TryParse(input, CultureInfo.InvariantCulture, out decimal value) && value >= 0)
            {
                return value;
            }

            Console.WriteLine("enter a number of 0 or more.");
        }
    }

    private static int? ReadOptionalInt(string label)
    {
        while (true)
        {
            Console.Write(label);
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            if (int.TryParse(input, out int value) && value >= 1)
            {
                return value;
            }

            Console.WriteLine("enter a whole number of 1 or more, or leave it empty.");
        }
    }

    private static string ReadString(string label)
    {
        while (true)
        {
            Console.Write(label);
            string? input = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(input) && input.Length <= 255)
            {
                return input;
            }

            Console.WriteLine("enter 1 to 255 characters.");
        }
    }
}
