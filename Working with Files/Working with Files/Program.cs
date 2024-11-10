namespace Working_with_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            // Demo File and FileInfo
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            File.Delete(path);

            if (File.Exists(path) )
            {
                //
            }

            var content = File.ReadAllText(path);

            // FileInfo
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");

            fileInfo.Delete();

            if (fileInfo.Exists )
            {
                //
            }

            // file provides static method (effiicent for small file operation),
            // fileinfo provides instance methods (effiicent for large file operations)


        }
    }
}
