//Polymorphism

/*
The provision of a single interface to entities of different types.

there is a generic concept of something (ingredient), and this concept can be made concrete by 
multiple types ( Cheddar, Mozzrella). 
All of them can be used wherever the generic concept is needed (in the ingredients list)


Inheritance

- inheritance enables us to create new classes that reuse, extend, and modify the behavior defined in other classes.
- The class whos members are inherited is called the BASE CLASS and 
  the class that inherits those members is called the DERIVED CLASS
 */

//var pizza = new Pizza();

//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.Describe());

//var cheddar = new Cheddar(); this code is implicitly set cheddar to Cheddar type 
//Console.WriteLine("Variable of type Cheddar");
//Cheddar cheddar = new Cheddar(); //setting the time explicitly;
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type Ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);



/*
 virtual methods or properties may be overridden  by the inheriting types
 */


var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozzarella(),
    new TomatoSauce()
};

foreach (Ingredient ingredient in ingredients)
{
    Console.WriteLine(ingredient.Name);
}
Console.ReadKey();
public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);
    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public virtual string Name { get; } = "Some  ingredient";
    public int PublicField;
    public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() => "This method is Protected in the Ingredient class.";
    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class.";
}

/*
 Protected members can be used in the derived classes, but they can't be used outside;
 */
public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
    public void UseMethodsFromBaeClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}


public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Sauce";
    public int AgedForMonths { get; }
}


public class Mozzarella : Ingredient
{
    public override string Name => "Mozarella";
    public bool IsLight { get; }
}
