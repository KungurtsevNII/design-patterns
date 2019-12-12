namespace TemplateMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var fileName = "File Name";
            var logImporter = new LogImporterToDB();
            logImporter.Import(fileName);
        }
    }
}