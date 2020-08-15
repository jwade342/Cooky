using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookyWebsite.Models
{
  public interface IReceipeRepository
  {
    IQueryable<Receipe> Receipes { get; }

    void SaveReceipe(Receipe receipe);

    Receipe DeletedReceipe(int receipeID);    
  }
}
