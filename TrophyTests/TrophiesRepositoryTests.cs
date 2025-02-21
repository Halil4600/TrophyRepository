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
    public class TrophiesRepositoryTests
    {
        [TestMethod()]
        public void TrophiesRepositoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            TrophiesRepository trophiesRepository = new TrophiesRepository();
            Trophy trophy = new Trophy(6, "Europa Championship", 2022);
            trophiesRepository.Add(trophy);
            Assert.AreEqual(6, trophiesRepository.Get().Count);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}

