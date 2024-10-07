using Design_Patterns.Creational.AbstractFactory;
using Design_Patterns.Creational.Builder;
using Design_Patterns.Models.Enums;
using System.Runtime.CompilerServices;

namespace Design_Patterns.Clients
{
    public class AbstractFactoryBuilderHybridThingClient
    {
        private IAutoFactory _autoFactory;
        public AbstractFactoryBuilderHybridThingClient(IAutoFactory autoFactory)
        {
            _autoFactory = autoFactory;
        }
   
        public void BuildAutoFromAbstractFactory(CarModel carModel)
        {
            var result = this._autoFactory.CreateSUV(carModel);

            result.Manufactorer = Manufactorer.Nissan;
            result.CarModel = carModel;

            Helpers.GenericHelpers.GetAllProperites(result);
        }
    }
}
