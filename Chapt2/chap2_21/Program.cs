//20-how to use debugger 

//how to parse 

Console.WriteLine("Provide a number.");
//string userInput = Console.ReadLine();
//int number = int.Parse(userInput)
//Console.WriteLine("What do you want to do?");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//string userChoice = Console.ReadLine();
//bool isLong = IsLong(userChoice);

//bool IsLong(string input)
//{
//    return input.Length > 10;
//}

////boolean 
//bool isUserInputAbc = userChoice == "ABC";


////methods 
//if (userChoice == "S")
//{
//    printSelectedOption("see all TODOs");
//}
//else if (userChoice == "A")
//{
//    printSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    printSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E") {
//    printSelectedOption("Exit");
//}

////method should always start with capital letter 
//void printSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected Option: " + selectedOption);
//}

//int Add(int a, int b)
//{
//    return a + b;
//}
////debugging : F10 => step over method, F11=> step into method
//var res = Add(10, 5);
//Console.WriteLine("10 + 5 = {0}", res);


////bool IsLong(string input)
////{
////    return input.Length > 10;
////}

////-----------------------------method part3


///*
// * 
//- Runtime Errors happen when the application is running
//- Compilation errors happen during the compilation.

// */

int a = 4, b = 2, c = 10;
Console.WriteLine($"First is: {a}, second is: {b}, third is: {c}");
Console.ReadKey();

//do while loop

string word;
do
{
    Console.WriteLine("Enter a word longer than 10 letters");
    word = Console.ReadLine();
} while (word.Length <= 10);

Console.WriteLine("The loop is finished");
Console.ReadKey();
