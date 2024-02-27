using System.Text;

namespace fileSystem
{

    public class Program
    {
        static void Main(string[] args)
        { 
            //------------------------------| Directory functional 
            DirectoryInfo currDir = new DirectoryInfo("."); // . for current directory 
            DirectoryInfo saraDir = new DirectoryInfo(@"C:\Users\UseNa");
            Console.WriteLine(saraDir.FullName);
            Console.WriteLine(saraDir.Name);
            Console.WriteLine(saraDir.Parent);
            Console.WriteLine(saraDir.Attributes);
            Console.WriteLine(saraDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\UseNa\csharp_fi");
            Console.WriteLine(dataDir.CreationTime);// you can change the dir name but as you see this one is just created
            dataDir.Create();
            //deleting dir 

            // Directory.Delete(@"C:\Users\UseNa\csharp_fi");




            //------------------------------| Fle IO
            Console.WriteLine("------------------------------| File IO\n");
            string[] customers = { "Bob Smith", "Sally Smth", "Robert Dith" };
            string textFilePath = @"C:\Users\UseNa\csharp_fi\testfile1.txt";
            File.WriteAllLines(textFilePath, customers);


            foreach (string customer in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"customer : {customer}");
            }

            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\UseNa\csharp_fi");
            FileInfo[] texFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            foreach (FileInfo file in texFiles) 
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }



            //------------------------------| FleStreams
            Console.WriteLine("------------------------------| FleStreams\n");
            string textFilePath2 = @"C:\Users\UseNa\csharp_fi\textfile2.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);
            string randString = "This is a random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);

            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;
            byte[] fileByteArray = new byte[rsByteArray.Length];

            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

           
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            //if you look at GetString it only takes bytes array 
            fs.Close(); // close file stream whenever its finished. 




            //------------------------------| Fle writers and stream reader 
            Console.WriteLine("------------------------------| Fle writers and stream reade\n");
            
            string textFilePath3 = @"C:\Users\UseNa\csharp_fi\textfile3.txt";
            StreamWriter sw = new StreamWriter(textFilePath3);
            //NOT CONSOLE.WRITE LINE
            sw.Write("This is a random ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");
            sw.Close();

            StreamReader sr = new StreamReader(textFilePath3);
            Console.WriteLine("Peek: {0}",Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st string : {0}",sr.ReadLine());
            Console.WriteLine("Everything Else: {0}",sr.ReadToEnd());
            Console.WriteLine();
            sr.Close();

            Console.ReadKey();

        }

    }
}