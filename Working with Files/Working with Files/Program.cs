namespace Working_with_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var path = @"c:\somefile.jpg";
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
            // fileinfo provides instance methods (effiicent for large file operations)*/



            // WORKING WITH DIRECTORIES
            // Similar to file and fileInfo, Directory and DirectoryInfo provide static and instance methods

            /*Directory.CreateDirectory(@"c:\temp\folder1");

            // listing all files in a given directory
            /*var files = Directory.GetFiles(@"c:\Users\mbamidele\Projects\CSharpFundamentals", "*.sln*", SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);#1#

            // listing all directories in a given path
            var directories = Directory.GetDirectories(@"c:\Users\mbamidele\Projects\CSharpFundamentals",
                "*.*", searchOption: SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            // check if a directory exists
            Directory.Exists("...");

            

            // Working with DirectoryInfo
            var directoryInfo = new DirectoryInfo("...");
            // start performing operation on the directory instance created
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();*/


            // WORKING WITH THE Path Class

            var path = @"C:\mbamidele\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            // doing lowlevel operation without using the Path class
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            // DOING THIS WITH THE Path Class
            Console.WriteLine("Extension: " + Path.GetExtension(path));

            // extract only file name in path
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            
            // get file name without extension
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));

            // Get directory name of path
            Console.WriteLine("Directory Name of path: " + Path.GetDirectoryName(path));


        }
    }
}
