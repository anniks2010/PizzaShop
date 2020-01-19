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
            Ingredients extraIngredients = new Ingredients();

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
                        extraIngredients.PrintIngredients();
                        AddToShoppingCart2(extraIngredients, itemsInShoppingCart);

                        Console.WriteLine("Would you like to confirm your order? (yes/no)");
                        string userInput3 = Console.ReadLine();

                        if (userInput3 == "yes")
                        {
                            Console.Clear();
                            itemsInShoppingCart.PrintShoppingCart();
                            itemsInShoppingCart.PrintTotal();
                            Console.WriteLine($"Total amount of shoppingcart is {itemsInShoppingCart.Total} $");
                            break;
                        }


                    }
                    if (userInput2 == "no")
                    {
                        Console.WriteLine("Would you like to confirm your order? (yes/no)");
                        string userInput3 = Console.ReadLine();

                        if (userInput3 == "yes")
                        {
                            Console.Clear();
                            itemsInShoppingCart.PrintShoppingCart();
                            itemsInShoppingCart.PrintTotal();
                            Console.WriteLine($"Total amount of shoppingcart is {itemsInShoppingCart.Total} $");
                            break;
                        }
                    }
                }

            }




            Console.ReadLine();


           
        }
        public static void AddToShoppingCart(Menu itemsInMenu, ShoppingCart itemsInShoppingCart)
        {
            Console.WriteLine($"Enter the id of the pizza on menu to add it to the shopping cart: ");
            int productId = int.Parse(Console.ReadLine());

            if (productId == 11 || productId == 12)
            {
                Ingredients extraIngredients = new Ingredients();
                extraIngredients.PrintIngredients();
                Console.WriteLine($"Enter 4 ingredients from the aboved list:");
                string userInput = Console.ReadLine();


            }
        
            
            Console.WriteLine("Enter the numbers of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            pizza articleToAdd = itemsInMenu.GetFromMenu(productId);
            itemsInShoppingCart.AddToShoppingCart(articleToAdd, quantity);
            itemsInShoppingCart.PrintShoppingCart();
            


          
        }
        public static void AddToShoppingCart2(Ingredients extraIngredients, ShoppingCart itemsInShoppingCart)
        {
            Console.WriteLine($"Enter the id of the extra ingredients on menu to add it to the shopping cart: ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers of items to add to the shopping cart: ");
            int quantity = int.Parse(Console.ReadLine());

            pizza articleToAdd = extraIngredients.GetFromMenuIngredients(productId);
            itemsInShoppingCart.AddToShoppingCart(articleToAdd, quantity);
            itemsInShoppingCart.PrintShoppingCart();
        }
    }
}
