using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class Menu
    {
        List<pizza> InMenu;

        public Menu()
        {
            InMenu = new List<pizza>();

            pizza chicken = new pizza(1, "chicken_pizza", Category.PIZZA_TYPE, 8.5);
            InMenu.Add(chicken);
            pizza meat = new pizza(2, "meat_pizza", Category.PIZZA_TYPE, 10.6);
            InMenu.Add(meat);
            pizza children = new pizza(3, "children_pizza", Category.PIZZA_TYPE, 5.5);
            InMenu.Add(children);
            pizza veggy = new pizza(4, "veggy_pizza", Category.PIZZA_TYPE, 6);
            InMenu.Add(veggy);
            pizza fish = new pizza(5, "fish_pizza", Category.PIZZA_TYPE, 9.9);
            InMenu.Add(fish);
            pizza custom = new pizza(6, "custome_pizza", Category.PIZZA_TYPE, 7.6);
            InMenu.Add(custom);
            /*pizza olives = new pizza(7, "olives", Category.INGREDIENTS, 2);
            InMenu.Add(olives);
            pizza cheese = new pizza(8, "cheese", Category.INGREDIENTS, 1.5);
            InMenu.Add(cheese);
            pizza ananas = new pizza(9, "ananas", Category.INGREDIENTS, 0.9);
            InMenu.Add(ananas);*/
            pizza thin = new pizza(10, "thin_dough", Category.DOUGH, 0);
            InMenu.Add(thin);
            pizza thick = new pizza(11, "thick_dough", Category.DOUGH, 2);
            InMenu.Add(thick);
        }
        public void PrintMenu()
        {
            foreach (pizza pizza in InMenu)
            {
                Console.WriteLine($"ID: {pizza.Id}");
                Console.WriteLine($"Product: {pizza.Name}");
                Console.WriteLine($"Category: {pizza.Category}");
                Console.WriteLine($"Price: {pizza.Price}");
                Console.WriteLine();
            }

        }
        public pizza GetFromMenu(int id)
        {
            return InMenu[id - 1]; 
        }
    }
}
