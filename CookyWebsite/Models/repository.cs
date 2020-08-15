using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookyWebsite.Models
{
  public static class repository
  {
    private static List<Receipe> receipes = new List<Receipe>()
      {
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
        new Receipe { Name = "Beef", Time = 10, Category = "Meat"},
      };

    public static List<Receipe> Receipes
    {
      get
      {
        return receipes;
      }
    }

    public static void AddReceipe(Receipe r)
    {
      receipes.Add(r);
    }
  }
}
