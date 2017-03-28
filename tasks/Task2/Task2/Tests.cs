using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;



namespace Task2

{
    [TestFixture]
    class Tests
    {
        [Test]
        public void SimpleTest()
        {
            Assert.IsTrue(1 == 1);
        }


        [Test]
        public void CanCreateGame()
        {
            var x = new Boardgame("Testgame", "Test", 1.1m, 1);

            Assert.IsTrue(x.Name == "Testgame");
            Assert.IsTrue(x.Genre == "Test");
            Assert.IsTrue(x.getPrice == 1.1m);
            Assert.IsTrue(x.Player == 1);
        }

        [Test]
        public void CanotCreateGame()
        {
            var x = new Boardgame("Testgame", "Test", 1.1m, 1);

            Assert.IsTrue(x.Name == "Should be wrong");
            Assert.IsTrue(x.Genre == "Test");
            Assert.IsTrue(x.getPrice == 1.01m);
            Assert.IsTrue(x.Player == 12);
        }


        [Test]
        public void CanUpdateGamePrice()
        {
            var x = new Boardgame("Testgame", "Test", 1.1m, 1); 
            //x.UpdatePrice(39.90m);
            //Because of private
            

            Assert.IsTrue(x.getPrice == 39.90m);
        }


        [Test]
        public void CannotCreateEmptyName()
        {
            Assert.Catch(() =>
            {
                var x = new Boardgame("Testgame", "", 1.1m, 1);
                //lets see ^^
            });
        }


        [Test]
        public void CannotCreateNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new Boardgame("Testgame", "Test", -1.1m, 1);
            });
        }



        [Test]
        public void CannotCreateToHighPrice()
        {
            Assert.Catch(() =>
            {
                var x = new Boardgame("Testgame", "Test", 99999999m, 1);
            });
        }


        [Test]
        public void CannotCreateNoPrice()
        {
            Assert.Catch(() =>
            {
                var x = new Boardgame("Testgame", "Test", 0, 1);
            });
        }


    }
}
