using System;
using System.Collections.Generic;
using System.Linq;
using Commodore64.Models;

namespace Commodore64
{
    public class Commodore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public Printers Interpreter(string[] input)
        {
            // var lists = new List<Printer>(){};
            // var printerList = input.Where(x => x.Contains("PRINT")).ToList();
            // foreach (var printer in printerList)
            // {
            //     lists.Add(new Printer(null, printer));
            // }
            // var printers = new Printers(lists);
            // return printers;
            var numbers = new Numbers(NumberListCreator(input));
            var printers = PrinterListCreator(input, numbers);
            return new Printers(printers);
        }

        public List<Printer> PrinterListCreator(string[] input, Numbers numbers)
        { 
            var lists = new List<Printer>();
            var printerList = input.Where(x => x.Contains("PRINT")).ToList();
            foreach (var printer in printerList)
            {
                lists.Add(new Printer(numbers, printer));
                
            }

            return lists;
        }

        public List<Number> NumberListCreator(string[] input)
        {
            var lists = new List<Number>();
            var numberList = input.Where(x => x.Contains("=") && x.Length >= 3).ToList();
            foreach (var num in numberList)
            {
                lists.Add(new Number(num[0].ToString(), int.Parse(num[2..])));
            }

            return lists;
        }
    }
}