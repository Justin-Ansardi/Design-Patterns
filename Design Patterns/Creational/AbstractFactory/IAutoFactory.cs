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
    public interface IAutoFactory
    {
        //public CreateSedan(CarModel carModel);

        public ISUV CreateSUV(CarModel carModel);
    }
}
