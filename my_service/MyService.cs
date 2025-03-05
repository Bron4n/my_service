using System.IO;

namespace WCFMyServiceLibrary
{
    public class MyService : IMyService
    {
        private const string FilePath1 = @"C:\Users\user\source\repos\my_service\MyHost\bin\Debug\text.txt";
        private const string FilePath2 = @"C:\Users\user\source\repos\my_service\MyHost\bin\Debug\text2.txt";

        // Запись
        public void WriteToFile(string text, string fileName = "text.txt")
        {
            string filePath = fileName.ToLower() == "text2.txt" ? FilePath2 : FilePath1;
            File.WriteAllText(filePath, text);
        }

        // Чтение
        public string ReadFromFile(string fileName = "text.txt")
        {
            string filePath = fileName.ToLower() == "text2.txt" ? FilePath2 : FilePath1;
            return File.Exists(filePath) ? File.ReadAllText(filePath) : "Файл не найден.";
        }
    }
}
