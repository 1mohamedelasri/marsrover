// This file was Created by Mohamed ELASRI 
// Generated on: 4/30/2020  at 11:55 PM  

using System;
using System.Collections.Generic;

namespace marsRoverCS
{
    // a Rover should to trun to all directions
    // a Rover should move forward
    // a rover should execute a serie of letters as commandes
    public interface IRover
    {
        void rotateRoverLeft();
        void rotateRoverRight();
        void stepRoverForward();
        void executeMovements(List<Command> commandes);
    }
}
