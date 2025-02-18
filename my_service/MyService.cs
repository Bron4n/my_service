using System.IO;

namespace WCFMyServiceLibrary
{
    public class MyService : IMyService
    {
        private const string FilePath = @"C:\Users\user\source\repos\my_service\MyHost\bin\Debug\text.txt";

        public void WriteToFile(string text)
        {
            File.WriteAllText(FilePath, text);
        }

        public string ReadFromFile()
        {
            string content = System.IO.File.ReadAllText(FilePath);
            return content;
        }
    }
}
