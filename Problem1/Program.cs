using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            DirectoryInfo parentDir = directory.Parent;

            DirectoryInfo[] dirs = parentDir.GetDirectories();
            Console.WriteLine($"Название папки: {parentDir.Name}\n");
            foreach (DirectoryInfo dir in dirs)
            {
                Console.WriteLine("\tНазвание подкаталога: "+ dir.Name);

                if (dir.GetDirectories().Length > 0)
                {
                    Console.WriteLine("\t\tСодержимые подкаталоги:");
                    foreach (DirectoryInfo dir1 in dir.GetDirectories())
                        Console.WriteLine("\t\t\t" + dir1.Name);
                }

                if (dir.GetFiles().Length > 0)
                {
                    Console.WriteLine("\t\tСодержимые файлы:");
                    foreach (FileInfo file1 in dir.GetFiles())
                        Console.WriteLine("\t\t\t" + file1.Name);
                }

                Console.WriteLine();
            }

            if (parentDir.GetFiles().Length > 0)
            {
                Console.WriteLine("\tСодержимые файлы:");
                foreach (FileInfo file in parentDir.GetFiles())
                    Console.WriteLine("\t\t" + file.Name);
            }

            Console.ReadKey();
        }
    }
}
