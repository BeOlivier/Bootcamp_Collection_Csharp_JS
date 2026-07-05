using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Patterns.Business.SaltBusiness;
using System.Linq;

namespace Patterns.Tests
{
    public class SaltBusinessTests
    {
        private List<Customer> _theList = new List<Customer>()
        {
            new Customer("Stockholm", 50, 6868),
            new Customer("Oslo", 12, 10),
            new Customer("Malmö", 50, 1337)
        };

        [Fact]
        public void CreateShouldIncreaselistSize()
        {
            //arrange
            var repo = new InMemoryRepository(_theList);
            //act
            repo.Create(new Customer("Forest", 7, 4));
            //assert
            repo.Read().Count.Should().Be(4);
        }

        [Fact]
        public void ReadShouldReturn3()
        {
            var repo = new InMemoryRepository(_theList);

            repo.Read().Count.Should().Be(3);
        }

        [Fact]
        public void updateshouldchangelement()
        {
            var repo = new InMemoryRepository(_theList);
            repo.Update(new Customer("Forest", 7, 6868));
            var custCity = repo.Read()[0].GetCity();

            custCity.Should().Be("Forest");
        }

        [Fact]
        public void deleteshoulddecreasesize()
        {
            var repo = new InMemoryRepository(_theList);
            var customer = new Customer("Malmö", 50, 1337);
            repo.Delete(customer);

            repo.Read().Count.Should().Be(2);
        }

        [Fact]
        public void getcustbycityshouldbe2()
        {   
            var repo = new InMemoryRepository(_theList);
            var customer = new Customer("Malmö", 32, 1212);
            repo.Create(customer);
            repo.FindCustomerByCity("Malmö").Count.Should().Be(2);
            repo.FindCustomerByShoeSize(50).Count.Should().Be(2);


        }
}
}