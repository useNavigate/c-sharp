using System;
namespace learningArr
{
    public class Program
    { //------- functions -------------
        static void PrintArray(int[] intArray, string msg)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", msg, i);
            }
        }
    static void Main(string[] args)
        {
            //how to make int array with space 3
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            string[] customers = {"Bob","Sally","Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };
            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            Console.WriteLine("Array size : {0}", randomArray.Length);

            for (int i = 0; i < randomArray.Length;i++) 
            {
                Console.WriteLine("Array : {0} : value :{1}",
                    i, randomArray[i]);

            }
            Console.WriteLine("---------------------------");
            string[,] custNames = new string[2, 2] { { "bob", "sam" }, { "sally", "smith" } };
            

            Console.WriteLine("MD value :{0}", custNames.GetValue(0, 0));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(0); j++)
                {
                    Console.WriteLine(custNames.GetValue(i, j));
                
                }
            }
            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");
            Console.WriteLine("---------------------");

            Array.Sort(randNums);
            Console.WriteLine("using func after sorting to see if it alter the original array ");
            PrintArray(randNums, "altered");
            Array.Reverse(randNums);
            Console.WriteLine("1 at index :{0}", Array.IndexOf(randNums, 1));
            randNums.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}", m);
            }

            int[] numArray = { 1, 11, 22 };
            // Using a lambda expression as a predicate
            Console.WriteLine("> 10 :{0}", Array.Find(numArray, num=>num > 10));
            int[] greaterThanTen = Array.FindAll(numArray, num => num > 10);
            Console.WriteLine("> 10 : {0}", string.Join(", ", greaterThanTen));
            Console.ReadLine();


        }
    }
}