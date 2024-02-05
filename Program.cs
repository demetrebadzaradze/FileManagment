using System;
using System.IO;
using RandomFunctions;

namespace Csharpproject
{
    class FileManagment
    {
        static void Main(string[] args)
        {

            // string decodedText = NewFunctions.Decode(path);
            // PrintDirectories(path); 
            // Console.WriteLine(decodedText);
            Dictionary<int, string> diction = NewFunctions.AnaliseLines(@"C:\Users\User\Desktop\coded text.txt");

            foreach (var item in diction)
            {
                Console.WriteLine(item.Key + "|" + item.Value);
            }


            Console.ReadKey();
        }


    }
}