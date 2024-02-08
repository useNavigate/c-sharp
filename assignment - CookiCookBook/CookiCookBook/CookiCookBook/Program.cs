

//using System.Net;

//var myFirstCookBook = new CookieCookBook();
//myFirstCookBook.Generate();
//Console.ReadKey();

//public class CookieCookBook
//{
//    public List<Recipe> Recipes { get; }
//    public List<Ingredient> Basket { get; }
//    public CookieCookBook()
//    {
//        Recipes = new List<Recipe>();
//        Basket = new List<Ingredient>();
//    }
//    public void Generate()
//    {

//        if (this.Recipes.Count == 0)
//        {
//            Console.WriteLine("You Do Not Have Any Saved Recipes\nCreate One Now!\nPress Any Button To Continue!");
//            Console.ReadLine();
//            Console.Clear();
//        }
//        else {
//            Console.WriteLine($"You have {Recipes.Count} saved recipes");
//        }


//        //check Recipes.Count and if its not 0
//        //print out saved recipes by iterating = > Recipe.IPrintInfo


//        //Console.WriteLine("Create a new cookie recipe! Available ingredients are:\n1. Wheat flour\n2. Coconut flour\n3. Butter\n4. Chocolate\n5. Sugar\n6. Cardamom\n7. Cinnamon\n8. Cocoa Powder");


//        var flag = true;

//        //need to parse the userInput and check if its int and number between 0~7 (inclusive)
//        do
//        {

//            Console.WriteLine("Create a new cookie recipe! Available ingredients are:\n1. Wheat flour\n2. Coconut flour\n3. Butter\n4. Chocolate\n5. Sugar\n6. Cardamom\n7. Cinnamon\n8. Cocoa Powder");
//            int key = 7;
//            var userInput = Console.ReadLine();
//            int number;
//            bool isValid = int.TryParse(userInput, out number);
//            //if its between number 0~7 add to the basket => instantiate new Ingreident(num)
//            if (isValid)
//            {
//                Basket.Add(new Ingredient(number));

//                Console.WriteLine($"Item #{userInput} has been added to your list ");

//            }
//            else
//            {
//                if (Basket.Count == 0)
//                {
//                    Console.WriteLine("you have input invalid value");
//                }
//                else
//                {
//                    Console.WriteLine("Creating your Recipes!\n-----------------------------------");
//                    foreach (Ingredient ingredient in Basket)
//                    {
//                        Console.WriteLine($"{ingredient.Name}\t{ingredient.Instruction}");
//                    }
//                    var newRecipe = new Recipe(Basket);
//                    Recipes.Add(newRecipe);
//                    Console.WriteLine($"Your recipe has been created now you have {Recipes.Count} recipes");
//                    flag = false;

//                }

//            }

//        } while (flag);
//    }
//}


//public class Recipe
//{
//    public List<Ingredient> Ingredients { get; }
//    public Recipe(List<Ingredient> ingredient)
//    {
//        Ingredients = ingredient;
//    }
//}



//public class Ingredient
//{
//    public int Id { get; }
//    public string Name;
//    public string Instruction;

//    public Ingredient(int id)
//    {
//        Id = id;
//        var info = GetIngredientInfo(id);
//        Name = info[0][0];
//        Instruction = info[0][1];
//    }

//    private static List<List<string>> GetIngredientInfo(int Id)
//    {
//        var res = new List<List<string>>();
//        bool flag = false;
//        switch (Id)
//        {
//            case 0:
//                res.Add(new List<string> { "Wheat flour", "Sieve. Add to other ingredients." });
//                break;

//            case 1:
//                res.Add(new List<string> { "Coconut flour", "Sieve. Add to other ingredients." });
//                break;

//            case 2:
//                res.Add(new List<string> { "Butter", "Melt on low heat. Add to other ingredients." });
//                break;

//            case 3:
//                res.Add(new List<string> { "Chocolate", "Melt in a water bath. Add to other ingredients." });
//                break;

//            case 4:
//                res.Add(new List<string> { "Sugar", "Add to other ingredients." });
//                break;

//            case 5:
//                res.Add(new List<string> { "Cardamom", "Take half a teaspoon. Add to other ingredients." });
//                break;

//            case 6:
//                res.Add(new List<string> { "Cinnamon", "Take half a teaspoon. Add to other ingredients." });
//                break;

//            case 7:
//                res.Add(new List<string> { "Cocoa powder", "Add to other ingredients." });
//                break;

//        }

//        return res;
//    }


//}


using System;
using System.Collections.Generic;
using System.IO;

enum FileFormat
{
    Txt,
    Json
}

class Program
{
    static void Main(string[] args)
    {
        var myFirstCookBook = new CookieCookBook();
        myFirstCookBook.LoadRecipes();
        myFirstCookBook.Generate();
        Console.ReadKey();
    }
}

public class CookieCookBook
{
    private const FileFormat fileFormat = FileFormat.Txt;
    private const string fileName = "recipes." + (fileFormat == FileFormat.Txt ? "txt" : "json");

    public List<Recipe> Recipes { get; }
    public List<Ingredient> AvailableIngredients { get; }

    public CookieCookBook()
    {
        Recipes = new List<Recipe>();
        AvailableIngredients = new List<Ingredient>()
        {
            new Ingredient(1, "Wheat flour"),
            new Ingredient(2, "Coconut flour"),
            new Ingredient(3, "Butter"),
            new Ingredient(4, "Chocolate"),
            new Ingredient(5, "Sugar"),
            new Ingredient(6, "Cardamom"),
            new Ingredient(7, "Cinnamon"),
            new Ingredient(8, "Cocoa powder")
        };
    }

    public void LoadRecipes()
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                List<int> ingredientIds = new List<int>();
                string[] ids = line.Split(',');
                foreach (string id in ids)
                {
                    ingredientIds.Add(int.Parse(id));
                }
                List<Ingredient> recipeIngredients = AvailableIngredients.FindAll(ing => ingredientIds.Contains(ing.Id));
                Recipes.Add(new Recipe(recipeIngredients));
            }
        }
    }

    public void Generate()
    {
        if (Recipes.Count > 0)
        {
            Console.WriteLine("Existing recipes are:\n");
            PrintRecipes();
            Console.WriteLine();
        }

        Console.WriteLine("Create a new cookie recipe! Available ingredients are:\n");
        PrintAvailableIngredients();

        var newRecipeIngredients = new List<Ingredient>();
        bool finished = false;

        do
        {
            Console.WriteLine("\nAdd an ingredient by its ID or type anything else if finished.");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int ingredientId))
            {
                Ingredient ingredient = AvailableIngredients.Find(ing => ing.Id == ingredientId);
                if (ingredient != null)
                {
                    newRecipeIngredients.Add(ingredient);
                    Console.WriteLine($"Ingredient '{ingredient.Name}' added to the recipe.");
                }
                else
                {
                    Console.WriteLine("Invalid ingredient ID. Please try again.");
                }
            }
            else
            {
                finished = true;
            }
        } while (!finished);

        if (newRecipeIngredients.Count == 0)
        {
            Console.WriteLine("\nNo ingredients have been selected. Recipe will not be saved.");
        }
        else
        {
            Console.WriteLine("\nCreating your Recipe!\n-----------------------------------");
            foreach (Ingredient ingredient in newRecipeIngredients)
            {
                Console.WriteLine($"{ingredient.Name}\t{ingredient.Instruction}");
            }

            Recipes.Add(new Recipe(newRecipeIngredients));
            SaveRecipes();
            Console.WriteLine($"Your recipe has been created and saved. Now you have {Recipes.Count} recipes.");
        }

        Console.WriteLine("\nPress any key to exit.");
    }

    private void PrintRecipes()
    {
        for (int i = 0; i < Recipes.Count; i++)
        {
            Console.WriteLine($"***** {i + 1} *****");
            PrintRecipe(Recipes[i]);
        }
    }

    private void PrintRecipe(Recipe recipe)
    {
        foreach (Ingredient ingredient in recipe.Ingredients)
        {
            Console.WriteLine($"{ingredient.Name}\t{ingredient.Instruction}");
        }
    }

    private void PrintAvailableIngredients()
    {
        foreach (Ingredient ingredient in AvailableIngredients)
        {
            Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
        }
    }

    private void SaveRecipes()
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Recipe recipe in Recipes)
            {
                List<int> ingredientIds = new List<int>();
                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    ingredientIds.Add(ingredient.Id);
                }
                writer.WriteLine(string.Join(",", ingredientIds));
            }
        }
    }
}

public class Recipe
{
    public List<Ingredient> Ingredients { get; }

    public Recipe(List<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }
}

public class Ingredient
{
    public int Id { get; }
    public string Name { get; }
    public string Instruction { get; }

    public Ingredient(int id, string name)
    {
        Id = id;
        Name = name;
        Instruction = GetIngredientInfo(id);
    }

    private string GetIngredientInfo(int id)
    {
        switch (id)
        {
            case 1:
                return "Sieve. Add to other ingredients.";
            case 2:
                return "Sieve. Add to other ingredients.";
            case 3:
                return "Melt on low heat. Add to other ingredients.";
            case 4:
                return "Melt in a water bath. Add to other ingredients.";
            case 5:
                return "Add to other ingredients.";
            case 6:
                return "Take half a teaspoon. Add to other ingredients.";
            case 7:
                return "Take half a teaspoon. Add to other ingredients.";
            case 8:
                return "Add to other ingredients.";
            default:
                return "Unknown instruction";
        }
    }
}

