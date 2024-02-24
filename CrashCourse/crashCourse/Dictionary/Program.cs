namespace Dict 
{
    class Program
    { 
        static void Main(string[] args) 
        {
            Dictionary<string, string> superHeroes = new Dictionary<string, string>();
            superHeroes.Add("Clark Kent", "Superman");
            superHeroes.Add("Bruce Wayne", "Batman");
            superHeroes.Add("Barry Allen", "The Flash");

            superHeroes.Remove("Barry Allen");
            Console.WriteLine("Count : {0}", superHeroes.Count);

            Console.WriteLine("Clark Kent : {0}",superHeroes.ContainsKey("Clark Kent"));
      
            superHeroes.TryGetValue("Clark Kent", out string test);
            Console.WriteLine($"Clark Kent value : {test}");

            int[] arrr1 = { 1, 2, 3 };
            int[] arrr2 = { 1, 2, 3 };

            Console.WriteLine($"arrr1[1] == arrr2[1]:  {arrr1[1] == arrr2[1]}");
            Console.WriteLine($"arrr1 == arrr2:  {arrr1 == arrr2}");
            foreach (KeyValuePair<string, string> item in superHeroes)
            {
                Console.WriteLine("key {0} : value {1}", item.Key, item.Value);
            }
            superHeroes.Clear();

  
            //List.Count works same as arr.length in js 


            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine(arr.Length);

            //List<List<int>> list = new List<List<int>>()
            //{
            //    new List<int>() {1, 2, 3},
            //    new List<int>() {4, 5, 6}
            //};

            //int rowCount = list.Count; // Number of rows
            //int colCount = list[0].Count; // Number of columns in the first row

            //Console.WriteLine($"rowCount : {rowCount}");//2 
            //Console.WriteLine($"colCount : {colCount}");//3

            //int num1 = 10;//11
            //int num2 = num1++;//10 
            ///*
            // num2 assigns value that is same as num1 
            // then it increment num1 
             
            // */
            //Console.WriteLine($"num1: {num1}, num2: {num2}");
            //int x = 10;
            //int y = x;
            //x += 20;
            //Console.WriteLine("x : {0}   y:{1}",x,y);


            Console.ReadKey();
        }
    }

}