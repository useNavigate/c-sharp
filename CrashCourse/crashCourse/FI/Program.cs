namespace fileSystem
{

    public class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo("."); // . for current directory 
            DirectoryInfo saraDir = new DirectoryInfo(@"C:\Users\UseNa");
            Console.WriteLine(saraDir.FullName);
            Console.WriteLine(saraDir.Name);
            Console.WriteLine(saraDir.Parent);
            Console.WriteLine(saraDir.Attributes);
            Console.WriteLine(saraDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\UseNa\testing");
            Console.WriteLine(dataDir.CreationTime);// you can change the dir name but as you see this one is just created
            dataDir.Create();
            //deleting dir 

            Directory.Delete(@"C:\Users\UseNa\testing");
            Console.ReadKey();

        }

    }
}