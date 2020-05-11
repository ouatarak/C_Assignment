using System;
using System.IO;
Console.WriteLine("Please enter the file name");
string file = Console.ReadLine();
string myFile = File.ReadAllText(file);
bool exist = true;
while (exist)
{
      bool DoesFileExist = File.Exists(file);

      if (DoesFileExist == true)
      {
            Console.WriteLine("File does exist");

                string fileContent = File.ReadAllText(file);
                Console.WriteLine(fileContent);
      }
      else
      {
            Console.WriteLine("File does not exist, Please enter a valid file name.");
      }
      exist = false;
     
}