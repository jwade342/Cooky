using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CookyWebsite.Models
{
  public class Receipe
  {
    public int ReceipeId { get; set; }

    [Required(ErrorMessage = "Please enter a name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter a time")]
    public int Time { get; set; }

    [Required(ErrorMessage = "Please enter ingredients")]
    public string Ingredient { get; set; }

    [Required(ErrorMessage = "Please enter details")]
    public string Detail { get; set; }

    [Required(ErrorMessage = "Please enter a category")]
    public string Category { get; set; }

  }
}