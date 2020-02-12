using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Core;

namespace UnitTests
{
    [TestClass]
    public class AppCoreTests
    {
        [TestMethod]
        public void TestMethod()
        {
            string personName = "Mouez";
            int personAge = 27;
            var person = new Person(personName, personAge);

            Assert.AreEqual(personName, person.Name);
            Assert.AreEqual(personAge, person.Age);
        }
    }
}