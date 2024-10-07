using Design_Patterns.Models;
using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class JettaBuilder : IAutoBuilder
    {
        Sedan jetta = new(); // What happens with memory?
        public Auto GetAuto() => jetta;

        public void SetDrive() => jetta.Drive = Drive.Front;


        public void SetPackage() => jetta.Package = "Sports";


        public void SetWheelSize() => jetta.WheelSize = 21;


        public void SetWeight() => jetta.Weight = 2200; // Should find a way to incorperate units
      
    }
}
