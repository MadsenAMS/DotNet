namespace E_FifthProject.Helper
{
    public class FileHelper
    {
        public void ListFiles(string path)
        {
            Array fileArray = Directory.GetFiles(path);
            foreach (string file in fileArray)
            {
                Console.WriteLine(file);
            }
        }

        public void ListAllFiles(string path)
        {
            Array fileArray = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in fileArray)
            {
                Console.WriteLine(file);
            }
        }

        public void ListFilesContaining(string path, string contained)
        {
            Array fileArray = Directory.GetFiles(path, contained, SearchOption.AllDirectories);
            foreach (string file in fileArray)
            {
                Console.WriteLine(file);
            }
        }

        public void WriteToFile(string path, string text)
        {
            File.WriteAllText(path, text);
            Console.WriteLine("Text written to file!!!");
        }

        public void WriteAtFileEnd(string path, string text)
        {
            if (File.Exists(path))
            {
                File.AppendAllText(path, text);
            }
            else
            {
                WriteToFile(path, text);
            }

            Console.WriteLine("Text appended to file!!!");
        }

        public void StreamTextToFile(string path, string[] text)
        {
            StreamWriter stream = File.CreateText(path);

            using (stream)
            {
                foreach (string line in text)
                {
                    stream.WriteLine(line);
                }
            }
        }

        public void ReadTextFile(string path){
            string[] output = File.ReadAllLines(path);
            Console.WriteLine("\n   ***   START OF FILE   *** \n");
            foreach(string line in output){
                Console.WriteLine(line);
            }
            Console.WriteLine("\n   ***   END OF TEXT   ***   \n");
        }

        public void ReadTextStream(string path){
            string output;
            var stream = File.OpenText(path);

            Console.WriteLine("\n   ***   START OF FILE   *** \n");
            using(stream){
                do{
                    output = stream.ReadLine();
                    if(output != null)
                        Console.WriteLine(output);
                }while(output != null);
            Console.WriteLine("\n   ***   END OF TEXT   ***   \n");
            }
        }

        //In this example, used only to rename the file. Same code though.
        public void MoveFile(string origin, string path){
            File.Move(origin, path);
        }

        public void CopyFile(string origin, string path){
            File.Copy(origin, path);
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);
            Console.WriteLine("File deleted with success!");
        }
    }
}