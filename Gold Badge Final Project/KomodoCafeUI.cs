using Menu_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Final_Project
{
    class KomodoCafeUI
    {

        private MenuRepository _itemsRepo = new MenuRepository();
        public void Run()
        {
            SeedItemsList();
            StartupMenu();
        }

        private void StartupMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                Console.WriteLine("Select A Menu Option:\n" +
                    "1. Create New Menu Item\n" +
                    "2. View All Items on the Cafe's Menu\n" +
                    "3. View the Description of Each Menu Item By Meal Name\n" +
                    "4. Delete an Existing Meal\n" +
                    "5. Exit");

                string input = Console.ReadLine();

                switch (input)
                {//Create
                    case "1":
                        CreateNewItems();
                        break;
                    //Read
                    case "2":
                        DisplayAllItems();
                        break;
                    //Read specific
                    case "3":
                        DisplayContentByMealName();
                        break;
                    //Delete
                    case "4":
                        DeleteExistingItems();
                        break;
                    case "5":
                        Console.WriteLine("Make it a GREAT day with Komodo Cafe!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create
        private void CreateNewItems()
        {
            Console.Clear();
            MenuItems newItems = new MenuItems();

            //MealName
            Console.WriteLine("Enter the Meal Name:");
            newItems.MealName = Console.ReadLine();


            //MealNumber
            Console.WriteLine("Enter the Meal Number:");
            newItems.MealNumber = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the Description of the Meal:");
            newItems.Description = Console.ReadLine();

            //Ingridients
            Console.WriteLine("Enter the Ingridients of the Meal:");
            newItems.Description = Console.ReadLine();

            //Price
            Console.WriteLine("Enter the Price of the Meal:");
            string PriceAsString = Console.ReadLine();
            newItems.Price = double.Parse(PriceAsString);

            _itemsRepo.AddItemsToList(newItems);

        }
        //Read
        private void DisplayAllItems()
        {
            Console.Clear();
            List<MenuItems> listofMenuItems = _itemsRepo.GetListofItemMenus();

            foreach(MenuItems items in listofMenuItems)
            {
                Console.WriteLine($"Meal Name: {items.MealName}\n" +
                    $"Meal Number: {items.MealNumber}\n");
            }
        }
        //Read specific
        private void DisplayContentByMealName()
        {
            Console.Clear();
            Console.WriteLine("Please enter the Meal Name you would like to see.");
            string mealName = Console.ReadLine();
            MenuItems items = _itemsRepo.GetContentByMealName(mealName);

            if (items != null)
            {
                Console.WriteLine($"Meal Name: {items.MealName}\n" +
                    $"Meal Number: {items.MealNumber}\n" +
                    $"Description: {items.Description}\n" +
                    $"Ingridients: {items.Ingridients}\n" +
                    $"Meal Price: {items.Price}");

            }

            else
            {
                Console.WriteLine("Nothing found by that Meal Name");
            }
        }
        //Delete
        private void DeleteExistingItems()
        {
            
            DisplayAllItems();
            Console.WriteLine("\nEnter the meal name you would like to delete.");

            string input = Console.ReadLine();
            bool wasDeleted =_itemsRepo.RemoveContentfromItems(input);
            if (wasDeleted)
            {
                Console.WriteLine("Meal has been succesflly deleted.");
            }
            else
            {
                Console.WriteLine("Meal could not be deleted.");
            }
        }

        private void SeedItemsList()
        {
            MenuItems kidsMeal = new MenuItems("Kids Meal", "1", "Turkey Sandwhich with Lays Potatoe Chips", "Wheat Bread, Turkey, American Cheese, Potatoes", 3.99);
            MenuItems personalPizzaMeal = new MenuItems("Pizza Meal", "2", "Pizza with Pepperoni and Sausage", "Pizza dough, Marinara Sauce, Mozarella Cheese, Pepperoni, Sausage", 4.99);
            MenuItems chickenCaesarSaladMeal = new MenuItems("Chicken Caesar Salad Meal", "3", "Salad with Chicken, Parmesean Cheese, and Caesar Dressing ", "Lettuce,Parmesean Cheese,Caesar Dressing", 4.25);
            MenuItems cheeseburgerMeal = new MenuItems("Cheeseburger Meal", "4", "Cheeseburger with Fries", "Brioche Bun, ground beef, American Cheese, Lettuce, Onion, Ketchup, Mustard, Potatoes", 5.99);
            MenuItems chickenTendersMeal = new MenuItems("Chicken Tenders Meal", "5", "Chicken Tenders with Fries", "Chicken, Potatoes", 5.99);

            _itemsRepo.AddItemsToList(kidsMeal);
            _itemsRepo.AddItemsToList(personalPizzaMeal);
            _itemsRepo.AddItemsToList(chickenCaesarSaladMeal);
            _itemsRepo.AddItemsToList(cheeseburgerMeal);
            _itemsRepo.AddItemsToList(chickenTendersMeal);
        }
    }
}
