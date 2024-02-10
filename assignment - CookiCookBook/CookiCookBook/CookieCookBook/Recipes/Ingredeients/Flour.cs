namespace CookieCookBookSolution.Recipes.Ingredeients
{
    public abstract class Flour : Ingredient
    {
        public override string PreparationInstructions => $"Sieve. {base.PreparationInstructions}";


    }
}
