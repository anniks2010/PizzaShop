using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaShop
{
    enum Category
    {
        PIZZA_TYPE,
        DOUGH,
        INGREDIENTS
    }
    class pizza
    {
        int id;
        string name;
        Category category;
        double price;

        public pizza(int _id, string _name, Category _category, double _price)
        {
            id = _id;
            name = _name;
            category = _category;
            price = _price;
        }
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Category
        {
            get { return category.ToString(); }
        }
        public double Price
        {
            get { return price; }
        }
    }
}
