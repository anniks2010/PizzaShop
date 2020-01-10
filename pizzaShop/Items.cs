using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    class Items
    {
        pizza pizza;
        int quantity;

        public Items(pizza _pizza, int _quantity)
        {
            pizza = _pizza;
            quantity = _quantity;
        }
        public pizza Pizza
        {
            get { return pizza; }
        }
        

        public void PrintItem()
        {
            Console.WriteLine($"ID: {pizza.Id}\n Name: {pizza.Name} \n Category: {pizza.Category} \n Price: {pizza.Price} \n Quantity: {quantity} \n Total: {CalculateItemTotal()}");
        }

        public double CalculateItemTotal()
        {
            return pizza.Price * quantity;
        }
    }
}
