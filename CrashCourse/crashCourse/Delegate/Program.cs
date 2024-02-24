

namespace Delegate
{
    public class Program
    {
        delegate double doubleIt(double val);
        static void Main(string[] args)
        {
            //-------------------| where
            doubleIt dbleIt = x => x* 2;
            Console.WriteLine($"5 * 2 = {dbleIt(5)}");

            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var j in evenList)Console.WriteLine(j);

            Console.WriteLine();
            var rangeList = numList.Where(x => (x > 2) || (x < 9)).ToList();
            foreach(var k in rangeList) Console.WriteLine(k);

            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                    i++;
            }
            Console.WriteLine("Heads :{0}",flipList.Where(a=>a==1).ToList().Count());
            Console.WriteLine("tails :{0}", flipList.Where(a => a == 2).ToList().Count());





            var nameList = new List<string> { "Doug", "sally", "sue" };
            var sNameList = nameList.Where(x => x.StartsWith("s"));
            foreach (var n in sNameList)
            { 
                Console.WriteLine(n); 
            }

            //----------------------|  range

            Console.WriteLine("\n//----------------------|  range");

            var oneTo10=new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));
            var squares = oneTo10.Select(x => x * x);
            foreach(var l in squares) Console.WriteLine(l);



            Console.WriteLine("\n//----------------------|  zip");
            //----------------------|  zip

            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });
            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach(var item in sumList) Console.WriteLine(item);


            Console.WriteLine("\n//----------------------|  Aggregate");
            var numList2 = new List<int>(new int[] { 1,2, 3, 4,5,6,7,8,8,9,2,3 });
            var numList3 = new List<int>(new int[] { 1, 2, 3, 4,  });
            Console.WriteLine("Sum {0}",numList2.Aggregate((a,b)=>a+b));
            Console.WriteLine("\n//----------------------|  AsQueryable().Average())");
            Console.WriteLine("average {0}", numList2.AsQueryable().Average());
            Console.WriteLine("\n//----------------------|  All)");
            Console.WriteLine("all> 3 {0}", numList2.All(x=>x>3));
            Console.WriteLine("\n//----------------------| Any)");
            Console.WriteLine("Any> 3 {0}", numList2.Any(x => x > 3));
            Console.WriteLine("\n//----------------------| Distinct)");
            Console.WriteLine("Distinct : {0}", string.Join(",",numList2.Distinct()));
            Console.WriteLine("\n//----------------------| Except)");
            Console.WriteLine("Except :{0}", string.Join(", ",numList2.Except(numList3)));
            Console.WriteLine("\n//----------------------| Intersect)");
            Console.WriteLine("Intersect :{0}", string.Join(", ", numList2.Intersect(numList3)));

            Console.WriteLine("Original{0}", string.Join(", ", numList2));
            Console.ReadLine();
        }
    }
}