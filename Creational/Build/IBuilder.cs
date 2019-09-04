using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Build
{

  public class Director
  {
    public static void Construct(IBuilder builder)
    {
      builder.BuildPart1();
      builder.BuildPart2();
      builder.BuildPart3();
    }
  }

  public class ConcreteBuilder : IBuilder
  {
    Product _product = new Product();

    public void BuildPart1()
    {
      _product.Part1 = "Part 1 built";
    }

    public void BuildPart2()
    {
      _product.Part2 = "Part 2 built";
    }

    public void BuildPart3()
    {
      _product.Part3 = "Part 3 built";
    }

    public Product GetProduct()
    {
      return _product;
    }
  }
  public class Product
  {
    public string Part1 { get; set; }
    public string Part2 { get; set; }
    public string Part3 { get; set; }

  }
  public interface IBuilder
  {
    void BuildPart1();
    void BuildPart2();
    void BuildPart3();
    Product GetProduct();

  }

}
