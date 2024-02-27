//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Xml.Serialization;


using Serialization_;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace serialization_
{
    public class Program
    {
        /*
         serialization able to do is actually store the state of an objejct 
        in a file stream and you can pass it to a remot network or w.e
         */


        // code below is old way from crash course video so i commented out 
        static void Main(string[] args)
        {


            Animal bowser = new Animal("Bowser", 45, 25,1);
            ////now serialize data to a file 
            //Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            ////thisway wont work anymore
            //BinaryFormatter bf= new();
            //bf.Serialize(stream, bowser);
            //stream.Close();

            //bowser = null;

            //stream = File.Open("AnimalData.dat", FileMode.Open);
            //bf = new BinaryFormatter();

            //bowser =(Animal)bf.Deserialize(stream);
            //stream.Close();

            //Console.WriteLine(bowser.ToString());

            //--------------------------------------------| JSON Serialization

            // Serialize object to JSON and write it to a file
            string filePath = @"C:\Users\UseNa\csharp_fi\AnimalData.dat" ;
            string jsonData = JsonSerializer.Serialize(bowser);

            File.WriteAllText(filePath, jsonData);

            bowser = null;

            // Read JSON data from file and deserialize it back to an object
           
            string jsonString = File.ReadAllText(filePath);//열어보면 제이슨 파일처럼 생겼음
            bowser = JsonSerializer.Deserialize<Animal>(jsonString);

            Console.WriteLine(bowser.ToString());
            Console.ReadKey();

        
    
        }
    }
}