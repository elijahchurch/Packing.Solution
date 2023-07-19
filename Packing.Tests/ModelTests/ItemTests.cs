using Microsoft.VisualStudio.TestTools.UnitTesting;
using Packing.Models;
using System.Collections.Generic;
using System;

namespace Packing.Tests
{
    [TestClass]
    public class ItemTests
    {
        // Test methods go here
        [TestMethod]
        public void ItemConstructor_CreatesConstructor_Item()
        {
            //Arrange
            Item newItem = new Item("name", "description", "status");

            //Act

            //Assert
            Assert.AreEqual(typeof(Item), newItem.GetType());

        }
    }
}