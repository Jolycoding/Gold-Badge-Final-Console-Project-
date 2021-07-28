using Menu_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Menu_Test
{
    [TestClass]
    public class MenuRepositoryTest
    {
        private MenuRepository _repo;
        private MenuItems _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _content = new MenuItems("Kids Meal", "1", "Turkey Sandwhich with Lays Potatoe Chips", "Wheat Bread, Turkey, American Cheese, Potatoes", 3.99);

            _repo.AddItemsToList(_content);
        }
        
        
        //Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange
            MenuItems items = new MenuItems();
            items.MealName = "Kids Meal";
            MenuRepository repository = new MenuRepository();

            //Act
            repository.AddItemsToList(items);
            MenuItems contentFromDirectory = repository.GetContentByMealName("Kids Meal");

            //Assert
            Assert.IsNotNull(contentFromDirectory);


        }

        [TestMethod]
        
        public void DeleteContent_ShouldReturnTrue()
        {
            //Arrange
            
            //Act
            bool deleteResult = _repo.RemoveContentfromItems(_content.MealName);
            
            //Assert
        }
    }
}
