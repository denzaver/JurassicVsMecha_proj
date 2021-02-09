using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Dinosaur
    {

        // Memebr Variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        // Constructor
        public Dinosaur(string type)
        {
            // Memeber Variables
            this.type = type;
            health = 20;
            energy = 20;
            attackPower = 5;

        }

        // Memeber Methods (CAN DO)
        public void DinoAttack(Robot robot)
        {
            robot.health -= attackPower;
            
            Console.WriteLine($"{type} has attacked {robot.health}. The {type} health is now " + robot.health);

        }



    }
}
