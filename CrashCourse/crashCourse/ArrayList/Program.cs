using System.Collections; //ArrayList
using System.Collections.Generic;
using System.Reflection; //dictionary

namespace ArrayLists
{
    class Program 
    {
        static void Main(string[] args)
        {

            /*
             Arraylists are resizable arrays that can hold multiple different data types
             this is deprecated lol we prefer List<t> BUT this is the only way to add all the mixed type els in c#
             */
            #region ArrayList Code
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
            Console.WriteLine("Count :{0}",aList.Count);
        
            
            #endregion


            List<int> nums = new List<int>() {1,2,3 };
            nums.Add(4);
            Console.WriteLine($"{nums[^1]}");//4
            Console.WriteLine($"nums count : {nums.Count}");
            Console.WriteLine($"nums capacity : {nums.Capacity}");
            nums.Sort();
            nums.Reverse();
            nums.Insert(1, 999);
            nums.RemoveAt(0);
            nums.RemoveRange(1, 2);//at index 1 , remove 2 el => [999,3,2,1]=>[999,1]
            Console.WriteLine("999 index :{0}",nums.IndexOf(999));//0
            nums.RemoveAt(0);
            Console.WriteLine("999 index :{0}", nums.IndexOf(999)); //-1 does not exist

            var nums2 = new List<int>(){ 19, 29, 83 };
            nums.AddRange(nums2);
            Console.WriteLine(nums.Count);
            Console.ReadKey();//4
        }
    }

}