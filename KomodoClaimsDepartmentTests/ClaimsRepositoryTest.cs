using KomodoClaimsDepartmentUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoClaimsDepartmentTests
{
    [TestClass]
    public class KomodoClaimsDepartmentRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            private KomodoClaimsDepartmentRepository _repo;
        private ClaimProperties _content;
   
        [TestInitialize]
        public void Arrange()
        {
            _repo = new KomodoClaimsDepartmentRepository();
            _content = new ClaimProperties(1, ClaimType.Car, "Car accident on 465.", 400.00, 4/25/18, 4/27/18, true);

            _repo.AddContentToList(_content);
        }


        //Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange
            ClaimProperties items = new ClaimProperties();
            items.ClaimID = 1;
            KomodoClaimsDepartmentRepository repository = new KomodoClaimsDepartmentRepository();

            //Act
            repository.AddContentToList(items);
            ClaimProperties contentFromDirectory = repository.GetContentByClaimID(1);

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

