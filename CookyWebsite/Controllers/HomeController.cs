using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CookyWebsite.Models;
using CookyWebsite.Models.ViewModels;

namespace CookyWebsite.Controllers
{
  public class HomeController : Controller
  {
    private readonly IReceipeRepository repository;

    public int PageSize = 5;
    
    public HomeController(IReceipeRepository repo)
    {
      repository = repo;
    }
    
    public ViewResult Index()
    {
      return View();
    }

    [HttpGet]
    public ViewResult Discover(int page = 1)
    {
      return View(new ReceipeListViewModel
      {
        Receipes = repository.Receipes.OrderBy(r => r.ReceipeId)
                                      .Skip((page - 1) * PageSize)
                                      .Take(PageSize),
        PagingInfo = new PagingInfo 
        { 
          CurrentPage = page,
          ItemsPerPage = PageSize,
          TotalItems = repository.Receipes.Count()
        }
      });
    }

    [HttpPost]
    public ViewResult Discover(string name)
    {
      return base.View("ViewReceipe", Models.repository.Receipes.FirstOrDefault(r => r.Name == name));
    }


    public ViewResult ViewReceipe(int receipeID) => View(repository.Receipes.FirstOrDefault(r => r.ReceipeId == receipeID));
    
    public ViewResult Learn()
    {
      return View();
    }
    public ViewResult Review()
    {
      return View();
    }

    
  }
}
