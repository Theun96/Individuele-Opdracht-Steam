using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Steam_Powered.Models;

namespace Steam_Powered.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuyGame()
        {
            Administratie admin = new Administratie();
            
            Assert.AreEqual(admin.BuyGame("Rainbow"), 1);
        }

        [TestMethod]
        public void AddGame()
        {
            Administratie admin = new Administratie();

            Game g = new Game("game2", "", 1, new DateTime(2016, 1, 8), "", 59.95);

            Assert.AreEqual(admin.AddContent(g), 1);
        }

        [TestMethod]
        public void RemoveGame()
        {
            Administratie admin = new Administratie();

            Game g = new Game("game2", "", 1, new DateTime(2016, 1, 8), "", 59.95);
            admin.AddContent(g);

            Assert.AreEqual(admin.RemoveContent(g), 1);
        }

        [TestMethod]
        public void AddToWishlist()
        {
            Administratie admin = new Administratie();

            Game g = new Game("game2", "", 1, new DateTime(2016, 1, 8), "", 59.95);
            admin.AddContent(g);

            User currentUser = admin.GetUserData();

            Assert.AreEqual(currentUser.PersonalLibary.AddGameWishList(g), 1);
        }

        [TestMethod]
        public void RemoveContentLibrary()
        {
            Administratie admin = new Administratie();

            Game g = new Game("game2", "", 1, new DateTime(2016, 1, 8), "", 59.95);
            admin.AddContent(g);

            User currentUser = admin.GetUserData();

            currentUser.PersonalLibary.AddGame(g);

            Assert.AreEqual(currentUser.PersonalLibary.RemoveGame(g), 1);
        }

        [TestMethod]
        public void AddGroepen()
        {
            Administratie admin = new Administratie();

            Game game = admin.Games[0];

            Assert.AreEqual(game.AddGroep("groep1"), 1);
            Assert.AreEqual(game.AddGroep("groep2"), 1);
            Assert.AreEqual(game.AddGroep("groep1"), 0);
        }

        [TestMethod]
        public void RegisterUser()
        {
            Administratie admin = new Administratie();

            Assert.AreEqual(admin.Register("theun", "theun", "password", "adres"), 0);
            Assert.AreEqual(admin.Register("schut", "schut", "wachtwoord", "adres"), 1);
        }

        [TestMethod]
        public void ChangeUserData()
        {
            Administratie admin = new Administratie();

            const string nickName = "theuntjee";
            const string status = "werken";

            Assert.AreEqual(admin.ChangeUserData(nickName, status), 1);
        }
    }
}
