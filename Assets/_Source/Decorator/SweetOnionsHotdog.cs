using Decorator.Data;

namespace Decorator
{
    public class SweetOnionsHotdog : HotdogDecorator
    {
        public SweetOnionsHotdog(Hotdog hotdog, HotdogDecorationData hotdogDecorationData) : base(hotdog, hotdogDecorationData)
        {
        }
    }
}