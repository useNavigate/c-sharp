

/*
1.Data hiding means making the members of a class non-public. 

2.Class members are anything that a class contains, especially fields and methods. 

3.we should only make a member public if it is necessary.

4. making class members public can be a source of risk

5. to control who can access componets of a class, we use the access modifires. 
 - ex) public, private, protected

6. PRIVATE members can only be accessed from within the class it belongs to. 

7. PUBLIC members can only be accessed everywhere.


*/


/*
 * 👇field variables 
 *  int width;
    int height;

- a field is a variable that belongs to an object of a class
- we declared two fields of type interger.

 if we don't initialize a field, it is automatically set to the default value (0) of its type 
and default access modifires set to private
 */


/*
 ENCAPSULATION:
 - building data with methods that operate on it in the same class.
 - Encapsulation may enable data hiding 

 DATA HIDING:
 - Making fields private instead of public.
 
 
 
 */


var rectangle1 = new Rectangle(5,10);
var rectangle2 = new Rectangle(50, 100);

Console.WriteLine("Count of recs " + Rectangle.CountOfInstances);

//Console.WriteLine(Rectangle.DescribeGenerally());
//Console.WriteLine("Width is "+ rectangle1.Width);
//Console.WriteLine("----------Width is " + rectangle1.Width);
//Console.WriteLine("Height is " + rectangle1.GetHeight());
//Console.WriteLine("Width is " + rectangle1.CalculateArea());
//Console.WriteLine("Height is " + rectangle1.CalculateCircumference());


//Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
//Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
//Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");


Console.ReadKey();

/*
 static methods belong to a class as a whole, not to a specific instance. 

 static methods can't use the instance data (value of fields or returned by properties)
    
 static classes can only contain static methods.

BUT 

 Non-static classes can contain static methods.

 if a private method doesn't use instance data, make it static.
 
 */
static class Calculator
{
    /*
     A static class cannot be instantiated; it only works as a container for methods.
     */
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

}

//statefull
class Rectangle
{
    //readonly make it immutable
    //adding contructor
    /*
     1. it must be named the same as the type it belongs to 
     2. no boid or any type name 
     */

    //static properties
    public static int CountOfInstances { get; private set; }
    private static DateTime _firstUsed  = DateTime.Now;
    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
        ++CountOfInstances; 
    }
    
    
    /*
     * way 1. 
     👇 the name of the property should always start with a captial letter no matter if itis private or not.
     name should be noun
     old way to do make property
     ~code~

    public int Width
    {
        get { return _width; }
        private set { _width = value; }
    }


    //👇backing field
    public int _width;

    * way 2
     
    private int _width;
     public int Width
     {
        get => _width;
        set => _width = value;
     }
    */



    //new way to make property ; you do not need backing field for mondern way 
    public int Width { get; private set; }
    private int _height;
    public int GetHeight() => _height;

    public void setHeight(int value)
    {
        Width = 10;
        if (value > 0)
        {
            _height = value;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int DefaultValueIfNonPositive = 1;

        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number");
            return  DefaultValueIfNonPositive;
        }
        return length;
    }

    //expression bodied method === arrow func
    public int CalculateCircumference() =>  2 * Width + 2 * _height;
    public int CalculateArea() =>  Width * _height;


    //creating get-only property
    public string Description => $"A rectangle with width {Width} " + $"and height {_height}";

    public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles.";

    public string NotUsingAnyState() => "abc";

    public const int NumberOfSindes = 4;
    // all Const fields are implicitly static.


}




/*
 

Properties of the Order class
The goal of this exercise is to finish the implementation of the Order class. 
It represents a simple Order made in a store, and it needs to have two properties:

- Item (string), which should not be settable at all

- Date (DateTime), which should be both gettable and settable. Its setter should validate if the given value has the same year as the current year. If not, the value of the Date property should not be changed.

Your job is only to add the definitions of those two properties. If needed, you can add backing fields as well
 
 */

public class Order
{
    private string _item;
    private DateTime _date;

    //getter 
    public string Item { get { return _item; } }

    public DateTime Date
    {
        get { return _date; }
        set
        {
            if (value.Year == DateTime.Now.Year)
            {
                _date = value;
            }

        }
    }

    public Order(string item, DateTime date)
    {
        _item = item;
        _date = date;
    }
}



/*
 HotelBooking class
Define a HotelBooking class, which will contain the following fields that must be accessible outside of this class:

- GuestName (string)

- StartDate and EndDate (DateTimes)

The constructor of this class should take the following parameters (please maintain the given order and names):

- guestName (string)

- startDate (DateTime)

- lengthOfStayInDays (int)

The constructor should set all fields of this class.

The EndDate should be calculated in the constructor as the StartDate plus the lengthOfStayInDays . 
You can use the AddDays method from the DateTime type to calculate it. 
You can do it right in the constructor body. 
 */

public class HotelBooking
{

    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = StartDate.AddDays(lengthOfStayInDays);

    }
}