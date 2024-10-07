using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Models
{
     public abstract class Auto
    {
        public int? WheelSize { get; set; }
        public int? Weight { get; set; }
        public string? Package { get; set; }
        public Drive? Drive { get; set; }
        public Manufactorer? Manufactorer { get; set; }
        public CarModel? CarModel { get; set; }

    }



  
}
