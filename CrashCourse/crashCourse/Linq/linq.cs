//using System.Xml.Linq;
using System.Collections;

namespace Linqq
{
    public class Program
    {
        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;
            foreach (int num in gt20)
            {
                Console.WriteLine("[QueryIntArray] num : {0}", num);
            }
            Console.WriteLine($"[QueryIntArray] Get type: {gt20.GetType()}");
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            // if you change data in the query automatically update

            nums[0] = 40;

            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }

            return arrayGT20;

        }
        static void Main(string[] args)
        {
            //Language Integrated Query (LINQ)
            string[] dogs = { "k 9", "Brian Grffin", "scooby doo", "old yeller", "Rin tin tin", "Benji", "charlie b barkin", "lassie", "snoopy" };
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var dog in dogSpaces)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine("--------------------------\n");


            int[] intArray = QueryIntArray();
            foreach (var item in intArray)
            {
                Console.WriteLine("qI :   {0}", item);
            }

            Console.WriteLine("--------------------------\n");

            List<Animal> famAnimals = new List<Animal>();
            /*
         The OfType<T>() method is particularly useful when you're dealing with collections (like lists or arrays) that might contain elements of different types, and you want to filter out only the elements of a specific type (T).

            If you're certain that all elements in your collection are of the same type, there's no need to use OfType<T>(). You can directly work with the collection without any additional filtering.
             
             👇👇👇THIS LINE READ TEXT ABOVE : TLDR => if your collection has diffeent types of data you need to filter out the types. to query 
             */

            var famAnimalEnum = famAnimals.OfType<Animal>();// it only does filtering of the type 

            //var smAnimals = from animal in famAnimalEnum
            //                where animal.Weight <= 90
            //                orderby animal.Name
            //                select animal;

            //foreach (var animal in smAnimals)
            //{
            //    Console.WriteLine("{0} weights {1} lbs",animal.Name, animal.Weight);
            //}

            var bigDogs = from dog in famAnimalEnum
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;


            foreach (var i in bigDogs)
            {
                Console.WriteLine("{0} weights {1} lbs", i.Name, i.Weight);
            }



            Console.WriteLine("===========================\n");
            //ArrayList famAnimals = new ArrayList()
            //{
            //    new Animal{Name = "Heidi", Height = .8,Weight=18 },
            //    new Animal{Name = "Shrek", Height = .4,Weight=130 },
            //    new Animal{Name = "Congo", Height = 3.8,Weight=90 }
            //};







            Animal[] animals = new[]
            {
                new Animal{Name = "German Shephard", Height = 25,Weight=77,AnimalID=1 },
                new Animal{Name = "Chihuahuia", Height = 7,Weight=4.4,AnimalID=2 },
                new Animal{Name = "Saint Bernard", Height = 30,Weight=200,AnimalID=3 },
                new Animal{Name = "Pug", Height = 12,Weight=16,AnimalID=4 },
                new Animal{Name = "Beagle", Height = 15,Weight=23,AnimalID=5 }
            };


            //remove name and height 
            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };
            Owner[] owners = new[]
            {
               new Owner{ Name="Doug Parks",OwnerID=1},
               new Owner{ Name="Sally Smith",OwnerID=2},
               new Owner{ Name="Paul Brooks",OwnerID=3},
            };


            Array arrNameHeight = nameHeight.ToArray();


            //--------------------------| joining table
            var innerJoin =
                from animal in animals
                join owner in owners on animal.AnimalID
                equals owner.OwnerID
                select new { OwnerName = owner.Name, AnimalName = animal.Name };


            var groupJoin =
                from owner in owners
                orderby owner.OwnerID
                join animal in animals on owner.OwnerID
                equals animal.AnimalID into ownerGroup
                select new
                {
                    Owner = owner.Name,
                    Animals = from owner2 in ownerGroup
                              orderby owner2.Name
                              select owner2
                };

            int totalAnimals = 0;

            foreach (var item in innerJoin)
            {
                Console.WriteLine("item---- {0}", item);
            }
            Console.WriteLine();


            foreach (var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach (var animal in ownerGroup.Animals)
                {
                    totalAnimals++;
                    Console.WriteLine("* {0}", animal.Name);
                }
            }








            Console.ReadLine();
        }
    }

}