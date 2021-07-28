using Menu_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Menu_Test
{
    [TestClass]
    public class MenuItemsTest
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            MenuItems content = new MenuItems();

            content.MealName = "Kids Meal";

            string expected = "Kids Meal";
            string actual = content.MealName;

            Assert.AreEqual(expected, actual);
        }
    }
}
