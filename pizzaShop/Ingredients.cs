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

            pizza olives = new pizza(1, "olives","","", Category.INGREDIENTS, 2);
            InMenuIngredients.Add(olives);
            pizza cheese = new pizza(2, "cheese","","", Category.INGREDIENTS, 1.5);
            InMenuIngredients.Add(cheese);
            pizza ananas = new pizza(3, "ananas","","", Category.INGREDIENTS, 0.9);
            InMenuIngredients.Add(ananas);
            pizza jalapeno = new pizza(4, "jalapeno", "", "", Category.INGREDIENTS, 0.7);
            InMenuIngredients.Add(jalapeno);
            pizza pizzaSauce = new pizza(5, "pizza sauce", "", "", Category.INGREDIENTS, 0.7);
            InMenuIngredients.Add(pizzaSauce);
            pizza ham = new pizza(6, "ham", "", "", Category.INGREDIENTS, 3.5);
            InMenuIngredients.Add(ham);
            pizza chicken = new pizza(7, "chicken", "", "", Category.INGREDIENTS, 3.5);
            InMenuIngredients.Add(chicken);
            pizza smokedChicken = new pizza(7, "smoked chicken", "", "", Category.INGREDIENTS, 3.5);
            InMenuIngredients.Add(smokedChicken);
            pizza tunaFish = new pizza(8, "tuna fish", "", "", Category.INGREDIENTS, 3.5);
            InMenuIngredients.Add(tunaFish);

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
        public pizza GetFromMenuIngredients(int id)
        {
            return InMenuIngredients[id - 1];
        }
    }
}
