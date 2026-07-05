using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
		public static string BuzzFizzer(string element)
		{
			if (!int.TryParse(element, out var result)) return "Bad input";
			if (result % 5 == 0 && result % 3 == 0) return "FizzBuzz";
			if (result % 3 == 0 ) return "Fizz";
			if (result % 5 == 0) return "Buzz";
			return element;

		}
		public static string[] FizzBuzzer(string[] args, int index)
		{
			if (index != args.Length - 1)
			{
				var array = FizzBuzzer(args, index + 1).Select(x => BuzzFizzer(x)).ToArray();
				// array[index] = BuzzFizzer(args[index]);
				// var array2 = array.Select(x => x = BuzzFizzer(x)).ToArray();
				return array;
			}
			else
			{
				// var array = new string[args.Length];
				// array[index] = BuzzFizzer(args[index]);
				return new string[1] { BuzzFizzer(args[index])};
			}
		}
        public static void Main(string[] args)
        {
            string[] array = new string[] {"1", "2", "me too", "3", "4", "on fire", "33", "15", "45", "lol. lmao even!"};
			string[] retarray = FizzBuzzer(array, 0);
			foreach (var element in retarray)
			{
				Console.WriteLine(element);
			}
        }
    }
}