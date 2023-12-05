using Decorator.Data;

namespace Decorator
{
    public abstract class HotdogDecorator : Hotdog
    {
        protected Hotdog Hotdog;

        protected HotdogDecorator(Hotdog hotdog, HotdogDecorationData hotdogDecorationData)
            : base(hotdog.Name + hotdogDecorationData.ExtraName, hotdog.Price + hotdogDecorationData.ExtraPrice,
                hotdog.Weight + hotdogDecorationData.ExtraWeight)
        {
            Hotdog = hotdog;
        }
    }
}