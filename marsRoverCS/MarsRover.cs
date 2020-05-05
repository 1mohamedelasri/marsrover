// This file was Created by Mohamed ELASRI
// Generated on: 4/30/2020  at 12:17 PM   
using System;
using System.Collections.Generic;
using System.Linq;

namespace marsRoverCS
{
    // a MarsRover should derive the commun functionalities of a Rover

    public class MarsRover: IRover
    {
        public RoverPosition marsRoverPosition { get; set;}

        public MarsRover()
        {
            this.marsRoverPosition = new RoverPosition();
        }

        public MarsRover(RoverPosition marsRoverPosition)
        {
            this.marsRoverPosition = marsRoverPosition;
        }


        public void executeMovements(List<Command> commandes)
        {
            foreach(Command command in commandes)
            {
                switch (command)
                {
                    case Command.L:
                        this.rotateRoverLeft();
                        break;
                    case Command.R:
                        this.rotateRoverRight();
                        break;
                    case Command.M:
                        this.stepRoverForward();
                        break;
                    default:
                        Console.WriteLine($" command : {command} is not defined");
                        break;
                }
            }

        }


        //      N
        //  W       E
        //      S

        
        public void rotateRoverLeft()
        {
            switch(this.marsRoverPosition.roverDirection)
            {
                case RoverDirection.N:
                    this.marsRoverPosition.roverDirection = RoverDirection.W;
                    break;
                case RoverDirection.E:
                    this.marsRoverPosition.roverDirection = RoverDirection.N;
                    break;
                case RoverDirection.S:
                    this.marsRoverPosition.roverDirection = RoverDirection.E;
                    break;
                case RoverDirection.W:
                    this.marsRoverPosition.roverDirection = RoverDirection.S;
                    break;
                default:
                    break;

            }
        }

        public void rotateRoverRight()
        {
            switch (this.marsRoverPosition.roverDirection)
            {
                case RoverDirection.N:
                    this.marsRoverPosition.roverDirection = RoverDirection.E;
                    break;
                case RoverDirection.E:
                    this.marsRoverPosition.roverDirection = RoverDirection.S;
                    break;
                case RoverDirection.S:
                    this.marsRoverPosition.roverDirection = RoverDirection.W;
                    break;
                case RoverDirection.W:
                    this.marsRoverPosition.roverDirection = RoverDirection.N;
                    break;
                default:
                    break;

            }
        }

        //     N
        //  W     E
        //     S

        public void stepRoverForward()
        {
            switch (this.marsRoverPosition.roverDirection)
            {
                case RoverDirection.N:
                    this.marsRoverPosition.y++;
                    break;
                case RoverDirection.E:
                    this.marsRoverPosition.x++;
                    break;
                case RoverDirection.S:
                    this.marsRoverPosition.y--;
                    break;
                case RoverDirection.W:
                    this.marsRoverPosition.x--;
                    break;
                default:
                    break;

            }
        }

        public List<Command> stringCommandToRoverDirections(string commandsString)
        {
            List<Command> commands = new List<Command>();


            foreach (char command in commandsString.ToCharArray())
            {
                Enum.TryParse(command.ToString(), out Command dir);
                commands.Add(dir);
            }

            return commands;
        }


    }
}
