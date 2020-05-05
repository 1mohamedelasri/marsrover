using System;
using Xunit;
using marsRoverCS;
using System.Collections.Generic;

namespace MarsRoverTest
{
    public class UnitTest1
    {
        [Fact]
        public void testWithFirstInputModel()
        {
            MarsRover marsRover = new MarsRover(new RoverPosition(1,
                                        2,
                                        5,
                                        5, RoverDirection.N));

            List<Command> diiir = marsRover.stringCommandToRoverDirections("LMLMLMLMM");

            marsRover.executeMovements(diiir);


            Assert.Equal("1 3 N", marsRover.marsRoverPosition.getPositionStr());

        }

        [Fact]
        public void testWithSecondInputModel()
        {
            MarsRover marsRover = new MarsRover(new RoverPosition(3,
                                        3,
                                        5,
                                        5, RoverDirection.E));

            List<Command> diiir = marsRover.stringCommandToRoverDirections("MMRMMRMRRM");

            marsRover.executeMovements(diiir);


            Assert.Equal("5 1 E", marsRover.marsRoverPosition.getPositionStr());

        }
    }
}
