using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboVsDino
{
    class Herd
    {
        // Member Cariables
        public List<Dinosaur> dinosaurs;

        // Constructor
        public Herd()
        {
            Dinosaur dino1 = new Dinosaur("T-Rex");
            Dinosaur dino2 = new Dinosaur("Raptor");
            Dinosaur dino3 = new Dinosaur("Indominus rex");

            dinosaurs = new List<Dinosaur>();

            dinosaurs.Add(dino1);
            dinosaurs.Add(dino2);
            dinosaurs.Add(dino3);


        }

        // Member Methods

    }

}
