//target-typed new expression
/*the reason why we wouldnt initialize properties right away without contructor is that
  what if we need to modify app to have graphical interface instead of console? then we might need have to modify the code.
  you need to think about scability

1.our current CookiesRecipes App breaks the law of SOLID
2. the CookiesRecipeApp and the RecipeConsoleUserInteraction are tightly `coupled now`
    - `coupling` is the degree of `interdependence` between classs, a measure of how closely they are connected.
    - `coupling` of classes akes themm less reusable because we can't use one class without involving the other.  
    - it also makes the code more brittle as changing one class may make the other class stop. 

3. Dependency Inversion Principle ( D in Solid) 
    - The Dependency Inversion Principle states that high-level modules should not depend on low-level modules; both should depend on abstractions. 
    - The dependencies of a tye `should not be concrete`; they should be `abstraction`
    - Dependency inversion is a principle saying that types should depend on abstractions not on concrete types 

4. Dependency Injection 
    - means the class is given the dependencies it needs; it doesn't create them itself. 
5. Design pattern is a typical solution  to a commonly occuring problem in software design 
  */

using CookieCookBookSolution.Recipes;
using CookieCookBookSolution.Recipes.Ingredeients;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;

var cookiesRecipesApp = new CookiesRecipesApp( new RecipesReposiory(),new RecipesConsoleUserInteraction(new IngredientsRegister()));
cookiesRecipesApp.Run("recipes.txt");


public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository;
    //this interface will expose a set of methods that we need to communicate with the user
    //depedency injection 
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    //by making constructor now the cookiesRecipesApp is completely decoupled from the recipesConsoleUserInteraction class
    public CookiesRecipesApp(
        IRecipesRepository recipesRepository,
        IRecipesUserInteraction recipesConsolUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesConsolUserInteraction;
    }
    public void Run(string filePath)
    {
        //1.reading all the recipes 
        var allRecipes = _recipesRepository.Read(filePath);

        //2. printing the existing recipes
        _recipesUserInteraction.PrintingExistingRecipes(allRecipes);

        //3. prompting the user to create a recipe
        _recipesUserInteraction.PromptToCreateRecipe();

        ////4.prompting the user to create a recipe 
        //var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        ////5. checking if user selected any ingredients 
        //if (ingredients.Count > 0)
        //{
        //    var recipes = new Recipe(ingredients);
        //    allRecipes.Add(recipe);
        //    _recipesRepository.Write(filePath,allRecipes);

        //    _recipesUserInteraction.ShowMessage("Recipe added:");
        //    _recipesUserInteraction.ShowMessage(recipes.ToString());

        //}
        //else
        //{
        //    _recipesUserInteraction.ShowMessage("No ingredients have been selected. " + "Recipe will not be saeved.");
        //}

        _recipesUserInteraction.Exit();
    }
}



public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintingExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
}

public class IngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder(),
    };
}
public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IngredientsRegister _ingredientsRegister;

    public RecipesConsoleUserInteraction(
        IngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintingExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are :" + Environment.NewLine);

            var counter = 1;
            foreach (var recipe in allRecipes)
            {
                Console.WriteLine($"****{counter}****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                ++counter;
            }
        }
        //the Count method is an extension method for the IEnumerable type.  As we learned before
        // it comes from the `LINQ` library living in the `System.Linq` namespace.
        // LINQ is a crucial c# library, allowing us to work with collections easily and effecctively. 

    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " + "Available ingredients are :");
        foreach (var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }
}

public interface IRecipesRepository
{
    List<Recipe> Read(string filepath);
}
internal class RecipesReposiory : IRecipesRepository
{
    public List<Recipe> Read(string filepath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Butter(),
                new Sugar()
            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(),
                new SpeltFlour(),
                new Cinnamon()
            })
        };
    }
}