using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests {

    [TestClass]
    public class ScrabbleTest {

        Game game;

        [TestInitialize]
        public void Startup () {
            game = new Game ();

        }

        [TestCleanup]
        public void TestClean () {
            game = null;
        }

        [TestMethod]
        public void CheckInput_CheckForNonAlphabeticInputs_True () {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Assert.AreEqual (true, game.CheckInput ("a"));
        }

        [TestMethod]
        public void CheckInput_CheckForNonAlphabeticInputs_False () {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Assert.AreEqual (false, game.CheckInput ("2"));
        }

        [TestMethod]
        public void CheckMultipleWords_CheckForMultipleWords_FirstWordString () {
            Assert.AreEqual ("my", game.CheckMultipleWords ("my cat"));
        }

        [TestMethod]
        public void CheckMultipleWords_CheckForMultipleWords_String () {
            Assert.AreEqual ("my", game.CheckMultipleWords ("my"));
        }

        [TestMethod]
        public void LetterScore_GiveLetterScore_IntValue1()
        {
            Assert.AreEqual(1, game.LetterScore('a'));
        }
    }
}