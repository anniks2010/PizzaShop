using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class Ingredients
    {

        List<pizza> InMenuIngredients;
        public Ingredients()
        {
            InMenuIngredients = new List<pizza>();

            pizza olives = new pizza(7, "olives", Category.INGREDIENTS, 2);
            InMenuIngredients.Add(olives);
            pizza cheese = new pizza(8, "cheese", Category.INGREDIENTS, 1.5);
            InMenuIngredients.Add(cheese);
            pizza ananas = new pizza(9, "ananas", Category.INGREDIENTS, 0.9);
            InMenuIngredients.Add(ananas);
        }


        public void PrintIngredients()
        {
            foreach (pizza pizza in InMenuIngredients)
            {
                Console.WriteLine($"ID: {pizza.Id}");
                Console.WriteLine($"Product: {pizza.Name}");
                Console.WriteLine($"Category: {pizza.Category}");
                Console.WriteLine($"Price: {pizza.Price}");
                Console.WriteLine();
            }
        }
    }
}
