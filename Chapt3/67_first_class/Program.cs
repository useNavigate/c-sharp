

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



var rectangle1 = new Rectangle(5,10);

Console.WriteLine("Width is "+ rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);


var rectangle2 = new Rectangle(7, 14);

Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Height is " + rectangle2.Height);


Console.ReadKey();

class Rectangle
{
    
    public int Width;
    public int Height;

    //adding contructor
    /*
     1. it must be named the same as the type it belongs to 
     2. no boid or any type name 
     */

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    
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