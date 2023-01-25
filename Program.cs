using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double teotihuacanArea = ((Rectangle(2500,1500)) + ((Circle(375))/2) + (Triangle(750,500)));

      double cost = Math.Round((teotihuacanArea * 180), 2);

      Console.WriteLine($"The total cost of flooring material for the Teotihuacan in Mexico City, Mexico is {cost} pesos.");
    }
    //methods
    static double Rectangle(double length, double width)
    {
      double area = length * width;
      return area;
    }

    static double Circle(double radius)
    {
      double area = Math.PI * Math.Pow(radius, 2);
      return area;
    }

    static double Triangle(double bottom, double height)
    {
      double area = 0.5 * bottom * height;
      return area;
    }
  }
}
