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
        string ingredients;
        string dough;

        public pizza(int _id, string _name, string _ingredients, string _dough, Category _category, double _price)
        {
            id = _id;
            name = _name;
            category = _category;
            price = _price;
            ingredients = _ingredients;
            dough = _dough;
            
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
        public string Ingredients
        {
            get { return ingredients; }
        }
        public string Dough
        {
            get { return dough; }
        }
    }
}
