using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            var cities = new MyDictionary<int,string>();
            cities.Add(55, "Samsun");
            cities.Add(07, "Antalya");
            cities.Add(61, "Trabzon");
            cities.Add(53, "Rize");
            cities.Add(28, "Giresun");

            foreach (var city in cities.Keys)
            {
                Console.WriteLine(city);
            }

            foreach(var city2 in cities.Keys2)
            {
                Console.WriteLine(city2);
            }

        }
        
    }
}
