using Decorator.Data;

namespace Decorator
{
    public abstract class Hotdog
    {
        public string Name { get; protected set; }
        public int Price { get; protected set; }
        public int Weight { get; protected set; }

        public Hotdog(string name, int price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public virtual string GetName() => Name;
        public virtual int GetCost() => Price;
        public virtual int GetWeight() => Weight;
    }
}