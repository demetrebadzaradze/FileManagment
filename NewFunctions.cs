using System;

namespace RandomFunctions
{
    class NewFunctions
    {
        // public static string Decode(string path)
        // {
        //     string res;
        //     Dictionary<int, string> result = new Dictionary<int, string>() { };
        //     try
        //     {
        //         // result = AnaliseLine(path);
        //     }
        //     catch (System.Exception)
        //     {

        //         throw;
        //     }
            

        //     // Dictionary<int, string> line = new Dictionary<int, string>();



        //     return res ?? "ss";
        // }
        public static Dictionary<int, string> AnaliseLines(string path)
        {
            Dictionary<int, string> res = new Dictionary<int, string>(){};
            StreamReader sr = new StreamReader(path);
            while (sr.ReadLine != null)
            {
                string line = sr.ReadLine();

                string[] splitedLine = line.Split(' ');

                int num = Convert.ToInt32(splitedLine[0]);
                string word = splitedLine[1];

                res.Add(num,word);
            }
            return res;
        }
        static void Swap<T>(T x, T y)
        {
            var x2 = x;
            y = x2;
            x = y;
        }
        static public void AddList<T>(List<T> newList, params T[] numbers)
        {
            foreach (T doub in numbers)
            {
                newList.Add(doub);
            }
        }
        static void PrintDirectories(string path)
        {
            int gen = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Path.GetFileName(path));
            Console.ResetColor();

            PrintFolders(path, gen);
        }
        static void PrintFolders(string path, int generation)
        {
            generation++;
            string[] directoryes = Directory.GetDirectories(path);

            if (directoryes.Length == 0)
            {
                PrintFiles(path, generation);
                return;
            }

            foreach (string directory in directoryes)
            {
                Nest(generation);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Path.GetFileName(directory));
                Console.ResetColor();
                PrintFiles(directory, generation);
                PrintFolders(directory, generation);
            }
        }
        static void PrintFiles(string path, int generatin)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                Nest(generatin);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Path.GetFileName(file));
                Console.ResetColor();
            }
        }
        static void Nest(int generation)
        {
            Console.Write(new String("      "), generation);
        }
    }
}