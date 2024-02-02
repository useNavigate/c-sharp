


var todos = new List<string>();
bool shutDown = false;

string MainPage()
{
    Console.WriteLine("Hello!\nWhat do you want to do?\n[S]ee all TODOs\n[A]dd a TODO\n[R]emove a TODO\n[E]xit");
    var userInput = Console.ReadLine();

    var validate = new[] { "S", "s", "A", "a", "R", "r", "E", "e" };

    while (Array.IndexOf(validate, userInput) == -1)
    {
        Console.WriteLine("Invalid Input. Please enter a valid option.");
        userInput = Console.ReadLine();

        if (Array.IndexOf(validate, userInput) > -1)
        {
            break;
        }
    }
    return userInput;
}




void A_Listner(string userInput)
{
    if (userInput.ToLower() == "a")
    {
        string todo;

        do
        {
            Console.WriteLine("Please insert todo");
            todo = Console.ReadLine();

            var duplicated = todos.Contains(todo);

            if (duplicated)
            {
                Console.WriteLine("You already have this in your list");
            }
            else if (todo.Length == 0)
            {
                Console.WriteLine("Description cannot be empty");
            }
            else
            {
                todos.Add(todo);
                Console.WriteLine("\nTODO successfully added `{0}` to the list", todo);
                Console.WriteLine("\nPress Any Key to Continue");
                Console.ReadLine();
                break;  // Break out of the loop if a valid input is provided
            }


        } while (true);

        Console.Clear();
    }
}

void S_Listener(string userInput)
{
    if (userInput.ToLower() == "s")
    {
        Console.Clear();

        if (todos.Count == 0)
        {
            Console.WriteLine("You do not have any todos \n");
        }
        else
        {
            Console.WriteLine("Here is your Todos ");
            for (int i = 0; i < todos.Count; ++i)
            {
                Console.WriteLine($"{i + 1} : {todos[i]}");
            }

        }

        Console.WriteLine("Press Any Key to Continue");
        Console.ReadLine();
        Console.Clear();


    }






}

void E_Listener(string userInput)
{
    if (userInput == "e" || userInput == "E")
    {
        Console.Clear();
        shutDown = true;
        Console.WriteLine(".... Shutting Down");

    }


}

void R_Listener(string userInput)
{
    if (userInput == "r" || userInput == "R")
    {

        Console.Clear();
        if (todos.Count == 0)
        {
            Console.WriteLine("Your Todo list is empty please add something first");
        }
        else
        {
            Console.WriteLine("Select the index of the TODO you want to remove: ");

            for (int i = 0; i < todos.Count; ++i)
            {
                Console.WriteLine($"{i + 1} : {todos[i]}");
            }

        }
        var removeItem = Console.ReadLine();
        var isPossibleToRemove = int.TryParse(removeItem, out int number);

        if (isPossibleToRemove)
        {
            //if its invalid index
            if (isPossibleToRemove && number >= 1 && number <= todos.Count)
            {
                Console.Clear();
                Console.WriteLine("TODO removed :{0}", todos[number - 1]);
                todos.RemoveAt(number - 1);
            }

        }
        else if (removeItem.Length == 0)
        {

            Console.WriteLine("Selected index cananot be empty");
        }
        else
        {
            Console.WriteLine("The given index is not valid ");
        }


    }
}

while (!shutDown)
{
    string userInput = MainPage();
    A_Listner(userInput);
    S_Listener(userInput);
    R_Listener(userInput);
    E_Listener(userInput);

}


Console.ReadLine();