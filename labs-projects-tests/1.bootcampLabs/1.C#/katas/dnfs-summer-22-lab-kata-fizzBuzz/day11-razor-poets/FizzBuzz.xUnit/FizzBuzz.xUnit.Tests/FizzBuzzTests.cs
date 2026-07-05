using System;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.xUnit.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(new string[] {"1", "4", "7", "48", "99"}, new string[] {"1", "4", "7", "Fizz", "Fizz"})]
        [InlineData(new string[] {"3", "5", "15"}, new string[] {"Fizz", "Buzz", "FizzBuzz"})]
        [InlineData(new string[] {"1", "4", "-3"}, new string[] {"1", "4", "this should be a positive number"})]
        [InlineData(new string[] {"1","foo"}, new string[] {"1", "incorrect string format, should be a number between 1 and 100"})] 
        //                                                        "Bogus, should be a number between 1 and 100"})]

        public void print_correct_number_for_array_position(string[] arg, string[] output)
        {
            //arrange
            var gameMachine = new FizzBuzz();

            //act
            var result = gameMachine.FizzBuzzer(arg);

            //assert
            result.Should().Equal(output);
        }

        [Theory]
        [InlineData(new string[]{}, false)]
        [InlineData(null, false)]
        public void checker_should_detect_empty_strings(string[] arg, bool output)
        {
             //arrange
            var gameMachine = new FizzBuzz();

            //act
            var result = gameMachine.Checker(arg);

            //assert
            result.Should().Be(output);
        }
        [Theory]
        [InlineData(new string[]{"1", "2", "3"}, "Fizz", 2)]
        [InlineData(new string[]{"1", "15", "3"}, "FizzBuzz", 1)]
        [InlineData(new string[]{"1", "2", "3", "5"}, "Buzz", 3)]
        public void fizzbuzzer_should_give_correct_keyword(string[] arg, string output, int index)
        {
             //arrange
            var gameMachine = new FizzBuzz();

            //act
            var result = gameMachine.FizzBuzzer(arg);

            //assert
            result[index].Should().Be(output);
        }


    }
}
