using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trophy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trophy.Tests
{
    [TestClass()]
    public class TrophyTests
    {
        [TestMethod()]
        public void CompetitionNameLenght()
        {
            Trophy a = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => a.Competition = "Da");

            Trophy b = new Trophy();
            Assert.AreEqual("Champions League", b.Competition = "Champions League");

            Trophy c = new Trophy();
            Assert.ThrowsException<ArgumentNullException>(() => c.Competition = null);
        }

        [TestMethod()]
        public void CompetitionYear()
        {
            Trophy a = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => a.Year = 1969);

            Trophy b = new Trophy();
            Assert.AreEqual(2000, b.Year = 2000);

            Trophy c = new Trophy();
            Assert.ThrowsException<ArgumentException>(() => c.Year = 2026);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Trophy b = new Trophy { id = 1, Competition = "Champions League", Year = 2022};
            string expected = "Id: 1, Competition: Champions League, Year: 2022";
            Assert.AreEqual(expected, b.ToString());
        }
    }
}