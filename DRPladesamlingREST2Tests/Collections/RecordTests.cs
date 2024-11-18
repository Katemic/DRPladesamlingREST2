using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRPladesamlingREST2.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRPladesamlingREST2.Collections.Tests
{
    [TestClass()]
    public class RecordTests
    {

        //public void ValidateArtistTest()
        //{
        //    Assert.Fail();
        //}



        [TestMethod()]
        public void ValidateTest()
        {
            Record recordGood = new Record("title", "art", 10, 2021);
            recordGood.Validate();

            Record recordBadNull = new Record("title", null, 10, 2021);
            Assert.ThrowsException<ArgumentNullException>(() => recordBadNull.Validate());
            Record recordBadShort = new Record("title", "aa", 10, 2021);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => recordBadShort.Validate());
        }
    }
}