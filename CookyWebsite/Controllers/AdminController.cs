using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CookyWebsite.Models;
using CookyWebsite.Models.ViewModels;

namespace CookyWebsite.Controllers
{
  public class AdminController : Controller
  {
    private IReceipeRepository repository;

    public AdminController(IReceipeRepository repo)
    {
      repository = repo;
    }

    [HttpGet]
    public ViewResult Share()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Share(Receipe receipe)
    {
      repository.SaveReceipe(receipe);
      return RedirectToAction("Discover", "Home");
    }

    public ViewResult Edit(int receipeID) => View(repository.Receipes.FirstOrDefault(r => r.ReceipeId == receipeID));

    [HttpPost]
    public IActionResult Edit(Receipe receipe)
    {
      if (ModelState.IsValid)
      {
        repository.SaveReceipe(receipe);
        TempData["message"] = $"{receipe.Name} has been saved";
        return RedirectToAction("Discover", "Home");
      }
      else
      {
        return View(receipe);
      }
    }

    [HttpPost]
    public IActionResult Delete(int receipeID)
    {
      Receipe deletedReceipe = repository.DeletedReceipe(receipeID);

      if (deletedReceipe != null)
      {
        TempData["message"] = $"{deletedReceipe.Name} was deleted";
      }

      return RedirectToAction("Discover", "Home");
    }
  }
}
