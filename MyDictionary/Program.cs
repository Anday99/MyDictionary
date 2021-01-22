using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> nameAge = new MyDictionary<string, int>();
            nameAge.Add("Anday", 21);
            nameAge.Add("Begüm", 20);
            nameAge.Add("Simay", 14);

            Console.WriteLine("Dictionary içerisinde {0} key {1} value bulunmaktadır",nameAge.CountKeys,nameAge.CountValues);

            Console.WriteLine("\n\nKey----->Value\n----------------");
            for (int i = 0; i < nameAge.Keys.Length ; i++)
            {
                Console.WriteLine("{0}----->{1}\n",nameAge.Keys[i],nameAge.Values[i]);
            }
            Console.WriteLine("----------------\n");

            nameAge.Add("Engin", 35);
            nameAge.Add("Ozil", 32);

            Console.WriteLine("Dictionary içerisinde {0} key {1} value bulunmaktadır", nameAge.CountKeys, nameAge.CountValues);

            Console.WriteLine("\n\nKey----->Value\n----------------");
            for (int i = 0; i < nameAge.Keys.Length; i++)
            {
                Console.WriteLine("{0}----->{1}\n", nameAge.Keys[i], nameAge.Values[i]);
            }
            Console.WriteLine("----------------\n");
        }
    }
}
