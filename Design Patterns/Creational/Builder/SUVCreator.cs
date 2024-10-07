using Design_Patterns.Models;
using Design_Patterns.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public class SUVCreator
    {
        private ISUVBuilder _SUVBuilder;
        public SUVCreator(ISUVBuilder suvBuilder)
        {
            _SUVBuilder = suvBuilder;
        }
        public void CreateAuto()
        {
            _SUVBuilder.SetSize();
            _SUVBuilder.SetDrive();
            _SUVBuilder.SetPackage();
            _SUVBuilder.SetWeight();
            _SUVBuilder.SetWheelSize();
        }
        public SUV GetSUV() => _SUVBuilder.GetSUV();
        
    }
}
