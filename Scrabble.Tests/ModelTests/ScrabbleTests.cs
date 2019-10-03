using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests {

    [TestClass]
    public class ScrabbleTest {

        [TestInitialize]
        public void Startup () {
            
        }

        [TestCleanup]
        public void TestClean () {
            
        }

        [TestMethod]
        public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue () {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Assert.AreEqual (EXPECTED RESULT, CODE TO TEST);
        }
    }
}