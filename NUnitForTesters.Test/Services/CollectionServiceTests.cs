using NUnit.Framework;
using NUnitForTesters.Services;
using System.Collections.Generic;

namespace NUnitForTesters.Test.Services
{
    public class CollectionServiceTests
    {
        [Test]
        public void ShouldCreateNewInstanceCollectionService()
        {
            var collectionService = new CollectionService();

            CollectionAssert.AllItemsAreNotNull(collectionService.Names);
            CollectionAssert.IsNotEmpty(collectionService.Names);
            CollectionAssert.AllItemsAreUnique(collectionService.Names); 
        }

        //[TestCase("Piotr Witaszewski")]
        //[TestCase("Piotr Witaszewski", "Anna Dobroszek")]
        [TestCase("Piotr Witaszewski", "Anna Dobroszek", "Daniel Kowalewski")]
        public void ShouldCreateNewInstanceCollectionService(params string[] names)
        {
            var list = new List<string>(names);
            var collectionService = new CollectionService(list);
            var resultList = collectionService.GetInitialsFromNames();

            var myList = new List<string>() { "PW", "AD", "DK" };

            Assert.Multiple(() =>
            {
                CollectionAssert.AreEquivalent(myList, resultList);
                //myList.Add("EE");
                Assert.AreEqual(myList.Count, resultList.Count);
            });
        }
    }
}
