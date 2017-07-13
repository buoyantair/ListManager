using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManager
{
    class Program
    {
        static void ListManager(List<string> Items)
        {
            string input = Console.ReadLine();
            string item = input.Substring(1, input.Length - 1);
            if (input.Substring(0).Contains("+"))
            {
                Items.Add(item);
                Console.WriteLine("Added to the list! Updated list is : ");
                Items.ForEach(c =>
                {
                    Console.WriteLine(c);
                });
                ListManager(Items);
            }
            else if (input.Substring(0).Contains("-"))
            {
                Items.Remove(item);
                Console.WriteLine("Removed to the list! Updated list is : ");
                Items.ForEach(x =>
                {
                    Console.WriteLine(x);
                });
                ListManager(Items);
            }
            else if (input.Substring(0).Contains("--"))
            {
                Items.Clear();
                Console.WriteLine("Cleared to the list! ");
                ListManager(Items);
            }
        }

        static void Main(string[] args)
        {
            List<string> Items = new List<string>();
            ListManager(Items);


            Console.Read();
        }
    }
}
