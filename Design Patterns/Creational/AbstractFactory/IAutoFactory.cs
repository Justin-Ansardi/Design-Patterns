using Design_Patterns.Models;
using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory
{
    public abstract class AutoFactory
    {
        public Sedan CreateSedan(CarModel carModel) => new Sedan();

        public SUV CreateSUV(CarModel carModel) => new SUV();
    }
}
