using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var genericListOfInteger = new GenericList<int>();
            genericListOfInteger.Add(5);
            genericListOfInteger.Add(4);

            var genericListOfStrings = new GenericList<string>();
            genericListOfStrings.Add("First");
            genericListOfStrings.Add("Second");

            var genericsDictionary = new GenericsDictionary<int, string>();
            genericsDictionary.Add(1, "First");
            genericsDictionary.Add(2, "Second");

            Nullable<int> nullInt = new Nullable<int>();
            Console.WriteLine("HasValue : " + nullInt.HasValue);
            Console.WriteLine("Value or Default : " + nullInt.GetValueOrDefault);


            Nullable<int> notNullInt = new Nullable<int>(5);
            Console.WriteLine("HasValue : " + notNullInt.HasValue);
            Console.WriteLine("Value or Default : " + notNullInt.GetValueOrDefault);
        }
    }
}
