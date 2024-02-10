using CookieCookBookSolution.Recipes.Ingredeients;

namespace CookieCookBookSolution.Recipes
{
    public class Recipe
    {
        // this is public and its dangerous because user can do recipe.ingreident.clear(); then we fucked
        //IEnumerable is an interface that is implemented by almost every collection c#;
        public IEnumerable<Ingredient> Ingredients { get; }
        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }
        public override string ToString()
        {
            var steps = new List<string>();
            foreach (var ingredient in Ingredients)
            {
                steps.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
            }
            return string.Join(Environment.NewLine, steps);
        }
    }
}
