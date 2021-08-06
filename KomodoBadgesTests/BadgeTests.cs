using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoBadgesTests
{
    [TestClass]
    public class BadgeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            private KomodoBadgesRepository _repo;
        private BadgeClassProperties _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new KomodoBadgesRepository();
            _content = new BadgeClassProperties(1, ClaimType.Car, "Car accident on 465.", 400.00, 4 / 25 / 18, 4 / 27 / 18, true);

            _repo.AddContentToList(_content);
        }


        //Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange
            BadgeClassProperties items = new BadgeClassProperties();
            items.BadgeID = 1;
            KomodoBadgesRepository repository = new KomodoBadgesRepository();

            //Act
            repository.AddContentToList(items);
            BadgeClassProperties contentFromDirectory = repository.GetContentByBadgeID(1);

            //Assert
            Assert.IsNotNull(contentFromDirectory);


        }

        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            ClaimProperties newContent = new ClaimProperties(1.2, ClaimType.Home, "Car accident on 465.", 400.00, 4 / 25 / 18, 4 / 27 / 18, true);

            //Act 
            bool updateResult = _repo.UpdateExistingContent(1, newcontent);

            //Assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow(1, true)]
        [DataRow(2, false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalClaimID, bool shouldUpdate)
        {
            ClaimProperties newContent = new ClaimProperties(1.2, ClaimType.Home, "Car accident on 465.", 400.00, 4 / 25 / 18, 4 / 27 / 18, true);

            //Act 
            bool updateResult = _repo.UpdateExistingContent(originalClaimID, newcontent);

            //Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]

        public void DeleteContent_ShouldReturnTrue()
        {
            //Arrange

            //Act
            bool deleteResult = _repo.RemoveContentfromItems(_content.ClaimID);

            //Assert
        }
    }
    }
}
