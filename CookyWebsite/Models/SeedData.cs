using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CookyWebsite.Models
{
  public class SeedData
  {
    public static void EnsurePopulated(IApplicationBuilder app)
    {
      ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

      context.Database.Migrate();

      if (!context.Receipes.Any())
      {
        context.Receipes.AddRange
        (
          new Receipe {
            Name = "Chinese Spareribs",
            Time = 50,
            Ingredient = "Pork",
            Detail = "In a shallow glass dish, mix together the hoisin sauce, ketchup, honey, soy sauce, sake, rice vinegar, lemon juice, ginger, garlic and five-spice powder. Place the ribs in the dish, and turn to coat. Cover and marinate in the refrigerator for 2 hours, or as long as overnight.",
            Category = "Pork"
          },

          new Receipe
          {
            Name = "Chinese Green Bean Stir-Fry",
            Time = 20,
            Ingredient = "Bean",
            Detail = "In a large wok, heat oil over medium-high heat. Stir in green beans; cook, stirring frequently, for 1 to 2 minutes. Stir in garlic and ginger; cook, stirring frequently, for 3 to 4 minutes. Season with salt and pepper, and then stir in black bean sauce. Continue cooking until green beans are tender.",
            Category = "Vegie"
          },

          new Receipe
          {
            Name = "Szechwan Shrimp",
            Time = 20,
            Ingredient = "Shrimp",
            Detail = "In a bowl, stir together water, ketchup, soy sauce, cornstarch, honey, crushed red pepper, and ground ginger. Set aside." +
            "Heat oil in a large skillet over medium-high heat. Stir in green onions and garlic; cook 30 seconds. Stir in shrimp, and toss to coat with oil. Stir in sauce. Cook and stir until sauce is bubbly and thickened.",
            Category = "Seafood"
          },

          new Receipe
          {
            Name = "Kung Pao Chicken",
            Time = 30,
            Ingredient = "Chicken",
            Detail = "To Make Marinade: Combine 1 tablespoon wine, 1 tablespoon soy sauce, 1 tablespoon oil and 1 tablespoon cornstarch/water mixture and mix together. Place chicken pieces in a glass dish or bowl and add marinade. Toss to coat. Cover dish and place in refrigerator for about 30 minutes.",
            Category = "Chicken"
          },

          new Receipe
          {
            Name = "Grilled Asian Chicken",
            Time = 40,
            Ingredient = "Chicken",
            Detail = "In a small microwave-safe bowl, combine the soy sauce, oil, honey, ginger root, and garlic. Heat in microwave on medium for 1 minute, then stir. Heat again for 30 seconds, watching closely to prevent boiling.",
            Category = "Chicken"
          },

          new Receipe
          {
            Name = "Beef Stir-Fry",
            Time = 25,
            Ingredient = "Beef",
            Detail = "Heat vegetable oil in a large wok or skillet over medium-high heat; cook and stir beef until browned, 3 to 4 minutes. Move beef to the side of the wok and add broccoli, bell pepper, carrots, green onion, and garlic to the center of the wok. Cook and stir vegetables for 2 minutes.",
            Category = "Beef"
          },

          new Receipe
          {
            Name = "Eggplant with Garlic Sauce",
            Time = 25,
            Ingredient = "Eggplant",
            Detail = "Heat the canola oil in a skillet over high heat. Cook and stir the eggplant until soft, about 4 minutes. Stir in the water, red pepper flakes, and garlic powder. Cover and simmer until all the water is absorbed. Meanwhile, mix sugar, cornstarch, soy sauce, and oyster sauce in a bowl until sugar and cornstarch have dissolved. Stir sauce into the eggplant, making sure to evenly coat the eggplant. Cook until the sauce has thickened.",
            Category = "Vegie"
          },

          new Receipe
          {
            Name = "Vegetable Lo Mein",
            Time = 30,
            Ingredient = "Noodle",
            Detail = "Bring a large pot of lightly salted water to a boil. Add pasta and cook for 8 to 10 minutes or until al dente; drain.",
            Category = "Noodle"
          },

          new Receipe
          {
            Name = " Spicy Hot And Sour Soup",
            Time = 20,
            Ingredient = "Mushroom",
            Detail = "Soak the dried mushrooms and tiger lily buds in warm water for 20 minutes. After trimming off any tough stems, slice the mushrooms. With the fingers, shred the tiger lily stems.",
            Category = "Soup"
          },

          new Receipe
          {
            Name = "Steamed Buns",
            Time = 50,
            Ingredient = "Meat",
            Detail = "Mix together yeast, 1 teaspoon sugar, 1/4 cup flour, and 1/4 cup warm water. Allow to stand for 30 minutes.",
            Category = "Dianxin"
          }
        );

        context.SaveChanges();
      }
    }
  }
}
