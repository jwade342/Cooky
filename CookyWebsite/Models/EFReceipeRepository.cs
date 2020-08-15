using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookyWebsite.Models
{
  public class EFReceipeRepository : IReceipeRepository
  {
    private ApplicationDbContext context;

    public EFReceipeRepository(ApplicationDbContext ctx)
    {
      context = ctx;
    }

    public IQueryable<Receipe> Receipes => context.Receipes;

    public void SaveReceipe(Receipe receipe)
    {
      if (receipe.ReceipeId == 0)
      {
        context.Receipes.Add(receipe);
      }
      else
      {
        Receipe receipeEntry = context.Receipes.FirstOrDefault(r => r.ReceipeId == receipe.ReceipeId);

        if (receipeEntry != null)
        {
          receipeEntry.Name = receipe.Name;
          receipeEntry.Time = receipe.Time;
          receipeEntry.Ingredient = receipe.Ingredient;
          receipeEntry.Detail = receipe.Detail;
          receipeEntry.Category = receipe.Category;
        }
      }

      context.SaveChanges();
    }

    public Receipe DeletedReceipe(int receipeID)
    {
      Receipe receipeEntry = context.Receipes.FirstOrDefault(r => r.ReceipeId == receipeID);

      if (receipeEntry != null)
      {
        context.Receipes.Remove(receipeEntry);
        context.SaveChanges();
      }

      return receipeEntry;
    }
  }
}
