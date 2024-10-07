using Design_Patterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Builder
{
    public interface ISUVBuilder
    {
        void SetWheelSize();
        void SetWeight();
        void SetPackage();
        void SetDrive();
        void SetSize();
        SUV GetSUV();
    }
}
