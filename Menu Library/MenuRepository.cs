using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Library
{
    public class MenuRepository
    {
        public List<MenuItems> _listofItems = new List<MenuItems>();

        //Create and add new menu items
        public void AddItemsToList(MenuItems items)
        {
            _listofItems.Add(items);
          
        }
        //Read items on the cafe's menu
        public List<MenuItems> GetListofItemMenus()
        {
            return _listofItems;
        }
        //Update (not needed)
        
        //Delete Menu Items 
        public bool RemoveContentfromItems(string mealName)
        {
            MenuItems content = GetContentByMealName(mealName);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listofItems.Count;
            _listofItems.Remove(content);

            if (initialCount > _listofItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Helper Method
        public MenuItems GetContentByMealName(string mealName)
        {
            foreach (MenuItems content in _listofItems)
            {
                if (content.MealName == mealName)
                {
                    return content;
                }
            }

            return null;
        }
       
    }
}
