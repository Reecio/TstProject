using TestApplication;

namespace UnitTests
{
    [TestClass]
    public class TestApiEngine
    {
        private const string characterName = "Rick Sanchez";
        private const string characterImage = "https://rickandmortyapi.com/api/character/avatar/1.jpeg";

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
}