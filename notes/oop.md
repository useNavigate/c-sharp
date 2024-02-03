## Basics of Object-Oriented Programming:

### Issues in Code & Need for OOP:
- **Procedural Programming:** Emphasizes procedures and routines.
- **Issues:** Lack of modularity, code redundancy, difficulty in code maintenance.

### Antipatterns:
- **Antipattern:** A common solution to a recurring problem that turns out to be counterproductive.
- **Spaghetti Code Antipattern:** Unstructured and difficult-to-maintain code.

### High-Quality Code:
- **Must Always Be Ready For:**
  - Change
  - Maintenance
  - Scalability

## Introduction to Object-Oriented Programming:

### What is OOP:
- **Object-Oriented Programming:** A paradigm based on the concept of "objects" that can contain data, in the form of fields (attributes), and code, in the form of procedures (methods).
- **Benefits:** Modularity, code reuse, easier maintenance, and scalability.

### Understanding OOP with DateTime Type:
- **DateTime Type:** Example of OOP in practice.
- **Constructor:** Special method for initializing objects.

## Abstraction:

### What is Abstraction:
- **Abstraction:** Hiding implementation details from users.
- **Benefits:** Simplifies complexity, focuses on essential features.

## Our First Class:

### Defining a Class:
- **Class:** Blueprint for objects.
- **Fields:** Data members of a class.
- **Default Constructor:** Automatically created if not defined.

## Data Hiding:

### What is Data Hiding:
- **Data Hiding:** Restricting access to internal details.
- **Access Modifiers:** Control visibility (public, private).
- **Default Access Modifier for Fields:** Private.

### Custom Constructor:
- **Custom Constructors:** User-defined, allow customization.
- **Naming Fields:** Follow recommended naming conventions.

## C# Restriction on Code Outside Classes:

### Top-Level Statements:
- **Top-Level Statements:** Introduced in C# to write code outside classes.

## Methods in Classes:

### Defining Methods:
- **Methods:** Functions within classes.
- **Naming:** Follow conventions.
- **Default Access Modifiers:** Private by default.

## Encapsulation:

### What is Encapsulation:
- **Encapsulation:** Bundling data and methods that operate on the data.
- **Different from Data Hiding:** Involves exposing the internal representation while restricting access.

## Methods Overloading:

### What is Methods Overloading:
- **Methods Overloading:** Defining multiple methods with the same name but different parameters.
- **Rules:** Different parameter types, number of parameters, or order.

### Constructors Overloading:
- **Constructors Overloading:** Defining multiple constructors in a class.
- **"this" Keyword:** Used to call one constructor from another.

## Expression-Bodied Methods:

### Expression-Bodied Methods:
- **Shorter Methods:** Convert to expression-bodied methods.
- **Difference:** Expression returns a value; a statement does not.

### "this" Keyword (Current Instance Reference):
- **"this" Keyword:** Refers to the current instance of a class.

## Optional Parameters:

### Optional Parameters:
- **Define Optional Parameters:** Specify default values.

### Validation of Constructor Parameters:
- **Validate Constructor Parameters:** Ensure valid inputs.
- **nameof Expression:** Retrieves the name of a variable.

### Readonly and Const:
- **Readonly:** Prevents modification after initialization.
- **Const:** Compile-time constant, cannot be changed.

## Limitations of Fields:

### Limitations:
- **Need for Properties:** Direct access can be risky.

## Properties:

### What are Properties:
- **Properties:** Accessors for private fields.
- **Backing Field:** Holds the actual data.
- **Differences from Fields:** Allows controlled access, validation, and computation.
- **When to Use Fields or Properties:** Use properties for controlled access and validation.



```c#
using System;

public class Person
{
    // Fields
    private string firstName;
    private string lastName;
    private DateTime birthDate;

    // Properties
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return CalculateAge(); }
    }

    // Constructors
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    // Methods
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Age: {Age} years");
    }

    private int CalculateAge()
    {
        // Calculate age based on birthdate
        return DateTime.Now.Year - birthDate.Year;
    }
}


```
