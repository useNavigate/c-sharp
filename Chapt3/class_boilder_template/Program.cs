using System;

// Namespace declaration
namespace YourNamespace
{
    // Class declaration
    public class YourClassName
    {
        // Fields (private variables)
        private int _exampleInt;
        private string _exampleString;

        // Properties
        public int ExampleInt
        {
            get { return _exampleInt; }
            set { _exampleInt = value; }
        }

        //public int ExampleProperty { get; private set; }
        public string ExampleString
        {
            get { return _exampleString; }
            set { _exampleString = value; }
        }

        // Constructor(s)
        public YourClassName()
        {
            // Default constructor (if needed)
        }

        // Parameterized constructor
        public YourClassName(int exampleInt, string exampleString)
        {
            _exampleInt = exampleInt;
            _exampleString = exampleString;
        }

        // Methods
        public void ExampleMethod()
        {
            // Method logic goes here
            Console.WriteLine("Example method called");
        }

        // Additional methods...

        // Destructor (if needed)
        ~YourClassName()
        {
            // Destructor logic goes here
        }
    }
}
