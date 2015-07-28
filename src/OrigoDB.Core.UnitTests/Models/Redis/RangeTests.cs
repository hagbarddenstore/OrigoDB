﻿using NUnit.Framework;
using OrigoDB.Core.Types.Redis;

namespace Models.Redis.Tests
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        public void Flip()
        {
            var target = new Range(2, 6, 8).Flip(8);
            Assert.AreEqual(1, target.FirstIdx);
            Assert.AreEqual(5, target.LastIdx);
        }
    }
}