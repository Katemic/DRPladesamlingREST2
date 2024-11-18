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
    public class RecordsRepositoryListTests
    {  
        private RecordsRepositoryList _recordsRepo;

        [TestInitialize()]
        public void SetUp()
        {
            _recordsRepo = new RecordsRepositoryList();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.AreEqual(0, _recordsRepo.GetAll().Count);
            Record record = new Record("Title", "Artist", 55, 2001);
            _recordsRepo.Add(record);
            Assert.AreEqual(1, _recordsRepo.GetAll().Count);
        }
    }
}