using DesignPatterns.Creational.Build1;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{

  class Program
  {
    static void Main(string[] args)
    {
      Category category = new Category { CategoryId = 1, CategoryName = "Category One" };
      List<Category> categories = new List<Category>();
      categories.Add(category);

      Product product = ProductBuilder.CreateBuilder()
        .AddId(1)
        .AddName("Product name")
        .AddDescription("Description")
        .AddCategories(categories);

      Console.WriteLine($"{product.Id}, {product.Name}");
    }
  }
}
