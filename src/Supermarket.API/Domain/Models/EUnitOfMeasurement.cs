using System.ComponentModel;

namespace Supermarket.API.Domain.Models
{
public enum EUnitOfMeasurement:byte
    {
        [Description("UN")]
        Unity = 1,

        [Description("MG")]
        Miligram = 2,

        [Description("G")]
        Garam = 3,

        [Description("KG")]
        Kilogram = 4,

        [Description("L")]
        Liter = 5
        
    }
}
