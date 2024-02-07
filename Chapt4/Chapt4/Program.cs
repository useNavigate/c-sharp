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

//var pizza = new Pizza();

//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSauce());
//Console.WriteLine(pizza.Describe());

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(),
//    new Mozzarella(),
//    new TomatoSauce()
//};

//foreach (Ingredient ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

//var cheddar = new Cheddar();
//Console.WriteLine(cheddar);
//Console.WriteLine(new List<int>());

//var ingredient = new Ingredient(1);


//var cheddar = new Cheddar(2,8);
/*
 cheddar 
1. it will call the base class first with argument 
2. then the constructor from the Cheddar class will be called
3. 
 */


//-------casting

//int seasonNumber = 0;

//explicit cast expression
//Season spring = (Season)seasonNumber;

//decimal is used to repreent precisely floating -point numbers
// m stands for money.

//decimal a = 10.01m; 

//int integer = 10;
/*
 implicit conversion happens here
 Implicit Conversion can only happen if conversion from one type to another is safe and lossless.
*/
//decimal b = integer;
//decimal c = 10.01m;
//int d = (int)c;

//int secondSeasonNumber = 11;
//Season summer = (Season)secondSeasonNumber;
//Console.WriteLine(summer); // it will console out 11 
//implicitly casting does not give us any error so it s best to use explicit casting 

// casting ------------


//upcasting ---------------
//Ingredient ingredient = new Cheddar(2, 12);
//Ingredient randomIngredient = GenerateRandomIngredient();
//Console.WriteLine("Random ingredeint is" + randomIngredient);


//Cheddar cheddar = (Cheddar)randomIngredient;
//Console.WriteLine("Cheddar --" + cheddar);
//------------------------


//112 `is`-----------
//Ingredient ingredient = new Cheddar(2, 12);
//Ingredient randomIngredient = GenerateRandomIngredient();
//Console.WriteLine("Random ingredeint is" + randomIngredient);

//Console.WriteLine("is object? " +(ingredient is object));
//Console.WriteLine("is ingredient? " +(ingredient is Ingredient));
//Console.WriteLine("is cheddar? " + (ingredient is Cheddar));
//Console.WriteLine("is Mozzarella ? " + (ingredient is Mozzarella));
//Console.WriteLine("is tomato sauce? " + (ingredient is TomatoSauce));

//Cheddar cheddar = (Cheddar)randomIngredient;


//if (randomIngredient is Cheddar cheddar)
//{
//    Console.WriteLine("Cheddar object: " + cheddar);
//}



/*var pizza = new Pizza();
Ingredient nullIsgredient = null;

if (nullIsgredient is not null)
{
    Console.WriteLine(nullIsgredient.Name);
}


*/
//is -----------------------------------------------------|

//as -----------------------------------------------------| 

//Ingredient ingredient = GenerateRandomIngredient();
//Console.WriteLine("Ingredient is " + ingredient);
////Cheddar cheddar = (Cheddar)Ingredient //=> will cause an exception if cast fails. => works with any type but gives a runtime error if cast fails
//Cheddar cheddar = ingredient as Cheddar; //=> will give null if cast fails => only works for cast to nullable types.

////int number = ingredient as int; //=> wont work because int cannot be assigned as Null

//if (cheddar is not null)
//{
//    Console.WriteLine(cheddar.Name);
//}
//else
//{
//    Console.WriteLine("Conversioin failed");
//}


//-----------------------------------------------------|






//abstract class --------------------------------------|





//Ingredient GenerateRandomIngredient()
//{
//    var random = new Random();
//    var number = random.Next(1, 4);
//    if (number == 1) { return new Cheddar(2, 12); }
//    if (number == 2) { return new TomatoSauce(1); }
//    else return new Mozzarella(2);
//}

////Decimal is used to represent precisely floating-point numbers.



//EXTENDS---------------
//using Chapt4.Extensions;
//var multilineText = @"aaaa
//bbbb
//cccc
//dddd";
//Console.WriteLine("Count of lines is " + multilineText.CountLines());



//Console.WriteLine("Next after Spring is " + Season.Spring.Next());

//Console.ReadKey();
//public enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

//var cheddar = new Cheddar(2, 12);
//var tomatoSauce = new TomatoSauce(1);
//cheddar.Prepare();
//tomatoSauce.Prepare();


Console.ReadKey();

var bakeableDishes = new List<object>
{
    new Pizza(),
    new Panettone()
};

foreach(var bakeableDish in bakeableDishes)
{
    Console.WriteLine(bakeableDish.GetInstructions());
}
public abstract class Dessert { }

public abstract class Bakeable
{
    public abstract string GenInstructions();
}


public class Panettone : Dessert
{ 
}

public class Pizza
{
    //these will set to default value; 

    //public int number;
    //public DateTime date;

    public Ingredient ingredient;

    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);
    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}


//Abstract classes cannot be instantiated. They only serve as base calsses for other more concrete types
public abstract class Ingredient
{
    public Ingredient(int priceIfExtraOpping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraOpping = priceIfExtraOpping;
    }

    public int PriceIfExtraOpping { get; }

    //we are overiding ToString! 
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some  ingredient";


    //all abstract methods are implicitly virtual, which means it is possible to override them in the derived 
    // Must be overridden in non-abstract derived classes.

    /*virtual methods can defined two ways : by adding the virtual modifier or by adding the abstract modifier
     
    VIRTUAL MODIFIRE : 
      - must have an implemnetation.
      - Overriding it is optional.
    

    ABSTRACT MODIFIRE : 
    - can't have an implementation.
    - overridding  it is obligatory. 

    Usually when people talk about virtual  methods, they mean methods with the virtual modifire, 
    even if technincally abstract methods are virtual as well. 
    

     */
    public abstract  void Prepare();


    public int PublicField;
    public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() => "This method is Protected in the Ingredient class.";
    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class.";
}

    //we can only skipovverriding the abstract method from the base class if the derived class is abstract itself.
public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtraOpping) : base(priceIfExtraOpping)
    {

    }
}

/*
 Protected members can be used in the derived classes, but they can't be used outside;
 */
public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Cheddar class");
 
    }

    /*
     when we do console.writeLine under the hood it use toString
    our base class Ingredient has this line public override string ToString() => Name; 
    which monkeypatching the ToString method , so when we do console.writeline its actually showing the name 
     */
    public override string Name => $"{base.Name}, more specifically, a Cheddar cheese aged for {AgedForMonths}";
    public int AgedForMonths { get; }

    public override void Prepare() => Console.WriteLine("Grate and sprinkle over pizza");

    public void UseMethodsFromBaeClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}


public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraOpping) : base(priceIfExtraOpping)
    {
    }

    public override string Name => "Tomato Sauce";
    public int AgedForMonths { get; }
    public sealed override void Prepare() => Console.WriteLine("Coook tomatoes with basil, garlic and salt. " + "Spread on pizza.");
}

public class SpecialTomatoSauce : TomatoSauce
{
    public SpecialTomatoSauce(int priceIfExtraOpping) : base(priceIfExtraOpping)
    {

    }
    
}
public class ItalianFoodItem
{ 

}

// Only virtual members can be overridden
// all abstract methods are implicitly virtual. 


public sealed class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraOpping) : base(priceIfExtraOpping)
    {
    }

    public override string Name => "Mozarella";
    public bool IsLight { get; }

    public override void Prepare()
    {
        Console.WriteLine("Slice thinly and place on top of the pizza.");

    }
}
