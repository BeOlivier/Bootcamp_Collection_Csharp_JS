using System;
using System.Collections.Generic;
using Xunit;
using Commodore64;
using Commodore64.Models;
using FluentAssertions;

namespace Commodore64Tests
{
    public class Commodore64Tests
    {
        private bool methodExists(string methodName) => typeof(Commodore).GetMethod(methodName) != null;

        
        [Fact]
        public void InterpreterShouldExist()
        {
            methodExists("Interpreter").Should().BeTrue();
        }


        [Fact]
        public void Interpreter_should_return_hello()
        {
            // arrange
            var commodore = new Commodore();
            string[] argument = new[] { "PRINT \"Hello World!\"", "PRINT \"Hello World!\"" };
            // act
            var result = commodore.Interpreter(argument);
            var printer = new Printer(null, argument[0]);
            var printer2 = new Printer(null, argument[1]);
            var printerList = new List<Printer>() { printer, printer2 };

            // assert
            result.Equals(new Printers(printerList));
        }
        [Fact]
        public void InterpreterWith2Prints1Number_should_return_proper()
        {
            // arrange
            var commodore = new Commodore();
            string[] argument = new[] { "PRINT \"Hello World!\"", "PRINT \"Hello World!\"", "A=62" };
            // act
            var result = commodore.Interpreter(argument);
            var printer = new Printer(new Numbers(new List<Number>(){new Number("A", 62)}), argument[0]);
            var printer2 = new Printer(new Numbers(new List<Number>(){new Number("A", 62)}), argument[1]);
            var printer3 = new Printer(new Numbers(new List<Number>(){new Number("A", 62)}), null);
            var printerList = new List<Printer>() { printer, printer2, printer3};

            // assert
            result.Equals(new Printers(printerList));
        }
    }
}