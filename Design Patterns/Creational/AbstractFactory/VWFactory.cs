using Design_Patterns.Creational.AbstractFactory.AbstractModels;
using Design_Patterns.Models;
using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory
{
    public class VWFactory : IAutoFactory
    {
        public Sedan CreateSedan(CarModel carModel) => throw new NotImplementedException();
        public ISUV CreateSUV(CarModel carModel) => throw new NotImplementedException();
    }
}
