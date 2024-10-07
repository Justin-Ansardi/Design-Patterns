using Design_Patterns.Creational.AbstractFactory.AbstractModels;
using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Models
{
    public class SUV : Auto , ISUV
    {
        public SUVSize? Size { get; set; }  

        // Adding this addtional property creates an issue with the (Builder) pattern.

        // Maybe this is where abstract factory comes in????
    }

}
