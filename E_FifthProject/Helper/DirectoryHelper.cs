namespace E_FifthProject.Helper
{
    public class DirectoryHelper
    {
        public void ListDirectories(string path){
            Array directoryArray = Directory.GetDirectories(path);
            foreach(string directory in directoryArray){
                Console.WriteLine(directory);
            }
        }

        public void ListAllDirectories(string path){
            Array directoryArray = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach(string directory in directoryArray){
                Console.WriteLine(directory);
            }
        }
        
        public void CreateDirectory(string dirName){
            Directory.CreateDirectory($"./{dirName}");
            Console.WriteLine($"Directory {dirName} created with success.");
        }

        public void DeleteDirectory(string dirName){
            try{
                Directory.Delete($"./{dirName}");
                Console.WriteLine($"Directory {dirName} deleted with success.");
            }catch(Exception e){
                Console.WriteLine($"Problem deleting directory {dirName}.\nError: {e}");
            }
        }

    }
}