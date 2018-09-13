using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.WriteLine("What is the name of the the document?");
            var name = Console.ReadLine();
            name = $"{name}.txt";
            Console.Write($"You have created a file named {name}\n");
            Console.WriteLine("What do you want to write to the document?");
            var text = Console.ReadLine();
            try
            {
                using (StreamWriter write = new StreamWriter(name))
                {
                    write.Write(text);
                }
                Console.WriteLine($"{name} is saved");
            }

            catch (Exception)
            {
                using (StreamWriter write = new StreamWriter("exception"))

                {
                    write.Write(text);
                }
                Console.WriteLine("Your file name does not work! The file is now called excepion");
            }

            string path = File.ReadAllText($"{name}");

            Console.Write("There are ");
            Console.Write(path.Length);
            Console.Write(" characters.");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}