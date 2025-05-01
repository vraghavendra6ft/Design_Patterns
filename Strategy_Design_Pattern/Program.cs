namespace Strategy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ICompression zip = new ZipCompression();

           CompressionContext cntxt = new CompressionContext(zip);

            cntxt.CreateArchive("Test123");

            cntxt.SetStrategy(new RarCompression());

            cntxt.CreateArchive("Test123");

            Console.Read();

        }
    }
}
