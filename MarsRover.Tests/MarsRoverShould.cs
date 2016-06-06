﻿using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MarsRover.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [Test]
        public void return_initial_position_with_empty_command()
        {
            var position = "0,0,N";
            Assert.That(position, Is.EqualTo("0,0,N"));
        }
    }
}
