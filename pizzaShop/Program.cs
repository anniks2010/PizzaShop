using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu itemsInMenu = new Menu();
            ShoppingCart itemsInShoppingCart = new ShoppingCart();
            Ingredients ExtraIngredients = new Ingredients();

            itemsInMenu.PrintMenu();

            AddToShoppingCart(itemsInMenu, itemsInShoppingCart);

            while (true)   
            {
            
             Console.WriteLine("Would you like to add more pizzas to shopping cart? (yes/no)");
             string userInput = Console.ReadLine().ToLower();

                if (userInput == "yes")
                {
                    AddToShoppingCart(itemsInMenu, itemsInShoppingCart);
                    
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("Would you like to add some extra ingredients? (yes/no)");
                    string userInput2 = Console.ReadLine().ToLower();

                    if (userInput2 == "yes")
                    {
                        ExtraIngredients.PrintIngredients();
                        AddToShoppingCart(itemsInMenu, itemsInShoppingCart);
                    }
                    if (userInput2 == "no")
                    {
                        Console.WriteLine("Would you like to confirm your order? (yes/no)");
                        string userInput3 = Console.ReadLine();

                        if (userInput3 == "yes")
                        {
                            Console.Clear();
                            Console.WriteLine($"Total amount of shoppingcart is {shoppingCart.Total} $");
                        }
                    }
                }

            }




            Console.ReadLine();


           
        }
        public static void AddToShoppingCart(Menu itemsInMenu, ShoppingCart itemsInShoppingCart)
        {
            Console.WriteLine($"Enter the id of the pizza or extra ingredients on menu to add it to the shopping cart: ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            pizza articleToAdd = itemsInMenu.GetFromMenu(productId);
            itemsInShoppingCart.AddToShoppingCart(articleToAdd, quantity);
            itemsInShoppingCart.PrintShoppingCart();
        }
    }
}
