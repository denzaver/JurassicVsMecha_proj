using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Fleet
    {

        // Memeber Variables
        public List<Robot> robots;

        //Constructor
        public Fleet()
        {
            Robot robot1 = new Robot("Optimus Prime");
            Robot robot2 = new Robot("Gundam");
            Robot robot3 = new Robot("Number Six");

            robots = new List<Robot>();

            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);

        }

        // Memeber Methods
    }
}
