using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Robot
    {
        // Memeber Variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

        //Constructor
        public Robot(string name)
        {
            this.name = name;
            health = 20;
            powerLevel = 3;
            weapon = new Weapon();
        }

        // Mmeber Methods

    }
}
