using NUnit.Framework;
using NUnit.Framework.Internal;

namespace MarsRover.Tests
{
    [TestFixture]
    public class MarsRoverShould
    {
        [TestCase("","0,0,N")]
        [TestCase("M","0,1,N")]
        [TestCase("R","0,0,E")]
        [TestCase("L","0,0,O")]
        public void execute_command_return_position(string command, string expected)
        {
            var rover   =   new MarsRover();
            var position = rover.Move(command);
            Assert.That(position, Is.EqualTo(expected));
        }
    }
}
