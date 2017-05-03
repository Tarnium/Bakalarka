using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestGenerator;

namespace QuestGeneratorTest
{
    [TestClass]
    public class ObjectNpcLocationTesting
    {
        [TestMethod]
        public void TestLocation()
        {
            Assert.IsTrue("LocationName0" == ObjectNpcLocation.GenerateLocation());
            Assert.IsFalse("LocationName0" == ObjectNpcLocation.GenerateLocation());
            Assert.IsTrue("LocationName2" == ObjectNpcLocation.GenerateLocation());
        }

        [TestMethod]
        public void TestObject()
        {
            Assert.AreEqual("ObjectName0", ObjectNpcLocation.GenerateObject());
            Assert.AreNotEqual("ObjectName0", ObjectNpcLocation.GenerateObject());
            Assert.AreEqual("ObjectName2", ObjectNpcLocation.GenerateObject());
        }

        [TestMethod]
        public void TestPerson()
        {
            Assert.AreEqual("PersonName0", ObjectNpcLocation.GeneratePerson());
            Assert.AreNotEqual("PersonName0", ObjectNpcLocation.GeneratePerson());
            Assert.AreEqual("PersonName2", ObjectNpcLocation.GeneratePerson());
        }

        [TestMethod]
        public void TestRandom()
        {
            ObjectNpcLocation.GenerateObject();
            string random = ObjectNpcLocation.GenerateObjectNpcLocation();
            Assert.IsTrue(random == "PersonName3" || random == "LocationName3" || random == "ObjectName4");
        }
    }
}
