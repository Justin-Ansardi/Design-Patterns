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
    public class RougeBuilder : IAutoBuilder,  ISUVBuilder
    {
        SUV suv = new(); // What happens with memory?
        public Auto GetAuto() => suv;

        public SUV GetSUV() => suv; // This extends this functionality to the abstract factory method!

        public void SetDrive() => suv.Drive = Drive.Rear;


        public void SetPackage() => suv.Package = "Luxury";


        public void SetWheelSize() => suv.WheelSize = 23;


        public void SetWeight() => suv.Weight = 4200;

        public void SetSize() => suv.Size = SUVSize.Crossover;


    }

}