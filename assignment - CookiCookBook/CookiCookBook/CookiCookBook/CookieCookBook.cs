
    public class CookieCookBook : IPrint
    {
        private FileFormat fileFormat = FileFormat.Txt;
        private string fileName;

        private List<Recipe> Recipes { get; }
        private List<Ingredient> Basket { get; }
        public CookieCookBook()
        {
            Recipes = new List<Recipe>();
            Basket = new List<Ingredient>();
            fileName = "recipes." + (fileFormat == FileFormat.Txt ? "txt" : "json");
        }
        public void Generate()
        {
            FileHandler.LoadRecipes(Recipes, fileName);
            if (File.Exists(fileName))
            {
                Console.WriteLine($"You have {Recipes.Count} saved recipes");
                for (int i = 0; i < Recipes.Count; i++)
                {
                    Recipe recipe = Recipes[i];
                    Console.WriteLine($"***** {i + 1} *****");
                    PrintSavedRecipes(recipe);
                }
            }
            else
            {
                PrintNoSavedItem();
            }
            var flag = true;
            do
            {
                PrintCreateRecipe();
                var userInput = Console.ReadLine();
                int number;
                bool isValid = int.TryParse(userInput, out number) && number <= 8 && number >= 1;
                if (isValid)
                {
                    Basket.Add(new Ingredient(number));
                    PrintAddedItem(userInput);
                }
                else
                {
                    if (Basket.Count == 0)
                    {
                        PrintUnableToSave();
                    }
                    else
                    {
                        Console.WriteLine("Creating your Recipes!\n-----------------------------------");
                        foreach (Ingredient ingredient in Basket)
                        {
                            Console.WriteLine($"{ingredient.Name}\t{ingredient.Instruction}");
                        }
                        var newRecipe = new Recipe(Basket);
                        Recipes.Add(newRecipe);
                        FileHandler.SaveRecipes(Recipes, fileName);
                        Console.WriteLine($"Your recipe has been created now you have {Recipes.Count} recipes");
                        flag = false;

                    }
                }

            } while (flag);
            Console.WriteLine($"Press any key to exit.");
        }



        static void PrintNoSavedItem()
        {
            Console.WriteLine("You Do Not Have Any Saved Recipes\nCreate One Now!\nPress Any Button To Continue!");
            Console.ReadLine();
            Console.Clear();
        }

        static void PrintSavedRecipes(Recipe recipe)
        {
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}\t{ingredient.Instruction}");
            }
        }
        static void PrintCreateRecipe()
        {
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:\n1. Wheat flour\n2. Coconut flour\n3. Butter\n4. Chocolate\n5. Sugar\n6. Cardamom\n7. Cinnamon\n8. Cocoa Powder");

        }
        static void PrintUnableToSave()
        {
            Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            Console.WriteLine("No recipe is saved.");
        }

        static void PrintAddedItem(string userInput)
        {
            Console.WriteLine($"Item #{userInput} has been added to your list ");
        }
    }

