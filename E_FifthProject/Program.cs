using E_FifthProject.Helper;
using System;

namespace E_FifthProject
{

    public class Program
    {

        static void Main(string[] args)
        {

            string path = "./";

            DirectoryHelper directoryHelper = new DirectoryHelper();
            string dummyDirectory = "testDirectory";
            Query.New();
            directoryHelper.CreateDirectory(dummyDirectory);
            Query.New();
            directoryHelper.ListDirectories(path);
            Query.New();
            directoryHelper.DeleteDirectory(dummyDirectory);
            Query.New();
            directoryHelper.ListDirectories(path);

            FileHelper fileHelper = new FileHelper();
            Query.New();
            fileHelper.ListFiles(path);

            string inputText = "Hello File!";
            string fileName = "test.txt";
            string newName = "newTest.txt";
            Query.New();
            fileHelper.WriteToFile(path + fileName, inputText);
            fileHelper.ListFiles(path);
            Query.New();
            fileHelper.MoveFile(path + fileName, path + newName);
            fileHelper.ListFiles(path);
            Query.New();
            fileHelper.DeleteFile(path + newName);

            string[] inputStream = {"test", "hello file!", "it works"};
            Query.New();
            fileHelper.StreamTextToFile(path + fileName, inputStream);
            fileHelper.ReadTextStream(path + fileName);
            fileHelper.DeleteFile(path + fileName);

        }

    }

    public static class Query
    {
        public static void New()
        {
            Console.WriteLine("\nNew Query");
        }
    }

}
