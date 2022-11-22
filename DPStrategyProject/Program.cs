namespace DPStrategyProject
{
    interface ICompression
    {
        void Compress(string fileName);
    }

    class RarCompression : ICompression
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"file {fileName} compress Rar");
        }
    }

    class ZipCompression : ICompression
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"file {fileName} compress Zip");
        }
    }

    class ArjCompression : ICompression
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"file {fileName} compress Arj");
        }
    }

    class Compressor
    {
        public ICompression Compression { set; get; }
        public Compressor(ICompression compression)
        {
            this.Compression = compression;
        }
        public void FileCompress(string fileName)
        {
            Compression.Compress(fileName);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Compressor compressor = new(new RarCompression());
            compressor.FileCompress("file.txt");
            compressor.Compression = new ZipCompression();
            compressor.FileCompress("file.txt");
        }
    }
}