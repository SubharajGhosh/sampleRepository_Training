using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("Madrid");
            cities.Add("Lisbon");
            cities.Add("Turin");
            cities.Add("Manchester");
            cities.Add("118");
            //cities.AddRange(cities);
            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}
            ////cities.InsertRange(0, cities);
            //cities.RemoveRange(3,7);            
             foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("____________________________");
            cities.Reverse();
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Capacity:" + cities.Count);
        }
    }
}
