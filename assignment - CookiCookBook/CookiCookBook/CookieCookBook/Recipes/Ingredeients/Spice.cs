﻿namespace CookieCookBookSolution.Recipes.Ingredeients
{
    public abstract class Spice : Ingredient
    {
        public override string PreparationInstructions =>
        $"Take half a teaspoon. {base.PreparationInstructions}";
    }
}
