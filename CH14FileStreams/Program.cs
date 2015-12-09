using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class TestFile
    {
        static void Main(string[] args)
        {
            string directoryName = "C:\\Users\\kevin_000\\Desktop\\";
            string folder = "";
            string[] listOfFiles;
            string fileName;
            string finalDirectory;
            while (folder != "end")
            {
                Console.WriteLine("Enter a folder name >>");
                folder = Console.ReadLine();
                finalDirectory = directoryName + folder;
                if (Directory.Exists(finalDirectory))
                {
                    Console.WriteLine("Directory exists, " + "and it contains the following: ");
                    listOfFiles = Directory.GetFiles(finalDirectory);
                    for (int i = 0; i < listOfFiles.Length; i++)
                        Console.WriteLine("     {0}", listOfFiles[i]);
                    Console.WriteLine("Enter a file name from the listed above ");
                    fileName = Console.ReadLine();
                    fileName = finalDirectory + "\\" + fileName;
                    if (File.Exists(fileName))
                    {
                        Console.WriteLine("file exists");
                        Console.WriteLine("file was created");
                        Console.WriteLine(File.GetCreationTime(fileName));
                        Console.WriteLine("file was last accessed");
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                    fileName = "";

                }
                else
                {
                    Console.WriteLine("directory does not exist");
                }



            }
        }
    }
}

