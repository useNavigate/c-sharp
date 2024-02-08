public class Ingredient
{
    public int Id { get; }
    public string Name;
    public string Instruction;

    public Ingredient(int id)
    {
        Id = id;
        var info = GetIngredientInfo(id);
        Name = info[0][0];
        Instruction = info[0][1];
    }

    private static List<List<string>> GetIngredientInfo(int Id)
    {
        var res = new List<List<string>>();

        switch (Id)
        {
            case 1:
                res.Add(new List<string> { "Wheat flour", "Sieve. Add to other ingredients." });
                break;

            case 2:
                res.Add(new List<string> { "Coconut flour", "Sieve. Add to other ingredients." });
                break;

            case 3:
                res.Add(new List<string> { "Butter", "Melt on low heat. Add to other ingredients." });
                break;

            case 4:
                res.Add(new List<string> { "Chocolate", "Melt in a water bath. Add to other ingredients." });
                break;

            case 5:
                res.Add(new List<string> { "Sugar", "Add to other ingredients." });
                break;

            case 6:
                res.Add(new List<string> { "Cardamom", "Take half a teaspoon. Add to other ingredients." });
                break;

            case 7:
                res.Add(new List<string> { "Cinnamon", "Take half a teaspoon. Add to other ingredients." });
                break;

            case 8:
                res.Add(new List<string> { "Cocoa powder", "Add to other ingredients." });
                break;

        }

        return res;
    }
}

