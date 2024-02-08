public static class FileHandler
{
    public static void LoadRecipes(List<Recipe> Recipes, string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                List<Ingredient> ingredientIds = new List<Ingredient>();
                string[] ids = line.Split(',');
                foreach (string id in ids)
                {
                    var newIng = new Ingredient(int.Parse(id));
                    ingredientIds.Add(newIng);
                }

                Recipes.Add(new Recipe(ingredientIds));
            }
        }
    }

    public static void SaveRecipes(List<Recipe> Recipes, string fileName)
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

