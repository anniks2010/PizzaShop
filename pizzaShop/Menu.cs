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

            pizza hawaij = new pizza(1, "Hawaij_pizza", "Cheese, tex-mex sauce, barbeque chicken, onion","thin dough", Category.PIZZA_TYPE, 8.5);
            InMenu.Add(hawaij);
            pizza hawaijWithThickDough = new pizza(2, "Hawaij_pizza", "Cheese, tex-mex sauce, barbeque chicken, onion","thick dough", Category.PIZZA_TYPE, 8.5);
            InMenu.Add(hawaijWithThickDough);
            pizza meat = new pizza(3, "meat_pizza", "Pizza sauce, cheese, shrimps, crab meat","thin dough", Category.PIZZA_TYPE, 10.6);
            InMenu.Add(meat);
            pizza meatWithThickDough = new pizza(4, "meat_pizza", "Pizza sauce, cheese, shrimps, crab meat", "thick dough", Category.PIZZA_TYPE, 10.6);
            InMenu.Add(meatWithThickDough);
            pizza children = new pizza(5, "children_pizza", "Pizza sauce, cheese, smoked chicken, sweet pepper","thin dough", Category.PIZZA_TYPE, 5.5);
            InMenu.Add(children);
            pizza childrenWithThickDough = new pizza(6, "children_pizza", "Pizza sauce, cheese, smoked chicken, sweet pepper", "thick dough", Category.PIZZA_TYPE, 5.5);
            InMenu.Add(childrenWithThickDough);
            pizza veggy = new pizza(7, "veggy_pizza", "Pizza sauce, cheese, broccoli, sweet pepper,", "thin dough", Category.PIZZA_TYPE, 6);
            InMenu.Add(veggy);
            pizza veggyWithTcikDough = new pizza(8, "veggy_pizza", "Pizza sauce, cheese, broccoli, sweet pepper,", "thick dough", Category.PIZZA_TYPE, 6);
            InMenu.Add(veggyWithTcikDough);
            pizza fish = new pizza(9, "fish_pizza","Pizza sauce, cheese, bacon, tuna fish","thin dough", Category.PIZZA_TYPE, 9.9);
            InMenu.Add(fish);
            pizza fishWithThickDough = new pizza(10, "fish_pizza", "Pizza sauce, cheese, bacon, tuna fish", "thick dough", Category.PIZZA_TYPE, 9.9);
            InMenu.Add(fishWithThickDough);
            pizza custom = new pizza(11, "custome_pizza", "","thin dough", Category.PIZZA_TYPE, 7.6);
            InMenu.Add(custom);
            pizza customWithThickDough = new pizza(12, "custome_pizza", "","thick dough", Category.PIZZA_TYPE, 7.6);
            InMenu.Add(customWithThickDough);
        
        }
        public void PrintMenu()
        {
            foreach (pizza pizza in InMenu)
            {
                Console.WriteLine($"ID: {pizza.Id}");
                Console.WriteLine($"Product: {pizza.Name}");
                Console.WriteLine($"Ingredients: {pizza.Ingredients}");
                Console.WriteLine($"Dough: {pizza.Dough}");
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
