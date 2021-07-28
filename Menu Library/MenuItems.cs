using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Library
{
    public class MenuItems

        //POCO
    {
        public string MealName { get; set; }
        public string MealNumber { get; set; }
        public string Description { get; set; }
        public string Ingridients { get; set; }
        public double Price { get; set; }

        public MenuItems() { }

        public MenuItems(string mealNumber, string mealName, string description, string ingridients, double price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingridients = ingridients;
            Price = price;



        }
    }
}

