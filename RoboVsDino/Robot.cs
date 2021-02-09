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
        public void RobotAttack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
            Console.WriteLine($"{name} has attacked {dinosaur.type}. The {dinosaur.type} health is now " + dinosaur.health);

            //dinoArmy.dinosaurs[0].health -= robotArmy.robots[0].weapon.attackPower;
        }

    }
}
