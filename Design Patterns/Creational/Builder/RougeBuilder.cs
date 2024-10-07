using Design_Patterns.Models;
using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class RougeBuilder : IAutoBuilder
    {
        SUV rouge = new(); // What happens with memory?
        public Auto GetAuto() => rouge;

        public void SetDrive() => rouge.Drive = Drive.Rear;


        public void SetPackage() => rouge.Package = "Luxury";


        public void SetWheelSize() => rouge.WheelSize = 23;


        public void SetWeight() => rouge.Weight = 4200; // Should find a way to incorperate units

        public void SetSize() => rouge.Size = SUVSize.Crossover;

    }
}