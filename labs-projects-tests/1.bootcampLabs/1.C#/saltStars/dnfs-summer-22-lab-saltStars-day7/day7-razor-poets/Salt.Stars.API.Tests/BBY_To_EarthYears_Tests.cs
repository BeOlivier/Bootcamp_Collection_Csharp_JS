using Xunit;
using System;
using Salt.Stars.API.Models;
using FluentAssertions;

namespace Salt.Stars.API.Tests
{
    public class BBY_To_EarthYears_Tests
    {
        [Fact]
        public void should_give_earth_birth_year_1850AC()
        {
            //arrange
            var hero = new Hero(); //this is Hero instantiation;
            hero.BirthYear = "0ABY";
            
            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("1850 A.C.");
        }
        
        [Fact]
        public void should_give_earth_birth_year_1849AC()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "1BBY";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("1849 A.C.");
        }
        [Fact]
        public void should_give_earth_birth_year_1BC()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "1851BBY";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("1 B.C.");
        }
        
        [Fact]
        public void should_give_earth_birth_year_1AC()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "1849BBY";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("1 A.C.");
        }
        
        
        [Fact]
        public void should_give_earth_birth_year_1850AC_b()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "0BBY";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("1850 A.C.");
        }
        
        //Salt.Stars.API.Models.Hero.Birth_Year =
        //1851BBY should give
        //Salt.Stars.API.Models.Hero.EarthBirthYear = 1 B.C.
        
        [Fact]
        public void earth_birth_year_should_return_empty_string_no_ints()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "AHi I'm a string";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("");
        }
        [Fact]
        public void earth_birth_year_should_return_empty_string_no_letters()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "538612312";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("");
        }
        
        [Fact]
        public void earth_birth_year_should_return_empty_string_null()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = null;

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("");
        }
        //To check if a string contains a string
        //use "mystring".Contains("s") // true

        //To check if a string contains any of
        //list of strings use listOfString.Any(s =>
        //"mystring".Contains(s)); // true.

        //More tests
        [Fact]
        public void earth_birth_year_should_return_empty_string_incorrect_format()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "17ABBY";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("");
        }
        [Fact]
        public void earth_birth_year_should_handle_doubles_smaller_than_1850()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "1.5BBY";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("1848.5 A.C.");
        }
        
        [Fact]
        public void earth_birth_year_should_handle_doubles_larger_than_1850DV()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "41.9BBY";

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("1808.1 A.C.");
        }
        
        [Fact]
        public void earth_birth_year_should_handle_doubles_larger_than_1850()
        {
            //arrange
            var hero = new Hero();
            hero.BirthYear = "1850.9BBY";
            // 1850.0 - 1850.9 = -0.9

            //act
            var earthBirthYear = hero.EarthBirthYear;

            //assert
            earthBirthYear.Should().Be("0.9 B.C.");
        }
    }
}