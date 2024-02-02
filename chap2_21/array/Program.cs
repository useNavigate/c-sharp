var numbers = new [] { 2,6,1,6,19}; // this defines the length not the amount of els

//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 7;
//numbers[3] = 17;
//numbers[4] = 22;

//var firstEnd = numbers[^1];
//var secondEnd = numbers[^2];
//Console.WriteLine("First from end :{0}",firstEnd);
//Console.WriteLine("Second from end :{0}", secondEnd);

var sum = 0;
//foreach (var number in numbers)
//{
//    sum += number;
//}


for (int i = 0; i < numbers.Length; ++i)
{
    sum += numbers[i];
}
Console.WriteLine("total is = {0}",sum);


Console.ReadKey();
