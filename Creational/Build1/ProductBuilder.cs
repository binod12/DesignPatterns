using System.Collections.Generic;

namespace DesignPatterns.Creational.Build1
{
  public static class ProductBuilder
  {
    public static Product CreateBuilder()
    {
      return new Product();
    }

    public static Product AddId(this Product product, int id)
    {
      product.Id = id;
      return product;
    }

    public static Product AddName(this Product product, string name)
    {
      product.Name = name;
      return product;
    }

    public static Product AddDescription(this Product product, string description)
    {
      product.Description = description;
      return product;
    }

    public static Product AddCategories(this Product product, List<Category> categories)
    {
      product.Categories = categories;
      return product;
    }
  }
}
