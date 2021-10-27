using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + "\\New.txt";
            if (!File.Exists(path))            
                File.Create(path);
            
            StreamWriter sw = new StreamWriter(path, false);
            
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)            
                array[i] = random.Next(0, 100);
                        
            foreach (int num in array)            
                sw.Write($"{num} ");                
            
            sw.Close();
            
            StreamReader sr = new StreamReader(path);

            string numbers = sr.ReadLine().Trim();
            Console.WriteLine($"Массив чисел, считанный из файла: {numbers}");
            string[] numArray = numbers.Split(' ');
            int sum = 0;

            foreach (string num in numArray)
            {
                int i = int.Parse(num);
                sum += i;
            }
            Console.WriteLine($"Полученная сумма: {sum}");
            Console.ReadKey();            
        }
    }
}
