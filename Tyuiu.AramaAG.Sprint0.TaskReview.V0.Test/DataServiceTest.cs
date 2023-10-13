﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.AramaAG.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            int z = 3;
            int res = ds.Calc(x, y, z);
            Assert.AreEqual(30, res);
        }
    }
}
