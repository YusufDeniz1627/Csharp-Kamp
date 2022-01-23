using System;
using System.Collections.Generic;

namespace Day_4_odev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<string>();
            names.Add("Yusuf");
            names.Add("Faruk");
            names.Add("Engin");
            names.Add("Ayşe");
            Console.WriteLine(names.Count);
            
            MyList<String> name = new MyList<string>();
            name.add("Yusuf");
            name.add("Faruk");
            name.add("Engin");
            name.add("Ayşe");
            Console.WriteLine(name.Count);
            
        }
    }
}
