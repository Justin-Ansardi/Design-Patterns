using Design_Patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class AutoCreator
    {
        private IAutoBuilder _AutoBuilder;
        public AutoCreator(IAutoBuilder AutoBuilder)
        {
            _AutoBuilder = AutoBuilder;
        }
        public void CreateAuto()
        {
            _AutoBuilder.SetDrive();
            _AutoBuilder.SetPackage();
            _AutoBuilder.SetWeight();
            _AutoBuilder.SetWheelSize();
        }
        public Auto GetAuto() => _AutoBuilder.GetAuto();
        
    }
}
