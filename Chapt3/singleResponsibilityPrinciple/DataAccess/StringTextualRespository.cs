
//file scoped namespace declaration ( c# 10 or newer )
namespace _86_singleResponsibilityPrinciple.DataAccess;

    class StringTextualRespository
    {
        private static readonly string Separator = Environment.NewLine;
        public List<string> Read(string filePath)
        {
            var fileContents = File.ReadAllText(filePath);
            return fileContents.Split(Separator).ToList();

        }

        public void Write(string filePath, List<string> strings) =>
            File.WriteAllText(filePath, string.Join(Separator, strings));

    }

