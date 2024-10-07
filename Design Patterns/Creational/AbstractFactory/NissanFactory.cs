using Design_Patterns.Creational.Builder;
using Design_Patterns.Models;
using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory
{
    public class NissanFactory : AutoFactory
    {
        public Sedan CreateSedan(CarModel carModel) => throw new NotImplementedException();
        public SUV CreateSUV(CarModel carModel)
        {
            if (carModel == CarModel.Rouge)
            {
                var director = new SUVCreator(new RougeBuilder());
                director.CreateAuto();
                return director.GetSUV();

            }
            else
            {
                throw new Exception(message: "ooooooooohhhhhhhhh noooo!!!!!");
            }
        }

    }
}



