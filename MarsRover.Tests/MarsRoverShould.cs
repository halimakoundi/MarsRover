using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MarsRover.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [TestCase("","0,0,N")]
        public void return_initial_position_with_empty_command(string command, string expected)
        {
            var rover   =   new MarsRover();
            var position = rover.Move(command);
            Assert.That(position, Is.EqualTo(expected));
        }
    }
}
