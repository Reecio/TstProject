using System.Security.Policy;
using System.Xml.Linq;
using TestApplication;

namespace UnitTests
{
    [TestClass]
    public class EasyTests
    {
        private const string characterName = "Scary Terry";
        private const string characterImage = "https://rickandmortyapi.com/api/character/avatar/306.jpeg";

        [TestMethod]
        public void TestName()
        {
            var character = ApiEngine.GetCharacter(characterName);

            Assert.AreEqual(characterName, character.name);
        }

        [TestMethod]
        public void TestImage()
        {
            var character = ApiEngine.GetCharacter(characterName);

            Assert.AreEqual(characterImage, character.image);
        }
    }

    [TestClass]
    public class NormalTests
    {
        private const string characterName = "Rick Sanchez";
        private const string characterImage = "https://rickandmortyapi.com/api/character/avatar/1.jpeg";

        [TestMethod]
        public void TestCount()
        {
            var characterList = ApiEngine.SearchCharacters(characterName);

            Assert.AreEqual(4, characterList.Count);
            Assert.IsTrue(characterList.Any(x => x.id == 1));
            Assert.IsTrue(characterList.Any(x => x.id == 290));
            Assert.IsTrue(characterList.Any(x => x.id == 293));
            Assert.IsTrue(characterList.Any(x => x.id == 631));
        }

        [TestMethod]
        public void TestName()
        {
            var character = ApiEngine.GetCharacter(characterName);

            Assert.AreEqual(characterName, character.name);
        }

        [TestMethod]
        public void TestImage()
        {
            var characterList = ApiEngine.SearchCharacters(characterName);

            foreach (var c in characterList)
            {
                Assert.IsTrue(c.image.StartsWith("https://"));
                Assert.IsTrue(c.image.EndsWith("jpeg"));
            }
        }
    }

    [TestClass]
    public class AdvancedTests
    {
        private const string characterName = "Rick";
        private const string characterImage = "https://rickandmortyapi.com/api/character/avatar/1.jpeg";

        [TestMethod]
        public void TestCount()
        {
            var characterList = ApiEngine.SearchCharacters(characterName);

            Assert.AreEqual(107, characterList.Count);
            Assert.IsTrue(characterList.Any(x => x.id == 1));
            Assert.IsTrue(characterList.Any(x => x.id == 278));
            Assert.IsTrue(characterList.Any(x => x.id == 353));
            Assert.IsTrue(characterList.Any(x => x.id == 483));
            Assert.IsTrue(characterList.Any(x => x.id == 701));
            Assert.IsTrue(characterList.Any(x => x.id == 810));
        }

        [TestMethod]
        public void TestStatus()
        {
            var characterList = ApiEngine.SearchCharacters(characterName);

            Assert.IsTrue(typeof(Character).GetProperties().Any(x => x.Name == "status"));
        }


        [TestMethod]
        public void TestSpecies()
        {
            var characterList = ApiEngine.SearchCharacters(characterName);

            Assert.IsTrue(typeof(Character).GetProperties().Any(x => x.Name == "species"));
        }


        [TestMethod]
        public void TestEpisode()
        {
            var characterList = ApiEngine.SearchCharacters(characterName);
            var firstChar = characterList.FirstOrDefault();
            var epList = (List<string>)typeof(Character).GetProperty("episode").GetValue(firstChar, null);

            Assert.IsTrue(typeof(Character).GetProperties().Any(x => x.Name == "episode"));
            Assert.IsTrue(firstChar != null);
            Assert.AreEqual(51, epList.Count);
        }


        [TestMethod]
        public void TestLocation()
        {
            var characterList = ApiEngine.SearchCharacters(characterName);
            var firstChar = characterList.FirstOrDefault();
            var loc = (List<string>)typeof(Character).GetProperty("location").GetValue(firstChar, null);

            Assert.IsTrue(typeof(Character).GetProperties().Any(x => x.Name == "location"));
            Assert.AreEqual(new { name = "Citadel of Ricks", url = "https://rickandmortyapi.com/api/location/3" }, loc);


        }

    }
}