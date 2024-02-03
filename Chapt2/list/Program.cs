var words = new List<string>
{
"one",
"two",
"three",
"four"
};

Console.WriteLine("Count of element is " + words.Count);
//for (var i = 0; i < words.Count; i++)
//{
//    Console.WriteLine(words[i]);
//}
Console.WriteLine("Removing an item");
//if you try to remove random thing that list doesnt contain it wont error

words.RemoveAt(0);
foreach (var word in words)
{
    Console.WriteLine(word);
}


var moreWords = new[] { "ab", "bc", "cd" };
words.AddRange(moreWords);
Console.WriteLine("------------------------------------");
Console.WriteLine("Index of element ab is " + words.IndexOf("ab"));
Console.WriteLine("Index of element seven is " + words.IndexOf("seven"));
Console.WriteLine("Contains 'five' ? : " + words.Contains("five"));
Console.WriteLine("Contains 'three' ? : " + words.Contains("three"));

words.Clear();
Console.WriteLine("count of elements after clear: " + words.Count);
Console.ReadKey();
var ress = char.IsUpper('a');