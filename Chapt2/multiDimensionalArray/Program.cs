char[,] letters = new char[2, 3];
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';


var height = letters.GetLength(0);
var width = letters.GetLength(1);
Console.WriteLine("Height is " + height);
Console.WriteLine("Wdith is " + width);

for (var i = 0; i < height; i++)
{
    Console.WriteLine("i : " +i);
    for (var j = 0; j < width; j++)
    {
        Console.WriteLine("j : " + j);
    }
}

var letters2 = new char[,]
{
    { 'A','B','C'},
    {'D','E','F' },
};
Console.ReadKey();
