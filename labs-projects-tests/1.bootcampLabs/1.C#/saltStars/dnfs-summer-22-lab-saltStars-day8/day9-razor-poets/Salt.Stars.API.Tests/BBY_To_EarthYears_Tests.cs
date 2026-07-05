using Xunit;
using FluentAssertions;
using Salt.Stars.API.Models;

namespace Salt.Stars.API.Tests
{

  public class BBY_To_EarthYears_Tests
  {
    [Theory]
    [InlineData("0ABY", "1850 A.C.")]
    [InlineData("1ABY", "1851 A.C.")]
    [InlineData("1BBY", "1849 A.C.")]
    [InlineData("122ABY", "1972 A.C.")]
    [InlineData("172ABY", "2022 A.C.")]
    [InlineData("1849BBY", "1 A.C.")]
    [InlineData("1850BBY", "0 A.C.")]
    [InlineData("1851BBY", "1 B.C.")]
    [InlineData("1852BBY", "2 B.C.")]
    public void should_convert_birth_year_to_earth_year(string birthYear, string expectedEarthYear)
    {
      // arrange
      var hero = new Hero { BirthYear = birthYear };

      // act
      var earthBirthYear = hero.EarthBirthYear;

      // assert
      earthBirthYear.Should().Be(expectedEarthYear);
    }

    [Fact]
    public void should_set_earthBirthYear_to_empty_for_empty_birthYear()
    {
      // arrange
      var hero = new Hero { BirthYear = string.Empty };

      // act
      var earthBirthYear = hero.EarthBirthYear;

      // assert
      earthBirthYear.Should().Be(string.Empty);
    }

    [Theory]
    [InlineData("41.9BBY")]
    [InlineData("NOT EVEN SURE")]
    public void should_return_empty_string_for_non_integers(string birthYear)
    {
      // arrange
      var hero = new Hero { BirthYear = birthYear };

      // act
      var earthBirthYear = hero.EarthBirthYear;

      // assert
      earthBirthYear.Should().Be(string.Empty);
    }

    [Fact]
    public void should_set_earthBirthYear_to_empty_for_strange_birthYear()
    {
      // arrange
      var hero = new Hero { BirthYear = "13425CRC" };

      // act
      var earthBirthYear = hero.EarthBirthYear;

      // assert
      earthBirthYear.Should().Be(string.Empty);
    }
  }
}