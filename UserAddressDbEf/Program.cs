// See https://aka.ms/new-console-template for more information


using Microsoft.EntityFrameworkCore;
using System.Linq;
using MyDBApp;
//
// if (args.Length == 0)
// {
//     Console.WriteLine("all users");
//     return;
// }
if (args.Length != 0)
{
    if (!int.TryParse(args[0], out var id))
    {
        var printer = new MyContext();
        printer.PrintBySearchName(args[0]);

    }
    else
    {
        var printer = new MyContext();
        printer.PrintAddressById(id);

    }

}
else
{
    var printer = new MyContext();
    printer.PrintFNames();
}


// Console.WriteLine(args[0]);

public class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? City { get; set; }
    public string? Zip { get; set; }
    
}

namespace MyDBApp
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=CRMSystem;User Id=sa;password=Password_2_Change_4_Real_Cases_&");
        } 
        
        public void PrintFNames()
        {
            using var db = new MyContext();
            var UserList = db.Users.ToList();
            // Console.WriteLine(db.Users.Where(u => u.FirstName == "Ram").ToList()[0].LastName);
            // UserList.Select(x => Console.WriteLine(x.FirstName + " " + x.LastName));
            foreach (var x in UserList)
            {
                Console.WriteLine(x.FirstName + " " + x.LastName);
            }
        }

        public void PrintBySearchName(string partialName)
        {
            using var db = new MyContext();
            var UserList = db.Users.Where(x => x.FirstName.Contains(partialName)).ToList();
            foreach (var x in UserList)
            {
                Console.WriteLine(x.FirstName + " " + x.LastName);
            }

        }

        public void PrintAddressById(int id)
        {
            using var db = new MyContext();
            var user = db.Users.Where(x => x.Id == id).ToList();
            Console.WriteLine(user[0].City);
        }
    }
}



