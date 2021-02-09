using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Battlefield
    {
        // Member Variables
        public Fleet robotArmy;
        public Herd dinoArmy;

        //Constructor
        public Battlefield()
        {
            robotArmy = new Fleet();
            dinoArmy = new Herd();
        }

        //Member Methods
        public void RunBattle()
        {
            //robotArmy.robots[0].health -= dinoArmy.dinosaurs[0].attackPower;
            int attackindex = 0;
            robotArmy.robots[attackindex].RobotAttack(dinoArmy.dinosaurs[0]);
            robotArmy.robots[1].RobotAttack(dinoArmy.dinosaurs[1]);
            //for loop to iterate through indexes?
            //user input?

            // I want the dino/robot to be chosen automatically as we move through the list starting at index 0

            // I want the user to be able to choose between

        }

    }
}
