

using System.IO;
using System;

namespace RenamingUtility

{
    class Program

    {
        static void Main(string[] args) 
        
        {

            Console.WriteLine("Renaming utility has started executing...");

            if (args.Length>1) 
            { 
            string oldFileName = args[0];
                string newFileName = args[1];

                if(File.Exists(oldFileName) ) 
                {
                
                    File.Move(oldFileName, newFileName);
                    Console.WriteLine("The file name has been changed successfully");

                }

                else 
                {
                    Console.WriteLine($"The file name {oldFileName} does not exist");
                }


            }

            else
            {
                Console.WriteLine("Not enough arguments to rename");
            
            
            }


        }



    }








}
