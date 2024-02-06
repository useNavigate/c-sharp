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

## Object Initializer:

**What Object Initializers Are:**
- Object Initializers: A concise syntax for initializing object properties. (only works with public setter)
- Purpose of `init` Accessor: Introduced in C# 9.0, used for properties that can only be set during object initialization.

```csharp
public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
}

// Usage
var person = new Person { FirstName = "John", LastName = "Doe" };
```



## The purpose of the init accessor
The `init` accessor is used in C# to create immutable properties during object initialization. It allows setting the value of a property during object creation but prevents subsequent modification.

```csharp
// Example of using init accessor
public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }
}

```


# Computed Properties

## How to create computed properties
Computed properties are created by defining a property that calculates its value based on other properties or logic within the class.

```csharp
// Example of computed property in C#
public class Circle
{
    public double Radius { get; set; }

    public double Area => Math.PI * Math.Pow(Radius, 2);
}

```


## When to use parameterless methods, and when computed properties
Parameterless methods are suitable when the computation does not depend on the object's state, while computed properties are preferred when the computation involves the object's properties or internal logic.

# Static Methods and Classes

## What static methods are
Static methods belong to a class rather than an instance, and they can be called without creating an object of the class.


```csharp
// Example of static method in C#
public class MathOperations
{
    public static int Add(int a, int b) => a + b;
}

```


## What static classes are
A static class is a class that cannot be instantiated, and all its members must be static. It is commonly used to group related methods and properties.

```csharp
// Example of static class in C#
public static class Utility
{
    public static void LogMessage(string message) => Console.WriteLine(message);
}

```

## Limitations of static methods
Static methods cannot access instance-specific data and are shared across all instances of the class, which may lead to issues in multithreading scenarios.

## Why all const fields are implicitly static
Const fields are implicitly static because their values are constant and shared among all instances of the class, making them suitable for static context.

# Static Fields, Properties, and Constructors

## What static fields and properties are
Static fields and properties are shared among all instances of a class, rather than belonging to a specific instance.

```csharp
// Example of static field and property in C#
public class Counter
{
    public static int InstanceCount { get; private set; } = 0;

    public Counter()
    {
        InstanceCount++;
    }
}

```



## What a static constructor is
A static constructor is used to initialize static members of a class and is called once before any static members are accessed or any static methods are called.


```csharp
// Example of static constructor in C#
public class Configuration
{
    public static string ServerUrl { get; private set; }

    static Configuration()
    {
        ServerUrl = LoadServerUrlFromConfig();
    }

    private static string LoadServerUrlFromConfig()
    {
        // Logic to load server URL from configuration
    }
}

```


## Whether using static fields and properties is a good or bad practice
Using static fields and properties is context-dependent. While they are useful for shared data, misuse can lead to maintainability issues and hinder testability.

# Single Responsibility Principle - Introduction

## What the Single Responsibility Principle is (S in SOLID)
The Single Responsibility Principle (S) states that a class should have only one reason to change, meaning it should have only one responsibility or job.

```csharp
// Example violating SRP
public class Report
{
    public string Content { get; set; }

    public void SaveToFile(string filePath)
    {
        // Logic to save report content to a file
    }

    public void Print()
    {
        // Logic to print the report
    }
}

```

## What SOLID principles are
SOLID is an acronym representing a set of five design principles in object-oriented programming: Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, and Dependency Inversion.

## How to read from and write to a text file
Reading from and writing to a text file involves using input/output operations in the programming language of choice. Commonly, this is done using classes or libraries that handle file operations.

# Single Responsibility Principle - Refactoring (Part 1)

## How to perform step-by-step refactoring of a class to meet the Single Responsibility Principle
Refactoring to meet the Single Responsibility Principle involves identifying distinct responsibilities within a class and extracting them into separate classes or modules.

```csharp
// Example after refactoring to meet SRP
public class Report
{
    public string Content { get; set; }
}

public class ReportSaver
{
    public void SaveToFile(Report report, string filePath)
    {
        // Logic to save report content to a file
    }
}

public class ReportPrinter
{
    public void Print(Report report)
    {
        // Logic to print the report
    }
}

```

## What a repository is
A repository is a design pattern that separates the logic that retrieves data from the underlying storage (database, file, etc.) from the rest of the application.

## What the new line symbol for Unix and non-Unix systems is
The new line symbol for Unix systems is `\n`, while for non-Unix systems (like Windows), it is `\r\n`.

# Single Responsibility Principle - Refactoring (Part 2)

## Recommended order of methods in a class
A common recommended order for methods in a class is to start with public methods, followed by protected and private methods. Constructors often come first.

```csharp
public class OrderProcessor
{
    // Constructors come first
    public OrderProcessor(Order order)
    {
        // Initialization logic
    }

    // Public methods come next
    public void ProcessOrder()
    {
        // Logic to process the order
    }

    // Protected and private methods come last
    private void ValidateOrder()
    {
        // Validation logic
    }
}

```
## Risk of having some properties public, even only for getting
Exposing properties publicly, even for reading, can lead to a violation of encapsulation and may make it challenging to control or validate the state of an object.

# Single Responsibility Principle - Refactoring (Part 3)

## What the DRY principle is
The DRY (Don't Repeat Yourself) principle advocates for avoiding code duplication by creating reusable abstractions and promoting a single source of truth.
```csharp
// Example violating DRY
public class MathOperations
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;

    // Duplicate logic in both methods
    private int PerformOperation(int a, int b, Func<int, int, int> operation)
    {
        return operation(a, b);
    }
}

```


## When code duplications are not a bad thing
Code duplications may be acceptable in certain situations, such as when the duplicated code serves different purposes or when the effort to eliminate duplication outweighs the benefits.

# Files, Namespaces, Usings

## How to add new files to a project
Adding new files to a project typically involves using the IDE's file creation functionality or manually creating files and then adding them to the project.

## How to move classes to their own files
Moving classes to their own files can be done by creating a new file for each class and placing the class definition in that file.

## What namespaces are
Namespaces are a way to organize and group related classes, structures, interfaces, enumerations, and delegates in a hierarchical manner.

## What using directives are
Using directives in C# are used to specify which namespaces or types are used in the current code file.

## What file-scoped namespace declarations are
File-scoped namespace declarations in C# allow specifying the namespace at the file level without enclosing the entire file content within the namespace.

# Global Using Directives

## What global using directives are
Global using directives are used in C# to import namespaces globally across the entire project, making the specified types available without the need for individual using statements in each file.

## How to measure the time of code execution
Measuring the time of code execution can be achieved by capturing the current time before and after the code block, then calculating the time difference.


### Summary 108.inheriting constructors and the `base` keyword: Key Points on Constructors and Inheritance in C#

- Constructors are special methods executed at object creation.
- When a derived class object is created, both base and derived constructors are called.
- Base class constructor initializes common fields/properties, followed by the derived class constructor.
- Constructors can be customized to set specific state for both base and derived types.
- The "base" keyword is used to refer to the base class constructor or any accessible member.
- Errors occur when not passing arguments to constructors that require them.
- To resolve errors, pass arguments using the "base" keyword in derived class constructors.
- Derived class constructors can initialize properties specific to that class.
- Proper constructors should be generated in all derived classes.
- The "base" keyword can be used to refer to base class members accessible in derived classes.
- Derived classes can override base class properties/methods to add specific functionality.
- Derived classes are more specific versions of base classes, inheriting and extending their functionality.


```csharp
public class Ingredient
{
    // Base class constructor with an argument
    public Ingredient(int price)
    {
        Console.WriteLine($"Constructor from the Ingredient class with price: {price}");
    }
}

public class Cheddar : Ingredient
{
    // Derived class constructor with arguments using the "base" keyword
    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        Console.WriteLine($"Constructor from the Cheddar class with price for extra topping: {priceIfExtraTopping}, and aged for {agedForMonths} months");
    }
}
```

### Summary 109: Implicit Conversion in C#

- Implicit conversion occurs when a conversion is safe and lossless, without requiring special syntax like explicit cast expressions.
- In C#, there are two main kinds of conversion: implicit and explicit.
- Decimal is a numeric type used to represent floating-point numbers with high precision, often used for monetary values.
- Double is another floating-point numeric type in C#, which is less precise but faster than decimal.
- Decimal literals must be suffixed with the letter "M" to indicate the decimal type.
- Implicit conversion examples include assigning an integer value to a variable of type decimal.
- Implicit conversion from one type to another occurs behind the scenes without requiring special syntax.
- Implicit conversion can only occur if it is safe and lossless.
- It's essential for implicit conversion always to succeed and not modify or trim any data to avoid unexpected runtime behavior.

```csharp
int intValue = 10;
decimal decimalValue = intValue;
