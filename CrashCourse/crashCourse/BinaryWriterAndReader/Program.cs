namespace BinaryWriterAndReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing binary data 
            //* creating file
            string textFilePath4 = @"C:\Users\UseNa\csharp_fi\textfile4.txt";
            FileInfo datFile = new FileInfo(textFilePath4);

            //* Writing file
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string randText = "Random Text";
            int myAge = 47;
            double height = 6.25;
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);
            bw.Close();


            //Reading binary data
            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();
            Console.ReadKey();
        }
    
    }

}