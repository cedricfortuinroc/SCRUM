using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoundSharpLib.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoundSharpLib.Course.Tests
{
    [TestClass()]
    public class TimeTests
    {
        [TestMethod()]
        public void TimeTest1()
        {
            Time t = new Time(140);
            Assert.AreEqual("0:2:20", t.ToString());
        }

        [TestMethod()]
        public void TimeTest2()
        {
            Time t = new Time(5, 20);
            Assert.AreEqual("0:5:20", t.ToString());
        }

        [TestMethod()]
        public void TimeTest3()
        {
            Time t = new Time(5, 61);
            Assert.AreEqual("0:6:1", t.ToString());
        }
    }
}