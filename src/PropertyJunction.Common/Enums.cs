using System.ComponentModel;

namespace PropertyJunction.Common
{
    public class Enums
    {
    }

    public enum PropertyType : int
    {
        [Description("~/Bunglow")]
        Bunglow = 0,
        [Description("~/Commercials")]
        Commercials = 1,
        [Description("~/Flat")]
        Flat = 2,
        [Description("~/House")]
        House = 3,
        [Description("~/Land")]
        Land = 4,
        [Description("~/Project")]
        Project = 5
    }
}
