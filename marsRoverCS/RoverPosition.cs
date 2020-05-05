// This file was Created by Mohamed ELASRI
// Generated on: 4/30/2020  at 12:27 PM
using System;


namespace marsRoverCS
{
    public class RoverPosition
    {
        int xVal, yVal;
        public int x { get { return xVal; } set { this.xVal = x <= this.xMax && x >= 0 ? value : this.xVal; } }
        public int y { get { return yVal; } set { this.yVal = y <= this.xMax && y >= 0 ? value : this.yVal; } }
        public RoverDirection roverDirection { get; set;}
        private int xMax;
        private int yMax;


        public RoverPosition()
        {
            this.xMax = 5;
            this.yMax = 5;
            this.xVal =0;
            this.yVal= 0;
            this.roverDirection = RoverDirection.N;
        }

        public RoverPosition(int x, int y, int xMax, int yMax, RoverDirection roverDirection)
        {
            this.x = x;
            this.y = y;
            this.xMax = xMax;
            this.yMax = yMax;
            this.roverDirection = roverDirection;
        }

        public void setPositionTo(int x, int y, RoverDirection roverDirection)
        {
            this.x    = x;
            this.y    = y;
            this.roverDirection = roverDirection;

        }

        public string getPositionStr()
        {

            return $"{this.x} {this.y} {this.roverDirection}";
        }

    }
}
