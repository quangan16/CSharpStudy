namespace CS118;
class Program
{
    static void Main(string[] args)
    {
        // GetDriveInfo();
        // string path = "C:\\Users\\nqan1\\Documents\\Dev_2023\\C#_Project\\C#_Study\\CS118_File";
        // DirectoriesList(path);
        // Console.WriteLine(Path.DirectorySeparatorChar);
        string path2 = Path.Combine("Dir1", "Dir2","myText.txt");
        path2 = Path.ChangeExtension(path2, "md");
        string ext = Path.GetExtension(path2);

        Console.WriteLine(path2);
        Console.WriteLine(ext);
    }

    static void GetDriveInfo(){
        // DriveInfo class ==============================================================================
        // //DriveInfo driveInfo = new DriveInfo("C");
        // DriveInfo[] driveInfo =  DriveInfo.GetDrives();
        // foreach(var drive in driveInfo){
        //      Console.WriteLine("Name of drive? - " + drive.Name);
        //     Console.WriteLine("Label of drive? - " + drive.VolumeLabel);
        //     Console.WriteLine("Is drive running? - " + drive.IsReady);
        //     Console.WriteLine("Type of drive? - " + drive.DriveType);
        //     Console.WriteLine("Free space? " + drive.TotalFreeSpace/(1024*1024*1024) + " GB");

        // }

        //Directory class ====================================================================
        
    }
    public static void DirectoriesList(string path){
         
        // if(Directory.Exists(path)){
        //     Console.ForegroundColor = ConsoleColor.Green;
        //     Console.WriteLine($"Path {path} exists");
        //     Console.ResetColor();
            
        // }else{
        //     Console.ForegroundColor = ConsoleColor.Red;
        //     Console.WriteLine($"Path {path} does not exist");
        //     Console.ResetColor();
        // }

        var files = Directory.GetFiles(path);
        var directories = Directory.GetDirectories(path);
        foreach(var file in files){
            Console.WriteLine(file);
        }
        Console.WriteLine("=====================");
        foreach(var folder in directories){
            Console.WriteLine(folder);
            DirectoriesList(folder);
        }
    }
}

