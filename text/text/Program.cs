using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("file.txt"))
            {
                Console.WriteLine("exist {0}", File.ReadAllLines("file.txt"));
            }
            else
            {
                Console.WriteLine("don't existe");
            }
            Console.ReadLine();
            
            Console.WriteLine("write some text:");
            string text = Console.ReadLine();
            string n = "\n"; 
            File.WriteAllText(n + "file.txt", n + n);//write text
            string[] linha = File.ReadAllLines("file.txt");//read lines
            foreach (string l in linha)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
            
        }
    }
}
