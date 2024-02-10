namespace CookieCookBookSolution.Recipes.Ingredeients
{
    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }

        //this defines a getter-only property.
        public virtual string PreparationInstructions => "Add to other ingredients";

    }
}
