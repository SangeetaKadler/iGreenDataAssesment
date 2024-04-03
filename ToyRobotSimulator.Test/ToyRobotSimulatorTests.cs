using NUnit.Framework;

namespace ToyRobotSimulator.Tests
{
    [TestFixture]
    public class ToyRobotSimulatorTests
    {
        [Test]
        public void ValidPlacementAndMovement()
        {
            var simulator = new CommandSimulator(5);
            Assert.Multiple(() =>
            {
                // Scenario 1: Valid placement and movement
                var commands1 = new[]
                {
                    "PLACE 0,0,NORTH",
                    "MOVE",
                    "REPORT"
                };
                var expectedOutput1 = "0,1,NORTH";
                Assert.That(simulator.ExecuteCommands(commands1), Is.EqualTo(expectedOutput1));

                // Scenario 2: Valid Placement and Turn Left
                var commands2 = new[]
                {
                    "PLACE 2,2,NORTH",
                    "LEFT",
                    "REPORT"
                };
                var expectedOutput2 = "2,2,WEST";
                Assert.That(simulator.ExecuteCommands(commands2), Is.EqualTo(expectedOutput2));

                var commands3 = new[]
                {
                    "PLACE 2,2,EAST",
                    "MOVE",
                    "REPORT"
                };
                var expectedOutput3 = "3,2,EAST";
                Assert.That(simulator.ExecuteCommands(commands3), Is.EqualTo(expectedOutput3));

                var commands4 = new[]
                {
                    "PLACE 2,2,SOUTH",
                    "MOVE",
                    "REPORT"
                };
                var expectedOutput4 = "2,1,SOUTH";
                Assert.That(simulator.ExecuteCommands(commands4), Is.EqualTo(expectedOutput4));

                var commands5 = new[]
                {
                    "PLACE 2,2,WEST",
                    "MOVE",
                    "REPORT"
                };
                var expectedOutput5 = "1,2,WEST";
                Assert.That(simulator.ExecuteCommands(commands5), Is.EqualTo(expectedOutput5));

                var commands6 = new[]
                {
                    "PLACE 5,5,NORTH",
                    "MOVE",
                    "REPORT"
                };
                var expectedOutput6 = "5,5,NORTH";
                Assert.That(simulator.ExecuteCommands(commands6), Is.EqualTo(expectedOutput6));

                var commands7 = new[]
                {
                    "PLACE 0,0,WEST",
                    "MOVE",
                    "REPORT"
                };
                var expectedOutput7 = "0,0,WEST";
                Assert.That(simulator.ExecuteCommands(commands7), Is.EqualTo(expectedOutput7));

                var commands8 = new[]
              {
                    "PLACE 3,4,EAST",
                    "RIGHT",
                    "REPORT"
                };
                var expectedOutput8 = "3,4,SOUTH";
                Assert.That(simulator.ExecuteCommands(commands8), Is.EqualTo(expectedOutput8));
            });
        }

        [Test]
        public void InvalidPlacement()
        {
            var simulator = new CommandSimulator(5);
            var commands = new[]
            {
                "PLACE 6,6,NORTH",
                "REPORT"
            };
            var expectedOutput = "Invalid PLACE command.";
            Assert.That(simulator.ExecuteCommands(commands), Is.EqualTo(expectedOutput));
        }
    }
}