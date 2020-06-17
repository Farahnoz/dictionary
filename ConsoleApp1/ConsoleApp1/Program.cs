using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> people = new Dictionary<char, string>();
            people.Add('a',"Fara");
            people.Add('b',"Mary");
            people.Add('c',"David");
            foreach(KeyValuePair<char,string> KeyValues in people)
            {
                Console.WriteLine(KeyValues.Key+" - "+KeyValues.Value);
            }
            foreach(char c in people.Keys)
            {
                Console.WriteLine(c);
            }
            foreach(string p in people.Values)
            {
                Console.WriteLine(p);
            }
            Console.Read();
        }
    }
}