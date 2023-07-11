namespace ReadFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roofpath = @"C:\Users\Cute\Desktop\ReadFiles";

//get directory

            //string[] directories = Directory.GetDirectories(roofpath, "*", SearchOption.AllDirectories);
            //foreach (string dir in directories) 
            //{
            //    //Console.WriteLine(dir);
            //}


//get file, info about file and directory

            //var files = Directory.GetFiles(roofpath, "*" ,SearchOption.AllDirectories);
            //foreach (string dir in files)
            //{
            //Console.WriteLine($"{dir}");
            //Console.WriteLine(Path.GetFileName(dir));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(dir));
            //Console.WriteLine(Path.GetFullPath(dir));
            //Console.WriteLine(Path.GetDirectoryName(dir));

            //var info = new FileInfo(dir);
            //Console.WriteLine($"{Path.GetFileName(dir)} : {info.Length} bites");
            //}


//create directory

            //string newPath = $"C:\\Users\\Cute\\Desktop\\ReadFiles\\new4";
            //bool directoryExists = Directory.Exists(newPath);
            //if (directoryExists)
            //{
            //    Console.WriteLine($"It's exist");
            //}
            //else
            //{
            //    Console.WriteLine("it's not exist");
            //    Directory.CreateDirectory(newPath);
            //}

//read write file
        
            //string filePath = $"C:\\Users\\Cute\\Desktop\\ReadFiles\\txt1.txt";
            //List<string> lines = File.ReadAllLines(filePath).ToList();
            //foreach (string line in lines) 
            //{
            //    Console.WriteLine(line);    
            //}
            //lines.Add("Hi my name is Ann.");
            //File.WriteAllLines(filePath, lines);
            


        }
    }
}