using Decorator.Data;

namespace Decorator
{
    public class PicklesHotdog : HotdogDecorator
    {
        public PicklesHotdog(Hotdog hotdog, HotdogDecorationData hotdogDecorationData) : base(hotdog, hotdogDecorationData)
        {
        }
    }
}