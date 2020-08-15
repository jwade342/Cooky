using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookyWebsite.Models;

namespace CookyWebsite.Models.ViewModels
{
  public class ReceipeListViewModel
  {
    public IEnumerable<Receipe> Receipes { get; set; }
    public PagingInfo PagingInfo { get; set; }
  }
}
