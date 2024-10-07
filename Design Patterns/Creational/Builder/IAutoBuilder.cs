using Design_Patterns.Models;

namespace Design_Patterns.Creational.Builder
{
    public interface IAutoBuilder // from first example.
    {
        void SetWheelSize();
        void SetWeight();
        void SetPackage();
        void SetDrive();
        Auto GetAuto();
    }
}