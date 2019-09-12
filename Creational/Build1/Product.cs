using System.Collections.Generic;

namespace DesignPatterns.Creational.Build1
{
  public class Product
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }

    public List<Category> Categories { get; set; }

    public Product()
    {
      Categories = new List<Category>();
    }
   
  }
}
