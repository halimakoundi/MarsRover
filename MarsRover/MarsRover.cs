
/*
 * Mars Rover Kata
 
Develop an API that moves a rover around on a grid.
 
Rules:
 
* You are given the initial starting point (0,0,N) of a rover.
* 0,0 are X,Y co-ordinates on a grid of (10,10).
* N is the direction it is facing (i.e. N,S,E,W).
* L and R allow the rover to rotate left and right.
* M allows the rover to move one point in the current direction.
* The rover receives a char array of commands e.g. RMMLM and returns the finishing
point after the moves e.g. 2,1,N
* The rover wraps around if it reaches the end of the grid.
* The grid may have obstacles. If a given sequence of commands encounters an
obstacle, the rover moves up to the last possible point and reports
the obstacle e.g. O,2,2,N
 */

using System.Linq;

namespace MarsRover
{
    public class MarsRover
    {
        private string _position = "0,0,N";

        public string Move(string command)
        {
            var positions = _position.Split(',');
            if (command.Contains("M"))
            {
                foreach (var cmd  in positions)
                {
                    
                }
                positions[1] = "1";
                _position = string.Join(",", positions);
            }

            if (command == "MM")
            {
                positions[1] = "2";
                _position = string.Join(",", positions);
            }

            if (command == "L")
            {
                positions[2] = "W";
                _position = "0,0,W";
            }
            if (command == "R")
            {
                _position = "0,0,E";
            }
            return _position;
        }
    }
}
