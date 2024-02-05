
/*
 Single Responsbility Principle

- A class should be responsbile for only one thing.
- A class should have only one reason to change. 
 
 */

class NamesValidator
{
    public bool IsValid(string name)
    {
        return
            name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
}
