using Design_Patterns.Creational.AbstractFactory;

namespace Design_Patterns.Clients
{
    public class AbstractFactoryBuilderHybridThingClient
    {
        public static void BuildAutoFromAbstractFactory()
        {
            var userInput = Models.Enums.CarModel.Rouge;

            AutoFactory autoFactory = new NissanFactory();

            var result = autoFactory.CreateSUV(userInput);

            Helpers.GenericHelpers.GetAllProperites(result);

        }
    }
}
