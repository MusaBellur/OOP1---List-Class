using OOP1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 1500;
            product1.UnitIsStock = 100;

            Product product2 = new Product { Id = 2, CategoryId = 4, ProductName = "Pencil", UnitIsStock = 12000, UnitPrice = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
        }
    }
}