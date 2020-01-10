using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class ShoppingCart
    {
        List<Items> shoppingCart;
        double total;

        public ShoppingCart()
        {
            shoppingCart = new List<Items>();
            total = 0;
        }

        public void AddToShoppingCart(pizza pizza, int quantity)
        {
            Items newproduct = new Items(pizza, quantity);
            shoppingCart.Add(newproduct);
        }
        public void PrintShoppingCart()
        {
            if (shoppingCart.Count == 0)
            {
                Console.WriteLine($"shopping cart is empty");
            }
            else
            {
                foreach (Items item in shoppingCart)
                {
                    item.PrintItem();
                    
                }
            }
        }
        public void PrintTotal()
        {
            foreach (Items item in shoppingCart)
            {
                total += item.CalculateItemTotal();
            }
        }
    }
}
