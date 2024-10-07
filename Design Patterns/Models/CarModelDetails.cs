using Design_Patterns.Models.Enums;
using System.Collections.Generic;

public static class CarModelDetails
{
    public static readonly Dictionary<string, SUVSize> SUVSizes
    = new Dictionary<string, SUVSize>
        {
            { "Armada", SUVSize.Full },
            { "Rouge", SUVSize.Crossover }
        };

}