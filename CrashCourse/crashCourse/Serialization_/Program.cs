//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Xml.Serialization;


using Serialization_;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

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
            string jsonFilePath = @"C:\Users\UseNa\csharp_fi\jsonSerializer.json" ;
            string jsonData = JsonSerializer.Serialize(bowser);

            //Using statement ensures the StreamWriter is properly disposed 
            using (StreamWriter jsonWriter = new StreamWriter(jsonFilePath))
            { 
                jsonWriter.Write(jsonData);
            }

            //Read JSON data from file and deserialize it back to an object 
            string jsonContent;
            using (StreamReader jsonReader = new StreamReader(jsonFilePath))
            {
                jsonContent = jsonReader.ReadToEnd();
            }
            // After deserialization and when you're done with the file
           // File.Delete(filePath);


            Console.WriteLine(bowser.ToString());

            bowser.Weight = 99999;
            //--------------------------------------------| XML Serialization

 

            //1. make the file path 
            string xmlfilePath = @"C:\Users\UseNa\csharp_fi\xmalSerialization.xml";
            //2. create the serializer 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Animal));
            //3. while using streamWriter serialize the data => write the file
            using (TextWriter textWriter = new StreamWriter(xmlfilePath))
            {
                xmlSerializer.Serialize(textWriter, bowser);
            }

            bowser = null;
            // Read XML data from file and deserialize it back to an object
            using (TextReader reader = new StreamReader(xmlfilePath))
            {
                bowser = (Animal)xmlSerializer.Deserialize(reader);
            }

            // Delete XML file
           // File.Delete(xmlfilePath);

            Console.WriteLine(bowser.ToString());
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario",60,30,2),
                new Animal("Luigi",55,24,3),
                new Animal("Peach",40,20,4)

            };

            string animalFL = @"C:\Users\UseNa\csharp_fi\animalSerialization.xml";
            using (Stream fs = new FileStream(animalFL, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }
            theAnimals = null;


            //open and read file 
            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));
            using (FileStream fs2 = File.OpenRead(@"C:\Users\UseNa\csharp_fi\animalSerialization.xml")) 
            { 
                theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
            }
            foreach (Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }
                Console.ReadKey();


        }
    }
}