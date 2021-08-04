using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DB
{
    public static class InMemoryDB
    {
        public static List<Product> Products = new List<Product>
        {
            new Product{ ProductId = 1, ProductName = "Product 1", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 2, ProductName = "Product 2", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 3, ProductName = "Product 3", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 4, ProductName = "Product 4", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 5, ProductName = "Product 5", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 6, ProductName = "Product 6", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 7, ProductName = "Product 7", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 8, ProductName = "Product 8", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 9, ProductName = "Product 9", CategoryId = 1, UnitPrice = 100},
            new Product{ ProductId = 10, ProductName = "Product 10", CategoryId = 1, UnitPrice = 100},
        };

        public static List<Category> Categories = new List<Category>
        {
            new Category{ CategoryId = 1, CategoryName = "Shrimp", CategoryDescription = "Seafood"},
            new Category{ CategoryId = 2, CategoryName = "Squeed", CategoryDescription = "Seafood"},
            new Category{ CategoryId = 3, CategoryName = "Date", CategoryDescription = "Fruite"},
            new Category{ CategoryId = 4, CategoryName = "Dried Date", CategoryDescription = "Dried Fruit"}
        };

        public static List<Customer> Customers = new List<Customer>
        {
            new Customer{CustomerId = 1, Organization = "Uniper", Address = "Holzstraße 6", ContactPerson = "Manuel R.", Nationality = "Germany"},
            new Customer{CustomerId = 2, Organization = "Music School", Address = "Charlie 6", ContactPerson = "Issabelle S.", Nationality = "French"},
            new Customer{CustomerId = 3, Organization = "Flughafen", Address = "Neuss 40856", ContactPerson = "Branka R.", Nationality = "Macedonia"},
            new Customer{CustomerId = 4, Organization = "Porsche", Address = "Berlin, Alexanderplatz 54", ContactPerson = "Toni B.", Nationality = "Germany"}
        };
        public static List<Supplier> Suppliers = new List<Supplier>
        {
            new Supplier{Id = 1, CompanyName="Rebyoon", CEOName="Mehdi Khorami", ContactPerson="Mehdi Khorami", Address="Tehran, Iran"},
            new Supplier{Id = 2, CompanyName="Date", CEOName="CEO", ContactPerson="Mehdi Khorami", Address="Istanbul, Turkey"},
            new Supplier{Id = 3, CompanyName="Exchange", CEOName="Ariana", ContactPerson="Arii", Address="Ankara, Turkey"},
        };
    }
}
