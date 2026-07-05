using System;
using FluentAssertions;
using Salt.Stars.API.Models;
using Xunit;

namespace Salt.Stars.API.Tests
{
    public class PlanetModelsTests
    {
        [Fact]
        public void should_return_homeworld_20()
        {
            // act
            var planet = new Planet
            {
                Url = "https://swapi.py4e.com/api/planets/20/"
            };
            var planetID = planet.PlanetID;

            // assert
            planetID.Should().Be(20);
        }
    }
}